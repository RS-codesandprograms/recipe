
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
            Recipe.Save(dtRecipe);
        }






        private void Delete()
        {
            Recipe.Delete(dtRecipe);
            this.Close();
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