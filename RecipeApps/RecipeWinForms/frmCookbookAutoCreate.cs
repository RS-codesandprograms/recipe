using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmCookbookAutoCreate : Form
    {
        int cookbookid = 0;
        public frmCookbookAutoCreate()
        {
            InitializeComponent();
            BindData();
            btnCreateCkbk.Click += BtnCreateCkbk_Click;
        }

        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstUserName, ListManager.GetList("Staff"), null, "Staff");
        }

        private void BtnCreateCkbk_Click(object? sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int staffid = WindowsFormUtility.GetIdFromComboBox(lstUserName);
            try
            {

                SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookAutoCreate");
                SQLUtility.SetParamValue(cmd, "@cookbookid", cookbookid);
                SQLUtility.SetParamValue(cmd, "@StaffId", staffid);
                SQLUtility.ExecuteSQL(cmd);

                bool b = int.TryParse(cmd.Parameters["@cookbookid"].Value.ToString(), out cookbookid);
                if (b == true && this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), cookbookid);
                    this.Close();

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
