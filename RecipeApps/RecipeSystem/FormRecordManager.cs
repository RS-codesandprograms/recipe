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

        
    
        
        public static void SaveTable(DataTable dt, string parenttablename, string childtablename, int pkvalue)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r[$"{parenttablename}Id"] = pkvalue;
            }
            SQLUtility.SaveDataTable(dt, childtablename + "Update");
        }

        public static void Delete( string childtablename, int childtableid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand($"{childtablename}Delete");
            cmd.Parameters[$"@{childtablename}Id"].Value = childtableid;
            SQLUtility.ExecuteSQL(cmd);
        }




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
