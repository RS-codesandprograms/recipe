
using CPUFramework;
using System.Data;

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
            this.FormClosing += FrmRecipe_FormClosing;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;

        }

        public void LoadRecipeForm(int RecipeId)
        {
            recipeid = RecipeId;
            this.Tag = recipeid;
            dtRecipe = Recipe.Load(RecipeId);
            bindsource.DataSource = dtRecipe;
            if (RecipeId == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtcuisines = ListManager.GetList("CuisineType");
            DataTable dtusernames = ListManager.GetList("Staff");


            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisines, dtRecipe, "CuisineType");
            WindowsFormUtility.SetListBinding(lstUserName, dtusernames, dtRecipe, "Staff");
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

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if(SQLUtility.DoesTableHasChanges(dtRecipe))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response) 
                
               {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        { e.Cancel = true;
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
      

        private void LoadRecipeDirections()
        {
            dtRecipeDirection = FormRecordManager.GetChildRecords("RecipeDirection", "Recipe", recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeDirection;
            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirection");
        }

        private void LoadRecipeIngredients()
        {
            dtRecipeIngredient = FormRecordManager.GetChildRecords("RecipeIngredient", "Recipe", recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtRecipeIngredient;
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, ListManager.GetList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, ListManager.GetList("MeasurementType", true), "MeasurementType", "MeasurementName");
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");


        }

 
        private void SaveRecipeIngredients()
        {

            try
            {
                FormRecordManager.SaveTable(dtRecipeIngredient, "Recipe", "RecipeIngredient", recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveRecipeDirections()
        {
            try
            {

                FormRecordManager.SaveTable(dtRecipeDirection, "Recipe", "RecipeDirection", recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeIngredients(int rowindex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                try {
                    FormRecordManager.Delete("RecipeIngredient", id);
                    LoadRecipeIngredients();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowindex);
            }
        }

        private void DeleteRecipeDirections()
        {

        }

        private string GetRecipeDesc()
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

        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
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
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "HeartyHearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();

        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredients(e.RowIndex);
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeDirections();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }
    }
}