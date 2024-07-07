using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

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

    }
}
