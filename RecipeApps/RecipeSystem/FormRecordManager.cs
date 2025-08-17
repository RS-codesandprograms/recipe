namespace RecipeSystem
{
    public class FormRecordManager
    {
        //Use for parent records or records with no children. 
        public static DataTable LoadRecord(string tablename, int recordid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand($"{tablename}Get");
            cmd.Parameters[$"@{tablename}Id"].Value = recordid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        //Use for child record. 
        public static DataTable LoadChildRecords(string childtablename, string parenttablename, int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(childtablename + "Get");
            SQLUtility.SetParamValue(cmd, $"@{parenttablename}id", pkvalue ); 
             return SQLUtility.GetDataTable(cmd);

        }
        // Used for both parent and child records. 
        //When saving a parent table, use the parent tablename for the childtablename as well. 
        public static void SaveTable(DataTable dt, string parenttablename, string childtablename, int pkvalue)
        {
            if(dt.Rows.Count == 0)
            {
                throw new Exception($"Cannot save {dt} table because there are no rows in the table.");
            }
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[$"{parenttablename}Id"] = pkvalue;
            }
            SQLUtility.SaveDataTable(dt, childtablename + "Update");
        }

        //Tablename/id is table where record is being deleted from (parent or child). 
        public static void Delete( string tablename, int tableid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand($"{childtablename}Delete");
            cmd.Parameters[$"@{childtablename}Id"].Value = tableid;
            SQLUtility.ExecuteSQL(cmd);
        }

        //Tablename is childtablename.
        public static void DeleteChildRecord(DataGridView grid, int rowindex, string tablename)
        {
            int id = WindowsFormUtility.GetIdFromGrid(grid, rowindex, $"{tablename}Id");
            if (id > 0)
            {
                try
                {
                    FormRecordManager.Delete(tablename, id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < grid.Rows.Count)
            {
                grid.Rows.RemoveAt(rowindex);
            }
        }

   

    }
}
