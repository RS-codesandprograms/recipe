namespace RecipeWinForms
{
    partial class frmRecipe
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionCuisineType = new System.Windows.Forms.Label();
            this.lblCaptionFirstName = new System.Windows.Forms.Label();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionPicture = new System.Windows.Forms.Label();
            this.lblCaptionCurrentStatus = new System.Windows.Forms.Label();
            this.lblCaptionArchivedDate = new System.Windows.Forms.Label();
            this.lblCaptionPublishedDate = new System.Windows.Forms.Label();
            this.lblCaptionDraftDate = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.txtArchivedDate = new System.Windows.Forms.TextBox();
            this.txtPublishedDate = new System.Windows.Forms.TextBox();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtCuisineType = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCaptionLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblCaptionCuisineType, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionFirstName, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lblCaptionPicture, 0, 9);
            this.tblMain.Controls.Add(this.lblCaptionCurrentStatus, 0, 8);
            this.tblMain.Controls.Add(this.lblCaptionArchivedDate, 0, 7);
            this.tblMain.Controls.Add(this.lblCaptionPublishedDate, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionDraftDate, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 4);
            this.tblMain.Controls.Add(this.txtPicture, 1, 9);
            this.tblMain.Controls.Add(this.txtCurrentStatus, 1, 8);
            this.tblMain.Controls.Add(this.txtArchivedDate, 1, 7);
            this.tblMain.Controls.Add(this.txtPublishedDate, 1, 6);
            this.tblMain.Controls.Add(this.txtDraftDate, 1, 5);
            this.tblMain.Controls.Add(this.txtCalories, 1, 4);
            this.tblMain.Controls.Add(this.txtCuisineType, 1, 3);
            this.tblMain.Controls.Add(this.txtFirstName, 1, 1);
            this.tblMain.Controls.Add(this.lblCaptionLastName, 0, 2);
            this.tblMain.Controls.Add(this.txtLastName, 1, 2);
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 1);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(800, 578);
            this.tblMain.TabIndex = 0;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMain_Paint);
            // 
            // lblCaptionCuisineType
            // 
            this.lblCaptionCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisineType.AutoSize = true;
            this.lblCaptionCuisineType.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCuisineType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCuisineType.Location = new System.Drawing.Point(3, 180);
            this.lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            this.lblCaptionCuisineType.Size = new System.Drawing.Size(173, 38);
            this.lblCaptionCuisineType.TabIndex = 19;
            this.lblCaptionCuisineType.Text = "Cuisine Type";
            // 
            // lblCaptionFirstName
            // 
            this.lblCaptionFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionFirstName.AutoSize = true;
            this.lblCaptionFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionFirstName.Location = new System.Drawing.Point(3, 66);
            this.lblCaptionFirstName.Name = "lblCaptionFirstName";
            this.lblCaptionFirstName.Size = new System.Drawing.Size(143, 38);
            this.lblCaptionFirstName.TabIndex = 18;
            this.lblCaptionFirstName.Text = "FirstName";
            this.lblCaptionFirstName.Click += new System.EventHandler(this.lblCaptionStaff_Click);
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionRecipeName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 9);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(181, 38);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(403, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.ReadOnly = true;
            this.txtRecipeName.Size = new System.Drawing.Size(394, 45);
            this.txtRecipeName.TabIndex = 7;
            // 
            // lblCaptionPicture
            // 
            this.lblCaptionPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPicture.AutoSize = true;
            this.lblCaptionPicture.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionPicture.Location = new System.Drawing.Point(3, 526);
            this.lblCaptionPicture.Name = "lblCaptionPicture";
            this.lblCaptionPicture.Size = new System.Drawing.Size(103, 38);
            this.lblCaptionPicture.TabIndex = 6;
            this.lblCaptionPicture.Text = "Picture";
            // 
            // lblCaptionCurrentStatus
            // 
            this.lblCaptionCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCurrentStatus.AutoSize = true;
            this.lblCaptionCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCurrentStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCurrentStatus.Location = new System.Drawing.Point(3, 465);
            this.lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            this.lblCaptionCurrentStatus.Size = new System.Drawing.Size(192, 38);
            this.lblCaptionCurrentStatus.TabIndex = 5;
            this.lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // lblCaptionArchivedDate
            // 
            this.lblCaptionArchivedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionArchivedDate.AutoSize = true;
            this.lblCaptionArchivedDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionArchivedDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionArchivedDate.Location = new System.Drawing.Point(3, 408);
            this.lblCaptionArchivedDate.Name = "lblCaptionArchivedDate";
            this.lblCaptionArchivedDate.Size = new System.Drawing.Size(191, 38);
            this.lblCaptionArchivedDate.TabIndex = 4;
            this.lblCaptionArchivedDate.Text = "Archived Date";
            // 
            // lblCaptionPublishedDate
            // 
            this.lblCaptionPublishedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPublishedDate.AutoSize = true;
            this.lblCaptionPublishedDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionPublishedDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionPublishedDate.Location = new System.Drawing.Point(3, 351);
            this.lblCaptionPublishedDate.Name = "lblCaptionPublishedDate";
            this.lblCaptionPublishedDate.Size = new System.Drawing.Size(204, 38);
            this.lblCaptionPublishedDate.TabIndex = 3;
            this.lblCaptionPublishedDate.Text = "Published Date";
            // 
            // lblCaptionDraftDate
            // 
            this.lblCaptionDraftDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDraftDate.AutoSize = true;
            this.lblCaptionDraftDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionDraftDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionDraftDate.Location = new System.Drawing.Point(3, 294);
            this.lblCaptionDraftDate.Name = "lblCaptionDraftDate";
            this.lblCaptionDraftDate.Size = new System.Drawing.Size(145, 38);
            this.lblCaptionDraftDate.TabIndex = 2;
            this.lblCaptionDraftDate.Text = "Draft Date";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCalories.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 237);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(115, 38);
            this.lblCaptionCalories.TabIndex = 1;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // txtPicture
            // 
            this.txtPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPicture.Location = new System.Drawing.Point(403, 516);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.ReadOnly = true;
            this.txtPicture.Size = new System.Drawing.Size(394, 45);
            this.txtPicture.TabIndex = 13;
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentStatus.Location = new System.Drawing.Point(403, 459);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.ReadOnly = true;
            this.txtCurrentStatus.Size = new System.Drawing.Size(394, 45);
            this.txtCurrentStatus.TabIndex = 12;
            // 
            // txtArchivedDate
            // 
            this.txtArchivedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivedDate.Location = new System.Drawing.Point(403, 402);
            this.txtArchivedDate.Name = "txtArchivedDate";
            this.txtArchivedDate.ReadOnly = true;
            this.txtArchivedDate.Size = new System.Drawing.Size(394, 45);
            this.txtArchivedDate.TabIndex = 11;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishedDate.Location = new System.Drawing.Point(403, 345);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.ReadOnly = true;
            this.txtPublishedDate.Size = new System.Drawing.Size(394, 45);
            this.txtPublishedDate.TabIndex = 10;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Location = new System.Drawing.Point(403, 288);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.ReadOnly = true;
            this.txtDraftDate.Size = new System.Drawing.Size(394, 45);
            this.txtDraftDate.TabIndex = 9;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(403, 231);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.ReadOnly = true;
            this.txtCalories.Size = new System.Drawing.Size(394, 45);
            this.txtCalories.TabIndex = 8;
            // 
            // txtCuisineType
            // 
            this.txtCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCuisineType.Location = new System.Drawing.Point(403, 174);
            this.txtCuisineType.Name = "txtCuisineType";
            this.txtCuisineType.ReadOnly = true;
            this.txtCuisineType.Size = new System.Drawing.Size(394, 45);
            this.txtCuisineType.TabIndex = 16;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(403, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(394, 45);
            this.txtFirstName.TabIndex = 17;
            // 
            // lblCaptionLastName
            // 
            this.lblCaptionLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionLastName.AutoSize = true;
            this.lblCaptionLastName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionLastName.Location = new System.Drawing.Point(3, 123);
            this.lblCaptionLastName.Name = "lblCaptionLastName";
            this.lblCaptionLastName.Size = new System.Drawing.Size(147, 38);
            this.lblCaptionLastName.TabIndex = 20;
            this.lblCaptionLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(403, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(394, 45);
            this.txtLastName.TabIndex = 21;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionDraftDate;
        private Label lblCaptionPublishedDate;
        private Label lblCaptionArchivedDate;
        private Label lblCaptionCurrentStatus;
        private Label lblCaptionPicture;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtDraftDate;
        private TextBox txtPublishedDate;
        private TextBox txtArchivedDate;
        private TextBox txtCurrentStatus;
        private TextBox txtPicture;
        private Label lblCaptionCuisineType;
        private Label lblCaptionFirstName;
        private TextBox txtCuisineType;
        private TextBox txtFirstName;
        private Label lblCaptionLastName;
        private TextBox txtLastName;
    }
}