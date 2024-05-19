using CPUFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{


    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }



        public void ShowForm(int RecipeID)
        {
            string sql =
                "select r.RecipeName, s.FirstName, s.LastName,  c.CuisineName, r.Calories, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.CurrentStatus, r.RecipePicture" +
                " from Recipe r" +
                " join Staff s" +
                " on r.StaffID = s.StaffID" +
                " join CuisineType c" +
                " on r.CuisineTypeID = c.CuisineTypeID" +
                " where r.RecipeID = " + RecipeID.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            SetControlBinding(txtRecipeName, dtRecipe);
            SetControlBinding(txtFirstName, dtRecipe);
            SetControlBinding(txtLastName, dtRecipe);
            SetControlBinding(lblCuisineName, dtRecipe);
            SetControlBinding(txtCalories, dtRecipe);
            SetControlBinding(txtDraftDate, dtRecipe);
            SetControlBinding(txtPublishedDate, dtRecipe);
            SetControlBinding(txtArchivedDate, dtRecipe);
            SetControlBinding(lblCurrentStatus, dtRecipe);
            SetControlBinding(txtRecipePicture, dtRecipe);
            this.Show();

        }

        public void SetControlBinding(Control ctrl, DataTable dt)
        {
            string propertyname = "";
            string columnname = "";
            string controlname = ctrl.Name.ToLower();
            if (controlname.StartsWith("txt") || controlname.StartsWith("lbl"))
            {
                propertyname = "Text";
                columnname = controlname.Substring(3);
            }
            if (propertyname != "" && columnname != "")
            { ctrl.DataBindings.Add(propertyname, dt, columnname, true, DataSourceUpdateMode.OnPropertyChanged); }

        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            string sql = string.Join(Environment.NewLine, $"update recipe set",
                $"RecipeName = '{r["RecipeName"]}',",
                $"FirstName = '{r["Firstname"]}',",
                $"LastName = '{r["LastName"]}',",
                $"CuisineName = '{r["CuisineName"]}',",
                $"Calories = '{r["Calories"]}',",
                $"DraftDate = '{r["Draftdate"]}',",
                $"PublishedDate = '{r["PublishedDate"]}',",
                $"ArchivedDate = '{r["ArchivedDate"]}',",
                $"RecipePicture = '{r["RecipePicture"]}',",
                $" where RecipeID = {r["RecipeID"]}");

            Debug.Print("---------------");
            Debug.Print(sql);

        }




        private void Delete()
        {

        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();

        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {

            Save();



        }

        private void lblCaptionCuisineType_Click(object sender, EventArgs e)
        {

        }
    }
}
