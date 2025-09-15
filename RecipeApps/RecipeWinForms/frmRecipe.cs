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
        List<Label> lststatusdates;
        List<Label> lststatusdatesvalid = new();

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
            txtCalories.TextChanged += TxtCalories_TextChanged;
            lststatusdates = new() { lblDraftDate, lblPublishedDate, lblArchivedDate };
            this.FormClosing += FrmRecipe_FormClosing;
        }

        

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.DoesTableHaveChanges(dtRecipe))
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
            this.Text = $"Recipe - {GetRecipeDesc()}";
            SetButtonsEnabledBasedOnNewRecord();

            this.Shown += FrmRecipe_Shown;

        }

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            txtRecipeName.SelectionStart = txtRecipeName.Text.Length;
           // WindowsFormUtility.DisplayDateTimeAsDate(lststatusdates, lststatusdatesvalid);
            lststatusdatesvalid.ForEach(lbl => lbl.Text = DateTime.Parse(lbl.Text).ToString("d"));
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
            WindowsFormUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);


            int colcount = gIngredients.Columns.Count;
            gIngredients.Columns["IngredientId"].DisplayIndex = colcount - 5;
            gIngredients.Columns["MeasurementType"].DisplayIndex = colcount - 4;
            gIngredients.Columns["IngredientAmount"].DisplayIndex = colcount - 3;
            gIngredients.Columns["IngredientSequence"].DisplayIndex = colcount - 2;
            gIngredients.Columns["deletecol"].DisplayIndex = colcount - 1;
            gIngredients.Columns["MeasurementType"].HeaderText = "Measurement";
            gIngredients.Columns["IngredientAmount"].HeaderText = "Quantity";
            gIngredients.Columns["IngredientSequence"].HeaderText = "Sequence";
        }

      




        private void LoadRecipeDirections()
        {
            dtRecipeDirection = FormRecordManager.LoadChildRecords("RecipeDirection", "Recipe", recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeDirection;
            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirection");
            gSteps.Columns["DirectionSequence"].HeaderText = "Sequence";
            gSteps.Columns["Instruction"].HeaderText = "Step";
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

      


        private void SaveRecipeChildren(DataTable dt, string childtablename)
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
                MessageBox.Show(ex.Message, Application.ProductName);
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
            this.Close();

        }
        private void TxtCalories_TextChanged(object? sender, EventArgs e)
        {
           WindowsFormUtility.ValidateUserInputNumericField(txtCalories.Text);
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
            var id = gSteps.Rows[e.RowIndex].Cells["RecipeDirectionId"].Value;


            if (e.RowIndex > -1 && gSteps.Columns[e.ColumnIndex].Name == deletecolname  && id != null && id != DBNull.Value && !string.IsNullOrWhiteSpace(id.ToString()))
            { 
                {
                    DeleteRecipeChild(gSteps, e.RowIndex, "RecipeDirection");
                    LoadRecipeDirections();
                }
            }
           
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            var id = gIngredients.Rows[e.RowIndex].Cells["RecipeIngredientId"].Value;
          

                  if( e.RowIndex > -1 && gIngredients.Columns[e.ColumnIndex].Name == deletecolname && id != null && id != DBNull.Value && !string.IsNullOrWhiteSpace(id.ToString()))

            {
                DeleteRecipeChild(gIngredients, e.RowIndex, "RecipeIngredient");
                LoadRecipeIngredients();
            }
        }


        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeChildren(dtRecipeDirection, "RecipeDirection");
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeChildren(dtRecipeIngredient, "RecipeIngredient");
        }

    
    }
}