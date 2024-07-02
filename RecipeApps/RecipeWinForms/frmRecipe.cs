using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{


    public partial class frmRecipe : Form
    {
        public DataTable dtRecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

        }


        public void ShowForm(int RecipeID)
        {
            Recipe.Load(RecipeID);

            if (RecipeID == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtcuisines = SQLUtility.GetDataTable("select CuisineTypeID, CuisineName from CuisineType");
            DataTable dtusernames = SQLUtility.GetDataTable("select StaffID, UserName from Staff");

            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisines, dtRecipe, "CuisineType");
            WindowsFormUtility.SetListBinding(lstUserName, dtusernames, dtRecipe, "Staff");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtDraftDate, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtPublishedDate, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtArchivedDate, dtRecipe);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, dtRecipe);
            WindowsFormUtility.SetControlBinding(lblRecipePicture, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeID"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
               $"RecipeName = '{r["RecipeName"]}',",
               $"StaffID = '{r["StaffID"]}',",
               $"CuisineTypeID = '{r["CuisineTypeID"]}',",
               $"Calories = '{r["Calories"]}',",
               $"DraftDate = '{r["Draftdate"]}',",
               $"PublishedDate = '{r["PublishedDate"]}',",
               $"ArchivedDate = '{r["ArchivedDate"]}'",
               $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "Insert Recipe(RecipeName, StaffID, CuisineTypeID, Calories, DraftDate, PublishedDate, ArchivedDate) ";
                sql += $"select '{r["RecipeName"]}','{r["StaffID"]}', '{r["CuisineTypeID"]}', '{r["Calories"]}', '{r["Draftdate"]}','{r["PublishedDate"]}', '{r["ArchivedDate"]}'";



            }
            Debug.Print(sql);
            Debug.Print("---------------");
            SQLUtility.ExecuteSQL(sql);
        }






        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeID"];
            string sql = "delete Recipe where RecipeID = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();

        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

  
    }
}