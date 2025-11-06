namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtRecipe = new DataTable();
        int recipeid;
        string recipename = "";
        List<Button> lstbuttons;
        List<Label> lststatusdates;
        List<Label> lststatusdatesvalid = new();
        BindingSource bindsource = new BindingSource();
        DateTime draftdate, publisheddate, archiveddate;
        string displaydraftdate, displaypublisheddate, displayarchiveddate;


        public frmChangeStatus()
        {
            InitializeComponent();
            lstbuttons = new() { btnDraft, btnPublish, btnArchive };
            lstbuttons.ForEach(b => b.Click += Btn_Click);
            lststatusdates = new() { lblDraftDate, lblPublishedDate, lblArchivedDate };
         
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
            DisplayDate();
          




            //WindowsFormUtility.DisplayDateTimeAsDate(lststatusdates, lststatusdatesvalid);

            SetButtonsEnabled();
        }

        private void RestoreDateTime()
        {
            if (lblDraftDate.Text.Contains(displaydraftdate))
            {
                lblDraftDate.Text = draftdate.ToString();
            }
        }

        private void DisplayDate()
        {
            if (string.IsNullOrWhiteSpace(lblDraftDate.Text) == false)
            {
                DateTime.TryParse(lblDraftDate.Text, out draftdate);
                displaydraftdate = draftdate.ToString("MM/dd/yyyy");
                lblDraftDate.Text = displaydraftdate;
            }
        }

        private void ConfirmUpdate(string status)
        {
            bindsource.EndEdit();
            var response = MessageBox.Show($"Are you sure want to change this recipe to {status.ToLower()}ed?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            if (response == DialogResult.Yes)
            {
                
                UpdateRecipeStatus(status);
                Save();


            }
        }
        private void UpdateRecipeStatus(string status)
        {
            switch (status)
            {
                case "Draft":
                    lblDraftDate.Text = DateTime.Now.ToString();
                    lblPublishedDate.Text = string.Empty;
                    lblArchivedDate.Text = string.Empty;
                    if (dtRecipe.Rows.Count > 0)
                    {
                        dtRecipe.Rows[0]["PublishedDate"] = DBNull.Value;
                        dtRecipe.Rows[0]["ArchivedDate"] = DBNull.Value;
                    }
                    break;

                case "Publish":
                    lblPublishedDate.Text = DateTime.Now.ToString();
                    lblArchivedDate.Text = string.Empty;
                    if (dtRecipe.Rows.Count > 0)
                    {
                        dtRecipe.Rows[0]["ArchivedDate"] = DBNull.Value;
                    }
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
                RestoreDateTime();
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
                foreach (Label lbl in lststatusdates)
                {
                    if (string.IsNullOrWhiteSpace(lbl.Text) == false)
                    {
                        lststatusdatesvalid.Add(lbl);
                    }
                }
                DisplayDate();
                // lststatusdatesvalid.ForEach(lbl => lbl.Text = DateTime.Parse(lbl.Text).ToString("d"));
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
