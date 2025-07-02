
using System.Data;

namespace RecipeWinForms
{


    public partial class frmRecipe : Form
    {
        public DataTable dtRecipe = new DataTable();
        BindingSource bindsource = new BindingSource();

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

        }



        public void Loadform(int RecipeID)
        {
            dtRecipe = Recipe.Load(RecipeID);
            bindsource.DataSource = dtRecipe; 
            if (RecipeID == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtcuisines = ListManager.GetList("CuisineType");
            DataTable dtusernames = ListManager.GetList("Staff");


            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisines, dtRecipe, "CuisineType");
            WindowsFormUtility.SetListBinding(lstUserName, dtusernames, dtRecipe, "Staff");
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetControlBinding(txtDraftDate, bindsource);
            WindowsFormUtility.SetControlBinding(txtPublishedDate, bindsource);
            WindowsFormUtility.SetControlBinding(txtArchivedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipePicture, bindsource);
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