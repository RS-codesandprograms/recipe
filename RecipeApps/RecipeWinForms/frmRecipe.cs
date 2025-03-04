
using System.Data;

namespace RecipeWinForms
{


    public partial class frmRecipe : Form
    {
        public DataTable dtRecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

        }



        public void ShowForm(int RecipeID)
        {
            dtRecipe = Recipe.Load(RecipeID);
            if (RecipeID == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtcuisines = Recipe.GetList("CuisineType");
            DataTable dtusernames = Recipe.GetList("Staff");


            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisines, dtRecipe, "CuisineType");
            WindowsFormUtility.SetListBinding(lstUserName, dtusernames, dtRecipe, "Staff");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtDraftDate, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtPublishedDate, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtArchivedDate, dtRecipe);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, dtRecipe);
            WindowsFormUtility.SetControlBinding(lblRecipePicture, dtRecipe);
            this.Show();

            if (txtDraftDate.Text == "")
            {
                txtDraftDate.Text = DateTime.Now.ToString();
            }
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
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