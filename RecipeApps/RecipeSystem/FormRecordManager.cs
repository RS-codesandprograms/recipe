namespace RecipeSystem
{
    public class FormRecordManager
    {
        public static DataTable LoadRecord(string tablename, int pkvalue)
        {
            
            SqlCommand cmd = SQLUtility.GetSQLCommand($"{tablename}Get");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", pkvalue);
            return SQLUtility.GetDataTable(cmd);
         
        }

        public static DataTable LoadChildRecords(string childtablename, string parenttablename, int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(childtablename + "Get");
            SQLUtility.SetParamValue(cmd, $"@{parenttablename}Id", pkvalue);
            return SQLUtility.GetDataTable(cmd);

        }

        public static void SaveTable(DataTable dt, string tablename)
        {
            if (dt.Rows.Count == 0)
            {
                throw new Exception($"Cannot call {dt}Save method because there are no rows in table.");
            }
            DataRow r = dt.Rows[0];
            SQLUtility.SaveDataRow(r, $"{tablename}Update");
            int id = (int)r[$"{tablename}Id"];
        }

        public static void SaveChildTable(DataTable dt, string parenttablename, string childtablename, int pkvalue)
        {
            if (dt.Rows.Count == 0)
            {
                throw new Exception($"Cannot save {dt} table because there are no rows in the table.");
            }
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[$"{parenttablename}Id"] = pkvalue;
            }
            SQLUtility.SaveDataTable(dt, $"{childtablename}Update");
        }

        
        public static void DeleteRecord(string tablename, int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand($"{tablename}Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", pkvalue);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void DeleteChildRecord(DataGridView grid, int rowindex, string childtablename)
        {
            int id = WindowsFormUtility.GetIdFromGrid(grid, rowindex, $"{childtablename}Id");
            if (id > 0)
            {
              
                    FormRecordManager.DeleteRecord(childtablename, id);
            }
            else if (id < grid.Rows.Count)
            {
                grid.Rows.RemoveAt(rowindex);
            }
        }



    }
}
