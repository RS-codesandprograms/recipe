using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtRecipe = new DataTable();
        int recipeid;
        string recipename = ""; 
        BindingSource bindsource = new BindingSource();



        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += Btn_Click;
            btnPublish.Click += Btn_Click;
            btnArchive.Click += Btn_Click; 
        }
        public void LoadChangeStatusForm(int Recipeid)
        {
            recipeid = Recipeid;
            this.Tag = recipeid;
            dtRecipe = FormRecordManager.LoadRecord("recipe", recipeid);
            bindsource.DataSource = dtRecipe;
            recipename = SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            WindowsFormUtility.SetControlBinding(lblDraftDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblPublishedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblArchivedDate, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);




            this.Text = $"{this.Text} {recipename}";
            lblTitle.Text = recipename;
            this.Shown += FrmChangeStatus_Shown;

        }

        private void FrmChangeStatus_Shown(object? sender, EventArgs e)
        {
            SetButtonsEnabled(); 
        }
        private void UpdateRecipeStatus(string buttonname)
        {

            switch(buttonname)
            {
                case "btnDraft":
                    lblDraftDate.Text = DateTime.Now.ToString();
                    break;

                case "btnPublish":
                    lblPublishedDate.Text = DateTime.Now.ToString();
                    break;
                case "btnArchive":
                    lblArchivedDate.Text = DateTime.Now.ToString();
                    break;
                }
        }


       

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                FormRecordManager.Save(dtRecipe, "Recipe");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                bindsource.ResetBindings(false);
                SetButtonsEnabled();
                Application.UseWaitCursor = false;
            }
         

        }

        private void SetButtonsEnabled()
        {
            tblControls.Enabled = true; 
            switch (lblCurrentStatus.Text)
            {
                case "Draft":
                    btnDraft.Enabled = false;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    break; 
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            UpdateRecipeStatus(btn.Name);
            Save();
            
            
        }

        
    }
}
