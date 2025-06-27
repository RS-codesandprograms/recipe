using System.Diagnostics.CodeAnalysis;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuRecipeNew.Click += MnuRecipeNew_Click;
            mnuRecipeClone.Click += MnuRecipeClone_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuCookbookNew.Click += MnuCookbookNew_Click;
            mnuCookbookAutoCreate.Click += MnuCookbookAutoCreate_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            this.Activated += FrmMain_Activated;

        }

        private void FrmMain_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gSummary.DataSource = ListManager.GetList("Summary", false);
            WindowsFormUtility.FormatGridForSearchResults(gSummary, "Summary");
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuCookbookAutoCreate_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuCookbookNew_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuRecipeClone_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuRecipeNew_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            
        }
    }
}
