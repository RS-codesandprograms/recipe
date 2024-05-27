using CPUFramework;
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
            string sql =
                //"select r.RecipeID, r.RecipeName, s.StaffID, s.UserName, c.CuisineTypeID,  c.CuisineName, r.Calories, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.CurrentStatus, r.RecipePicture" +
                "Select r.*, s.UserName, c.CuisineName" +
                " from Recipe r" +
                " join Staff s" +
                " on r.StaffID = s.StaffID" +
                " join CuisineType c" +
                " on r.CuisineTypeID = c.CuisineTypeID" +
                " where r.RecipeID = " + RecipeID.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            if (RecipeID == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtcuisines = SQLUtility.GetDataTable("select CuisineTypeID, CuisineName from CuisineType");
            DataTable dtusernames = SQLUtility.GetDataTable("select StaffID, UserName from Staff");
            SetListBinding(lstCuisineName, dtcuisines, dtRecipe, "CuisineType");
            SetListBinding(lstUserName, dtusernames, dtRecipe, "Staff");
            SetControlBinding(txtRecipeName, dtRecipe);
            SetControlBinding(txtCalories, dtRecipe);
            SetControlBinding(txtDraftDate, dtRecipe);
            SetControlBinding(txtPublishedDate, dtRecipe);
            SetControlBinding(txtArchivedDate, dtRecipe);
            //SetControlBinding(lblCurrentStatus, dtRecipe);
            //SetControlBinding(txtRecipePicture, dtRecipe);

            this.Show();
        }

        public static void SetListBinding(ComboBox lst, DataTable sourcedt, DataTable targetdt, string tablename)
        {
            lst.DataSource = sourcedt;
            lst.ValueMember = tablename + "ID";
            lst.DisplayMember = lst.Name.Substring(3);
            lst.DataBindings.Add("SelectedValue", targetdt, lst.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }


        public void SetControlBinding(Control ctrl, DataTable dt)
        {
            string propertyname = "";
             string controlname = ctrl.Name.ToLower();
            string controltype = controlname.Substring(0, 3);
            string columnname = controlname.Substring(3);
            switch (controltype)
            {
                case "txt":
                case "lbl":
                    propertyname = "Text";
                    break;
            }
            if (propertyname != "" && columnname != "")
            { ctrl.DataBindings.Add(propertyname, dt, columnname, true, DataSourceUpdateMode.OnPropertyChanged); }

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
            SQLUtility.DebugPrintDataTable(dtRecipe);
        }






        private void Delete()
        {

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