namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe = new DataTable();
        DataTable dtRecipeIngredient = new DataTable();
        DataTable dtRecipeDirection = new DataTable();
        int recipeid = 0;
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.FormClosing += FrmRecipe_FormClosing;

        }
        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.DoesTableHasChanges(dtRecipe))
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

        public void LoadRecipeForm(int RecipeId)
        {
            recipeid = RecipeId;
            this.Tag = recipeid;
            dtRecipe = FormRecordManager.LoadRecord("recipe", recipeid);
            bindsource.DataSource = dtRecipe;
            if (RecipeId == 0)
            {
                dtRecipe.Rows.Add();
            }

            WindowsFormUtility.SetListBinding(lstCuisineName, ListManager.GetList("CuisineType"), dtRecipe, "CuisineType");
            WindowsFormUtility.SetListBinding(lstUserName, ListManager.GetList("Staff"), dtRecipe, "Staff");
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetControlBinding(lblDraftDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblPublishedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblArchivedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);



            this.Text = GetRecipeDesc();
            SetButtonsEnabledBasedOnNewRecord();
            this.Shown += FrmRecipe_Shown;

        }

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            if (lblDraftDate.Text == "")

            {
                lblDraftDate.Text = DateTime.Now.ToString();

            }
            LoadRecipeIngredients();
            LoadRecipeDirections();
        }
        private void LoadRecipeIngredients()
        {
            dtRecipeIngredient = FormRecordManager.LoadChildRecords("RecipeIngredient", "Recipe", recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtRecipeIngredient;
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, ListManager.GetList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, ListManager.GetList("MeasurementType", true), "MeasurementType", "MeasurementName");
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
        }


        private void LoadRecipeDirections()
        {
            dtRecipeDirection = FormRecordManager.LoadChildRecords("RecipeDirection", "Recipe", recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeDirection;
            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirection");
        }

        private void SaveRecipeChildren(DataTable dt,  string childtablename)
        {
            try
            {
                FormRecordManager.SaveChildTable(dt, "Recipe", childtablename, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeChild(DataGridView grid, int rowindex, string childtablename)
        {
            try
            {
                FormRecordManager.DeleteChildRecord(grid, rowindex, childtablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnChangeStatus.Enabled = b;

        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                FormRecordManager.SaveTable(dtRecipe, "Recipe");
                b = true;
                bindsource.DataSource = dtRecipe;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
                SetButtonsEnabledBasedOnNewRecord();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                FormRecordManager.DeleteRecord("Recipe", recipeid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        public void LoadChangeStatus()
        {
            if (recipeid > -1)
            {
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
                }
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

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            LoadChangeStatus();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeChild(gSteps, e.RowIndex, "RecipeDirection");
            LoadRecipeDirections();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeChild(gIngredients, e.RowIndex, "RecipeIngredient");
            LoadRecipeIngredients();
        }


        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeChildren(dtRecipeDirection, "RecipeDirection");
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeChildren(dtRecipeIngredient,  "RecipeIngredient");
        }
    }
}