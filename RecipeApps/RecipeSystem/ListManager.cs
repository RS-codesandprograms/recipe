
namespace RecipeSystem
{
    public class ListManager
    {
        public static DataTable GetList(string tablename, bool all = true)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            if (all) { cmd.Parameters["@All"].Value = 1; }
            return SQLUtility.GetDataTable(cmd);
            
        }




    }
}
