using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class FormRecordManager
    {

        public static DataTable GetChildRecords(string tablename, string parent, int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, $"@{parent}id", pkvalue ); 
             return SQLUtility.GetDataTable(cmd);

        }
    }
}
