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
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int RecipeID)
        {
            string sql =
                "select r.RecipeName, s.FirstName, s.LastName,  c.CuisineName, r.Calories, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.CurrentStatus, r.RecipePicture" +
                " from Recipe r" +
                " join Staff s" +
                " on r.StaffID = s.StaffID" +
                " join CuisineType c" +
                " on r.CuisineTypeID = c.CuisineTypeID" +
                " where r.RecipeID = " + RecipeID.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtFirstName.DataBindings.Add("Text", dt, "FirstName");
            txtLastName.DataBindings.Add("Text", dt, "LastName");
            lblCuisineType.DataBindings.Add("Text", dt, "CuisineName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDraftDate.DataBindings.Add("Text", dt, "DraftDate");
            txtPublishedDate.DataBindings.Add("Text", dt, "PublishedDate");
            txtArchivedDate.DataBindings.Add("Text", dt, "ArchivedDate");
            lblCurrentStatus.DataBindings.Add("Text", dt, "CurrentStatus");
            txtPicture.DataBindings.Add("Text", dt, "RecipePicture");
            this.Show();

        }

        private void lblCaptionStaff_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
