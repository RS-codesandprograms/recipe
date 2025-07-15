
using CPUFramework;
using System.Data;
using System.Data.SqlClient;

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
            btnDelete.Click += BtnDelete_Click; ;
            
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
            

            if (lblDraftDate.Text == "")
            {
                lblDraftDate.Text = DateTime.Now.ToString();
            }

            this.Text = GetRecipeDesc();
            this.Shown += FrmRecipe_Shown;

        }

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredients();
            
        }

        private void LoadRecipeIngredients()
        {
            dtRecipeIngredient = FormRecordManager.GetChildRecords("RecipeIngredient", "Recipe", recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtRecipeIngredient;
             WindowsFormUtility.AddComboBoxToGrid(gIngredients, ListManager.GetList("Ingredient"), "Ingredient", "IngredientName");
             WindowsFormUtility.AddComboBoxToGrid(gIngredients, ListManager.GetList("MeasurementType"), "MeasurementType", "MeasurementName");
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            //handel grid column header names
            WindowsFormUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");


        }
/*
 * 
        private void LoadPresidentMedals()
        {
            dtpresidentmedal = PresidentMedal.LoadByPresidentId(presidentid);
            gMedal.Columns.Clear();
            gMedal.DataSource = dtpresidentmedal;
            WindowsFormUtility.AddComboBoxToGrid(gMedal, DataMaintenance.GetDataList("Medal"), "Medal", "MedalName");
            WindowsFormUtility.AddDeleteButtonToGrid(gMedal, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gMedal, "PresidentMedal");
        }
        */
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

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
                bindsource.ResetBindings(false);
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


    }
}