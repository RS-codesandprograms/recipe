﻿using System;
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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            this.Activated += FrmRecipeList_Activated;
        }

    

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipeList.DataSource = ListManager.GetList("RecipeSummary", false, false);
            WindowsFormUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
        }


        private void LoadRecipe(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)

            {
                id = WindowsFormUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");

            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }
           
    

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            LoadRecipe(-1);
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            LoadRecipe(e.RowIndex);
        }
       
    }
}
