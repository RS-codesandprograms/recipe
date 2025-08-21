namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new DataTable();
        DataTable dtcookbookrecipes = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRecipeSave.Click += BtnSaveRecipe_Click;
            gCookbookRecipe.CellClick += GCookbookRecipe_CellClick;
            this.FormClosing += FrmCookbook_FormClosing;
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.DoesTableHasChanges(dtcookbook))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)

                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
        public void LoadCookbookForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = FormRecordManager.LoadRecord("cookbook", cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            { dtcookbook.Rows.Add(); }
            DataTable dtstaff = ListManager.GetList("Staff", true);
            WindowsFormUtility.SetListBinding(lstUserName, dtstaff, dtcookbook, "Staff");
            WindowsFormUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblCookbookCreationDate, bindsource);
            WindowsFormUtility.SetControlBinding(ckbIsActive, bindsource);
            this.Text = GetCookbookDesc();
            SetButtonsEnabledBasedOnNewRecord();
            this.Shown += FrmCookbook_Shown;

        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnRecipeSave.Enabled = b;

        }
        private string GetCookbookDesc()
        {

            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }
        private void FrmCookbook_Shown(object? sender, EventArgs e)
        {
            if (lblCookbookCreationDate.Text == "")

            {
                lblCookbookCreationDate.Text = DateTime.Now.ToString();

            }
            LoadCookbookRecipe();
            this.Show();
        }
        private void LoadCookbookRecipe()
        {
            dtcookbookrecipes = FormRecordManager.LoadChildRecords("CookbookRecipe", "Cookbook", cookbookid);
            gCookbookRecipe.Columns.Clear();
            gCookbookRecipe.DataSource = dtcookbookrecipes;
            WindowsFormUtility.AddComboBoxToGrid(gCookbookRecipe, ListManager.GetList("Recipe"), "Recipe", "RecipeName");
            WindowsFormUtility.AddDeleteButtonToGrid(gCookbookRecipe, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gCookbookRecipe, "RecipeIngredient");
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                FormRecordManager.SaveTable(dtcookbook, "Cookbook");
                b = true;
                bindsource.DataSource = dtcookbook;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "cookbookid");
                this.Tag = cookbookid;
                this.Text = GetCookbookDesc();
                SetButtonsEnabledBasedOnNewRecord();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;

            }
            return b;
        }
        private void Delete()
        {
            var response = MessageBox.Show($"Are you sure you want to delete cookbook {this.Text}?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                FormRecordManager.DeleteRecord("Cookbook", cookbookid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        
        private void SaveRecipe()
        {
            try
            {
                FormRecordManager.SaveChildTable(dtcookbookrecipes, "Cookbook", "CookbookRecipe", cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipe(int rowindex)
        {
            try
            {
                FormRecordManager.DeleteChildRecord(gCookbookRecipe, rowindex, "CookbookRecipe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
      

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveRecipe();
        }
        private void GCookbookRecipe_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            
            DeleteRecipe(e.RowIndex);
            LoadCookbookRecipe();
        }

    }
}
