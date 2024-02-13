using CPUFramework;
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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
        }

        private void SearchForRecipe(string recipename)
        {
            string sql = "select * from Recipe r where r.recipename = '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt; 
        }

        //private void SearchForPresident(string lastname)
        //{
        //    string sql = "select PresidentId, Num, LastName, FirstName from president p where p.lastname like '%" + lastname + "%'";

        //    DataTable dt = SQLUtility.GetDataTable(sql);
        //    gPresidents.DataSource = dt;
        //    gPresidents.Columns["PresidentId"].Visible = false;

        //}




        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }
        


    }
}
