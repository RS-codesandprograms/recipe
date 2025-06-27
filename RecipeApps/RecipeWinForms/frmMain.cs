using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.ActiveDirectory;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += RecipeList_Click;
            mnuRecipeNew.Click += MnuRecipeNew_Click;
            mnuRecipeClone.Click += MnuRecipeClone_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuCookbookNew.Click += MnuCookbookNew_Click;
            mnuCookbookAutoCreate.Click += MnuCookbookAutoCreate_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            btnRecipeList.Click += RecipeList_Click;
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

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormUtility.IsFormOpen(frmtype, pkvalue);
            if(b == false)
            {
                Form? newfrm = null;
                if(frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f; 
                }
                newfrm.MdiParent = this;
                newfrm.WindowState = FormWindowState.Maximized;
                newfrm.FormClosed += Newfrm_FormClosed; ;
                newfrm.TextChanged += Newfrm_TextChanged; ;
                newfrm.Show();
            }
           WindowsFormUtility.SetupNav(tsMain);
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
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
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
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

        private void RecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            
        }
    }
}
