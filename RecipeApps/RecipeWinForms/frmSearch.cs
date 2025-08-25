﻿namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            //WindowsFormUtility.FormatGridForSearchResults(gRecipe);
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;

        }



        private void SearchForRecipe(string recipename)
        {
            DataTable dt = Recipe.SearchForRecipe(recipename);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.LoadRecipeForm(id);
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
