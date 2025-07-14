using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
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

       private void OpenMdiChildFormFromButton(Type form)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(form);
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            OpenMdiChildFormFromButton(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            OpenMdiChildFormFromButton(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            OpenMdiChildFormFromButton(typeof(frmRecipeList));
        }




    }
}
