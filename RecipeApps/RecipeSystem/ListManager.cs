namespace RecipeSystem
{
    public class ListManager
    {
        public static DataTable GetList(string tablename, bool includeblank = false, bool all = true, bool summary = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand($"{tablename}Get");
            if (all) { SQLUtility.SetParamValue(cmd, "@All", 1); }
            if (includeblank) { SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1); }
            if (summary) { SQLUtility.SetParamValue(cmd, "@Summary", 1); }
            return SQLUtility.GetDataTable(cmd);

        }

        public static void DeleteListRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }








    }



}
