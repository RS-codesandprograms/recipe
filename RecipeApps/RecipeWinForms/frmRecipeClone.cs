using CPUFramework;
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
                int recipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeName);
                try
                {

                    SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
                    SQLUtility.SetParamValue(cmd, "@baserecipeid", recipeid);
                    SQLUtility.ExecuteSQL(cmd);

                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe));
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
}
