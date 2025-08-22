namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtRecipe = new DataTable();
        int recipeid;
        string recipename = "";
        List<Button> lstbuttons;
        BindingSource bindsource = new BindingSource();

        public frmChangeStatus()
        {
            InitializeComponent();
            lstbuttons = new() { btnDraft, btnPublish, btnArchive };
            lstbuttons.ForEach(b => b.Click += Btn_Click);
            this.FormClosing += FrmChangeStatus_FormClosing;
          
        }

        private void FrmChangeStatus_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
            }
        }

  

        public void LoadChangeStatusForm(int Recipeid)
        {
            recipeid = Recipeid;
            this.Tag = recipeid;
            dtRecipe = FormRecordManager.LoadRecord("recipe", recipeid);
            bindsource.DataSource = dtRecipe;
            recipename = SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            WindowsFormUtility.SetControlBinding(lblDraftDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblPublishedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblArchivedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);
            this.Text = $"{recipename} - {this.Text}";
            lblTitle.Text = recipename;
            this.Shown += FrmChangeStatus_Shown;

        }

        private void FrmChangeStatus_Shown(object? sender, EventArgs e)
        {
            SetButtonsEnabled();
        }
        private void ConfirmUpdate(string status)
        {
            bindsource.EndEdit();
            var response = MessageBox.Show($"Are you sure want to change this recipe to {status.ToLower()}ed?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            if (response == DialogResult.Yes)
            {
                UpdateRecipeStatus(status);
                Save();

                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
                }
                this.Close();
            }
        }
        private void UpdateRecipeStatus(string status)
        {
            switch (status)
            {
                case "Draft": 
                    lblDraftDate.Text = DateTime.Now.ToString();
                    break;  

                case "Publish": 
                    lblPublishedDate.Text = DateTime.Now.ToString();
                    break;

                case "Archive": 
                    lblArchivedDate.Text = DateTime.Now.ToString();
                    break;
            }
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                FormRecordManager.SaveTable(dtRecipe, "Recipe");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                bindsource.DataSource = dtRecipe;
                bindsource.ResetBindings(false); 
                SetButtonsEnabled();
                Application.UseWaitCursor = false;
            }


        }

        private void SetButtonsEnabled()
        {
            lstbuttons.ForEach(b => b.Enabled = true);
            switch (lblCurrentStatus.Text)
            {
                case "Draft":
                    btnDraft.Enabled = false;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    break;
            }
        }


        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ConfirmUpdate(btn.Text);
        }


    }
}
