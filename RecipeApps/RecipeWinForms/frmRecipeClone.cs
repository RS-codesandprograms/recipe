namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        public frmRecipeClone()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstRecipeName, ListManager.GetList("Recipe"), null, "Recipe");

        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            {
                Cursor = Cursors.WaitCursor;
                int baserecipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeName);
                try
                {


                    SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
                    SQLUtility.SetParamValue(cmd, "@baserecipeid", baserecipeid);



                    SQLUtility.ExecuteSQL(cmd);

                    bool b = int.TryParse(cmd.Parameters["@Recipeid"].Value.ToString(), out int pkvalue);
                    if (b)
                    {
                        if (this.MdiParent != null && this.MdiParent is frmMain)
                        {
                            ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), pkvalue);
                            this.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
    }
}
