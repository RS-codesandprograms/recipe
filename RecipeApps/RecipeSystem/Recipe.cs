using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchForRecipe(string RecipeName)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = RecipeName;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int RecipeID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = RecipeID;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetList(string tablename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtRecipe)
        {
           // SQLUtility.DebugPrintDataTable(dtRecipe);
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
            //Debug.Print(sql);
            //Debug.Print("---------------");
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
