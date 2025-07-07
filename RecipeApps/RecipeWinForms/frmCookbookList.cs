using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            this.Activated += FrmCookbookList_Activated;
        }

       

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gCookbookList.DataSource = ListManager.GetList("CookbookSummary", false);
            WindowsFormUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
        }

        private void LoadCookbook(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)

            {
                id = WindowsFormUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");

            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            LoadCookbook(-1); 
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            LoadCookbook(e.RowIndex);
        }
    }
}
