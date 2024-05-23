﻿using CPUFramework;
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



        public  void ShowForm(int RecipeID)
        {
            string sql =
                "select r.RecipeID, r.RecipeName, s.StaffID, s.FirstName, s.LastName, c.CuisineTypeId,  c.CuisineName, r.Calories, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.CurrentStatus, r.RecipePicture" +
                " from Recipe r" +
                " join Staff s" +
                " on r.StaffID = s.StaffID" +
                " join CuisineType c" +
                " on r.CuisineTypeID = c.CuisineTypeID" +
                " where r.RecipeID = " + RecipeID.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            DataTable dtcuisines = SQLUtility.GetDataTable("select CuisineTypeID, CuisineName from CuisineType");
            DataTable dtusernames = SQLUtility.GetDataTable("select StaffID, UserName from Staff");
            SetListBinding(lstCuisineName, dtcuisines, dtRecipe, "CuisineType");
            SetListBinding(lstUserName, dtusernames, dtRecipe, "Staff");


            SetControlBinding(txtRecipeName, dtRecipe);
            //SetControlBinding(txtFirstName, dtRecipe);
            //SetControlBinding(txtLastName, dtRecipe);
            //SetControlBinding(lblCuisineName, dtRecipe);
            SetControlBinding(txtCalories, dtRecipe);
            SetControlBinding(txtDraftDate, dtRecipe);
            SetControlBinding(txtPublishedDate, dtRecipe);
            SetControlBinding(txtArchivedDate, dtRecipe);
            SetControlBinding(lblCurrentStatus, dtRecipe);
            SetControlBinding(txtRecipePicture, dtRecipe);
            this.Show();

        }

        public static void SetListBinding(ComboBox lst, DataTable sourcedt, DataTable targetdt, string tablename)
        {
            lst.DataSource = sourcedt;
            lst.ValueMember = tablename + "ID";
            lst.DisplayMember = lst.Name.Substring(3);
            
            lst.DataBindings.Add("SelectedValue", targetdt, lst.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            
        }

     

        /*
         
         * lst.ValueMember = tablename + "Id";
        public static void SetListBinding(ComboBox lst, DataTable sourcedt, DataTable targetdt, string tablename)
        {
            lst.DataSource = sourcedt;
            lst.ValueMember = tablename + "Id";
            lst.DisplayMember = lst.Name.Substring(3);
            lst.DataBindings.Add("SelectedValue", targetdt, lst.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);

        }
        */

        public void SetControlBinding(Control ctrl, DataTable dt)
        {
            string propertyname = "";
            string columnname = "";
            string controlname = ctrl.Name.ToLower();
            if (controlname.StartsWith("txt") || controlname.StartsWith("lbl"))
            {
                propertyname = "Text";
                columnname = controlname.Substring(3);
            }
            if (propertyname != "" && columnname != "")
            { ctrl.DataBindings.Add(propertyname, dt, columnname, true, DataSourceUpdateMode.OnPropertyChanged); }

        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            string sql = string.Join(Environment.NewLine, $"update recipe set",
                $"RecipeName = '{r["RecipeName"]}',",
                //$"FirstName = '{r["Firstname"]}',",
                //$"LastName = '{r["LastName"]}',",
                $"CuisineTypeID = '{r["CuisineTypeID"]}',",
                $"Calories = '{r["Calories"]}',",
                $"DraftDate = '{r["Draftdate"]}',",
                $"PublishedDate = '{r["PublishedDate"]}',",
                $"ArchivedDate = '{r["ArchivedDate"]}',",
                $"RecipePicture = '{r["RecipePicture"]}'",
                $"where RecipeId = {r["RecipeId"]}");

            /*
             * 
             * $"update president set",
                   $"PartyId = '{r["PartyId"]}',",
                   $"Num = '{r["Num"]}',",
                   $"LastName = '{r["LastName"]}',",
                   $"FirstName = '{r["FirstName"]}',",
                   $"DateBorn = '{r["DateBorn"]}',",
                  $"TermStart = '{r["TermStart"]}'",
                    $" where PresidentId = {r["PresidentId"]}");
             * */



            Debug.Print("---------------");
            Debug.Print(sql);
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