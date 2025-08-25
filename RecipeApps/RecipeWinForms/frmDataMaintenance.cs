namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {

        private enum TableTypeEnum { Staff, CuisineType, Ingredient, MeasurementType, Course };
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Staff;
        string deletecolname = "deletecol";


        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            SetupRadioButtions();
            gData.CellContentClick += GData_CellClick;
            BindData(currenttabletype);
        }


        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = ListManager.GetList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gData, currenttabletype.ToString());


        }

        private void SetupRadioButtions()
        {
            foreach (Control c in pnlOptionButton.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click1;
                }
                optStaff.Tag = TableTypeEnum.Staff;
                optCuisineType.Tag = TableTypeEnum.CuisineType;
                optIngredient.Tag = TableTypeEnum.Ingredient;
                optMeasurementType.Tag = TableTypeEnum.MeasurementType;
                optCourse.Tag = TableTypeEnum.Course;
            }
        }


        private void C_Click1(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void Delete(int rowindex)
        {
            string name = " ";
            foreach (RadioButton o in pnlOptionButton.Controls)
            {
                if (o is RadioButton && o.Checked == true && o.Text != null)
                {
                    if (o.Text.EndsWith('s'))
                    {
                        name = o.Text.ToString().Substring(0, o.Text.Length - 1);
                    }
                    else { name = o.Text.ToString(); }
                }
            }
            string deletemessage = $"Are you sure you want to delete this {name}?";
            if (currenttabletype == TableTypeEnum.Staff)
            {
                deletemessage = "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
            }

            int id = WindowsFormUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            var response = MessageBox.Show(deletemessage, Application.ProductName, MessageBoxButtons.YesNoCancel);
            if (response == DialogResult.No || response == DialogResult.Cancel)
            {
                return;
            }

            if (id != 0)
            {
                try
                {
                    Application.UseWaitCursor = true;
                    ListManager.DeleteListRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }

        }


        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                ListManager.SaveList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }





        private void GData_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.DoesTableHaveChanges(dtlist))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();

                        break;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        
    }
}
