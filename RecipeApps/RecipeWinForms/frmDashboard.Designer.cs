namespace RecipeWinForms
{
    partial class frmDashboard
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
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSummary).BeginInit();
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
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tblMain.SetColumnSpan(lblTitle, 5);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(794, 90);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Hearty Hearth Desktop App\r\n";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            tblMain.SetColumnSpan(lblDescription, 5);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(3, 135);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(794, 90);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. You can also...";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gSummary
            // 
            gSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gSummary, 3);
            gSummary.Dock = DockStyle.Fill;
            gSummary.Location = new Point(163, 228);
            gSummary.Name = "gSummary";
            gSummary.RowTemplate.Height = 25;
            gSummary.Size = new Size(474, 174);
            gSummary.TabIndex = 3;
            gSummary.TabStop = false;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(163, 408);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(154, 39);
            btnRecipeList.TabIndex = 4;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(323, 408);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(154, 39);
            btnMealList.TabIndex = 5;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(483, 408);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(154, 39);
            btnCookbookList.TabIndex = 6;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "frmDashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblTitle;
        private Label lblDescription;
        private DataGridView gSummary;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}