using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class ListManager
    {
        public static DataTable GetList(string tablename, bool all = true)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            if (all) { cmd.Parameters["@All"].Value = 1; }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }





    }
}
