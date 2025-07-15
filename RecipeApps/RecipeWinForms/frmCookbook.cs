using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new DataTable();
        DataTable dtcookbookrecipes = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRecipeSave.Click += BtnSaveRecipe_Click;
         
            this.FormClosing += FrmCookbook_FormClosing;

        }

        

        public void LoadCookbookForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = ListManager.GetList ("Cookbook");
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            { dtcookbook.Rows.Add(); }
            DataTable dtstaff = ListManager.GetList("Staff",true);
            WindowsFormUtility.SetListBinding(lstUserName, dtstaff, dtcookbook, "Staff");

            WindowsFormUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblCookbookCreationDate, bindsource);
            //WindowsFormUtility.SetControlBinding(ckbActive, bindsource);

            //this.Text = 

            //LoadPresidentMedals();
            //SetButtonsEnabledBasedOnNewRecord();
            this.Show();

        }
        /*
        private void LoadPresidentMedals()
        {
            dtpresidentmedal = PresidentMedal.LoadByPresidentId(presidentid);
            gMedal.Columns.Clear();
            gMedal.DataSource = dtpresidentmedal;
            WindowsFormUtility.AddComboBoxToGrid(gMedal, DataMaintenance.GetDataList("Medal"), "Medal", "MedalName");
            WindowsFormUtility.AddDeleteButtonToGrid(gMedal, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gMedal, "PresidentMedal");
        }
        }
        */








        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            
        }


      

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
