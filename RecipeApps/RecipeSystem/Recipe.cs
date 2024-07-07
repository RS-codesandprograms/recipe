using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchForRecipe(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int RecipeID)
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
           return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetList(string tablename, string columnname)
        {
            string sql = "select " + tablename + "ID, " + columnname + " from " + tablename;
             return SQLUtility.GetDataTable(sql);
           
        }

        public static void Save(DataTable dtRecipe)
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
               $"DraftDate = '{r["Draftdate"]}'",
               $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {

                sql = "Insert Recipe(RecipeName, StaffID, CuisineTypeID, Calories, DraftDate) ";
                sql += $"select '{r["RecipeName"]}','{r["StaffID"]}', '{r["CuisineTypeID"]}', '{r["Calories"]}', '{r["Draftdate"]}'";



            }
            Debug.Print(sql);
            Debug.Print("---------------");
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeID"];
            string sql = "delete Recipe where RecipeID = " + id;
            SQLUtility.ExecuteSQL(sql);
        }

    }
}
