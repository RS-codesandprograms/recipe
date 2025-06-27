namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            lblTitle = new Label();
            lblDescription = new Label();
            gSummary = new DataGridView();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuRecipeNew = new ToolStripMenuItem();
            mnuRecipeClone = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbooksList = new ToolStripMenuItem();
            mnuCookbookNew = new ToolStripMenuItem();
            mnuCookbookAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuTile = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSummary).BeginInit();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(lblTitle, 0, 1);
            tblMain.Controls.Add(lblDescription, 0, 2);
            tblMain.Controls.Add(gSummary, 1, 3);
            tblMain.Controls.Add(btnRecipeList, 1, 4);
            tblMain.Controls.Add(btnMealList, 2, 4);
            tblMain.Controls.Add(btnCookbookList, 3, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tblMain.SetColumnSpan(lblTitle, 5);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1023, 126);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Hearty Hearth Desktop App\r\n";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            tblMain.SetColumnSpan(lblDescription, 5);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(3, 189);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1023, 126);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. You can also...";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gSummary
            // 
            gSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gSummary, 3);
            gSummary.Dock = DockStyle.Fill;
            gSummary.Location = new Point(208, 318);
            gSummary.Name = "gSummary";
            gSummary.RowTemplate.Height = 25;
            gSummary.Size = new Size(609, 246);
            gSummary.TabIndex = 3;
            gSummary.TabStop = false;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(208, 570);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(199, 57);
            btnRecipeList.TabIndex = 4;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(413, 570);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(199, 57);
            btnMealList.TabIndex = 5;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(618, 570);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(199, 57);
            btnCookbookList.TabIndex = 6;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuTile });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1029, 29);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(156, 26);
            mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuRecipeNew, mnuRecipeClone });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(75, 25);
            mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(170, 26);
            mnuRecipeList.Text = "List";
            // 
            // mnuRecipeNew
            // 
            mnuRecipeNew.Name = "mnuRecipeNew";
            mnuRecipeNew.Size = new Size(170, 26);
            mnuRecipeNew.Text = "New Recipe";
            // 
            // mnuRecipeClone
            // 
            mnuRecipeClone.Name = "mnuRecipeClone";
            mnuRecipeClone.Size = new Size(170, 26);
            mnuRecipeClone.Text = "Clone Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(63, 25);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(104, 26);
            mnuMealsList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbooksList, mnuCookbookNew, mnuCookbookAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(100, 25);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbooksList
            // 
            mnuCookbooksList.Name = "mnuCookbooksList";
            mnuCookbooksList.Size = new Size(187, 26);
            mnuCookbooksList.Text = "List";
            // 
            // mnuCookbookNew
            // 
            mnuCookbookNew.Name = "mnuCookbookNew";
            mnuCookbookNew.Size = new Size(187, 26);
            mnuCookbookNew.Text = "New Cookbook";
            // 
            // mnuCookbookAutoCreate
            // 
            mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            mnuCookbookAutoCreate.Size = new Size(187, 26);
            mnuCookbookAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(147, 25);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(142, 26);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuTile
            // 
            mnuTile.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowTile, mnuWindowCascade });
            mnuTile.Name = "mnuTile";
            mnuTile.Size = new Size(87, 25);
            mnuTile.Text = "Windows";
            // 
            // mnuWindowTile
            // 
            mnuWindowTile.Name = "mnuWindowTile";
            mnuWindowTile.Size = new Size(180, 26);
            mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(180, 26);
            mnuWindowCascade.Text = "Cascade";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(mnuMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSummary).EndInit();
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuRecipeNew;
        private ToolStripMenuItem mnuRecipeClone;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbooksList;
        private ToolStripMenuItem mnuCookbookNew;
        private ToolStripMenuItem mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private Label lblTitle;
        private Label lblDescription;
        private DataGridView gSummary;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}