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


        public static void SaveTable(DataTable dt, string tablename, int pkvalue)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[$"{tablename}Id"] = pkvalue;
            }
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }
        /*
        public static void SaveTable(DataTable dt, string tablename, int presidentid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["PresidentId"] = presidentid;
            }
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        */
        public static void Delete(int presidentmedalid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("PresidentMedalDelete");
            cmd.Parameters["@PresidentMedalId"].Value = presidentmedalid;
            SQLUtility.ExecuteSQL(cmd);
        }


    }
}
