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
            FormatGrid();
        }

        private void SearchForRecipe(string recipename)
        {
            string sql = "select r.recipename from Recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt; 
        }

        private void FormatGrid()
        {
            gRecipe.AllowUserToAddRows = false;
            gRecipe.ReadOnly = true;
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        
        
       




        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }
        


    }
}
