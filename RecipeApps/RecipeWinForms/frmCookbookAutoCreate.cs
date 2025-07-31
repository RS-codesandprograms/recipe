using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (this.MdiParent != null && this.MdiParent is frmMain)
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
