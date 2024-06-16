using CPUFramework;
using CPUWindowsFormsFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            WindowsFormUtility.FormatGridForSearchResults(gRecipe);
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
        }



        private void SearchForRecipe(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeID"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }


        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);

        }

    }
}
