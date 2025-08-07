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

    
      

        public static void Save(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave method because there are no rows in table.");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
            int id = (int)r["RecipeID"];
        }


        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeID"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeID", id);
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
