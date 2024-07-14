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
            this.lblRecipePicture = new System.Windows.Forms.Label();
            this.lblCaptionCuisineName = new System.Windows.Forms.Label();
            this.lblCaptionUserName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionRecipePicture = new System.Windows.Forms.Label();
            this.lblCaptionCurrentStatus = new System.Windows.Forms.Label();
            this.lblCaptionArchivedDate = new System.Windows.Forms.Label();
            this.lblCaptionPublishedDate = new System.Windows.Forms.Label();
            this.lblCaptionDraftDate = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.txtArchivedDate = new System.Windows.Forms.TextBox();
            this.txtPublishedDate = new System.Windows.Forms.TextBox();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lstCuisineName = new System.Windows.Forms.ComboBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblRecipePicture, 1, 8);
            this.tblMain.Controls.Add(this.lblCaptionCuisineName, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionUserName, 0, 1);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lblCaptionRecipePicture, 0, 8);
            this.tblMain.Controls.Add(this.lblCaptionCurrentStatus, 0, 7);
            this.tblMain.Controls.Add(this.lblCaptionArchivedDate, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionPublishedDate, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDraftDate, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.txtArchivedDate, 1, 6);
            this.tblMain.Controls.Add(this.txtPublishedDate, 1, 5);
            this.tblMain.Controls.Add(this.txtDraftDate, 1, 4);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.lblCurrentStatus, 1, 7);
            this.tblMain.Controls.Add(this.lstCuisineName, 1, 2);
            this.tblMain.Controls.Add(this.lstUserName, 1, 1);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 0);
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 52);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 9;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Size = new System.Drawing.Size(467, 289);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipePicture
            // 
            this.lblRecipePicture.AutoSize = true;
            this.lblRecipePicture.BackColor = System.Drawing.SystemColors.Window;
            this.lblRecipePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecipePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipePicture.Location = new System.Drawing.Point(236, 256);
            this.lblRecipePicture.Name = "lblRecipePicture";
            this.lblRecipePicture.Size = new System.Drawing.Size(228, 33);
            this.lblRecipePicture.TabIndex = 8;
            this.lblRecipePicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCuisineName
            // 
            this.lblCaptionCuisineName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisineName.AutoSize = true;
            this.lblCaptionCuisineName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCuisineName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCuisineName.Location = new System.Drawing.Point(2, 69);
            this.lblCaptionCuisineName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            this.lblCaptionCuisineName.Size = new System.Drawing.Size(107, 21);
            this.lblCaptionCuisineName.TabIndex = 9;
            this.lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionUserName
            // 
            this.lblCaptionUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionUserName.AutoSize = true;
            this.lblCaptionUserName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionUserName.Location = new System.Drawing.Point(2, 37);
            this.lblCaptionUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionUserName.Name = "lblCaptionUserName";
            this.lblCaptionUserName.Size = new System.Drawing.Size(88, 21);
            this.lblCaptionUserName.TabIndex = 10;
            this.lblCaptionUserName.Text = "User Name";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(235, 2);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(230, 29);
            this.txtRecipeName.TabIndex = 0;
            // 
            // lblCaptionRecipePicture
            // 
            this.lblCaptionRecipePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipePicture.AutoSize = true;
            this.lblCaptionRecipePicture.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionRecipePicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionRecipePicture.Location = new System.Drawing.Point(2, 262);
            this.lblCaptionRecipePicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionRecipePicture.Name = "lblCaptionRecipePicture";
            this.lblCaptionRecipePicture.Size = new System.Drawing.Size(58, 21);
            this.lblCaptionRecipePicture.TabIndex = 11;
            this.lblCaptionRecipePicture.Text = "Picture";
            // 
            // lblCaptionCurrentStatus
            // 
            this.lblCaptionCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCurrentStatus.AutoSize = true;
            this.lblCaptionCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCurrentStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCurrentStatus.Location = new System.Drawing.Point(2, 229);
            this.lblCaptionCurrentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            this.lblCaptionCurrentStatus.Size = new System.Drawing.Size(109, 21);
            this.lblCaptionCurrentStatus.TabIndex = 12;
            this.lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // lblCaptionArchivedDate
            // 
            this.lblCaptionArchivedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionArchivedDate.AutoSize = true;
            this.lblCaptionArchivedDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionArchivedDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionArchivedDate.Location = new System.Drawing.Point(2, 197);
            this.lblCaptionArchivedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionArchivedDate.Name = "lblCaptionArchivedDate";
            this.lblCaptionArchivedDate.Size = new System.Drawing.Size(107, 21);
            this.lblCaptionArchivedDate.TabIndex = 13;
            this.lblCaptionArchivedDate.Text = "Archived Date";
            // 
            // lblCaptionPublishedDate
            // 
            this.lblCaptionPublishedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPublishedDate.AutoSize = true;
            this.lblCaptionPublishedDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionPublishedDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionPublishedDate.Location = new System.Drawing.Point(2, 165);
            this.lblCaptionPublishedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionPublishedDate.Name = "lblCaptionPublishedDate";
            this.lblCaptionPublishedDate.Size = new System.Drawing.Size(114, 21);
            this.lblCaptionPublishedDate.TabIndex = 14;
            this.lblCaptionPublishedDate.Text = "Published Date";
            // 
            // lblCaptionDraftDate
            // 
            this.lblCaptionDraftDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDraftDate.AutoSize = true;
            this.lblCaptionDraftDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionDraftDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionDraftDate.Location = new System.Drawing.Point(2, 133);
            this.lblCaptionDraftDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionDraftDate.Name = "lblCaptionDraftDate";
            this.lblCaptionDraftDate.Size = new System.Drawing.Size(81, 21);
            this.lblCaptionDraftDate.TabIndex = 15;
            this.lblCaptionDraftDate.Text = "Draft Date";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCalories.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCalories.Location = new System.Drawing.Point(2, 101);
            this.lblCaptionCalories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(66, 21);
            this.lblCaptionCalories.TabIndex = 16;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // txtArchivedDate
            // 
            this.txtArchivedDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtArchivedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivedDate.Location = new System.Drawing.Point(235, 194);
            this.txtArchivedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArchivedDate.Name = "txtArchivedDate";
            this.txtArchivedDate.Size = new System.Drawing.Size(230, 29);
            this.txtArchivedDate.TabIndex = 6;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublishedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishedDate.Location = new System.Drawing.Point(235, 162);
            this.txtPublishedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.Size = new System.Drawing.Size(230, 29);
            this.txtPublishedDate.TabIndex = 5;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Location = new System.Drawing.Point(235, 130);
            this.txtDraftDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.Size = new System.Drawing.Size(230, 29);
            this.txtDraftDate.TabIndex = 4;
            // 
            // txtCalories
            // 
            this.txtCalories.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(235, 98);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(230, 29);
            this.txtCalories.TabIndex = 3;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatus.Location = new System.Drawing.Point(236, 224);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(228, 32);
            this.lblCurrentStatus.TabIndex = 7;
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstCuisineName
            // 
            this.lstCuisineName.FormattingEnabled = true;
            this.lstCuisineName.Location = new System.Drawing.Point(236, 67);
            this.lstCuisineName.Name = "lstCuisineName";
            this.lstCuisineName.Size = new System.Drawing.Size(121, 29);
            this.lstCuisineName.TabIndex = 2;
            // 
            // lstUserName
            // 
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(235, 34);
            this.lstUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(125, 29);
            this.lstUserName.TabIndex = 1;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionRecipeName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(2, 5);
            this.lblCaptionRecipeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(102, 21);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsMain.Size = new System.Drawing.Size(467, 28);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 25);
            this.btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 25);
            this.btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(467, 491);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionDraftDate;
        private Label lblCaptionPublishedDate;
        private Label lblCaptionArchivedDate;
        private Label lblCaptionCurrentStatus;
        private Label lblCaptionRecipePicture;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtDraftDate;
        private TextBox txtPublishedDate;
        private TextBox txtArchivedDate;
        private Label lblCaptionCuisineName;
        private Label lblCaptionUserName;
        private Label lblCaptionLastName;
        private TextBox txtLastName;
        private Label lblCurrentStatus;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstCuisineName;
        private ComboBox lstUserName;
        private Label lblRecipePicture;
    }
}