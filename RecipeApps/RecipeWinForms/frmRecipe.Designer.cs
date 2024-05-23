﻿namespace RecipeWinForms
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
            this.lblCaptionCuisineName = new System.Windows.Forms.Label();
            this.lblCaptionUserName = new System.Windows.Forms.Label();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionRecipePicture = new System.Windows.Forms.Label();
            this.lblCaptionCurrentStatus = new System.Windows.Forms.Label();
            this.lblCaptionArchivedDate = new System.Windows.Forms.Label();
            this.lblCaptionPublishedDate = new System.Windows.Forms.Label();
            this.lblCaptionDraftDate = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.txtRecipePicture = new System.Windows.Forms.TextBox();
            this.txtArchivedDate = new System.Windows.Forms.TextBox();
            this.txtPublishedDate = new System.Windows.Forms.TextBox();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lstCuisineName = new System.Windows.Forms.ComboBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
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
            this.tblMain.Controls.Add(this.lblCaptionCuisineName, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionUserName, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lblCaptionRecipePicture, 0, 8);
            this.tblMain.Controls.Add(this.lblCaptionCurrentStatus, 0, 7);
            this.tblMain.Controls.Add(this.lblCaptionArchivedDate, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionPublishedDate, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDraftDate, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.txtRecipePicture, 1, 8);
            this.tblMain.Controls.Add(this.txtArchivedDate, 1, 6);
            this.tblMain.Controls.Add(this.txtPublishedDate, 1, 5);
            this.tblMain.Controls.Add(this.txtDraftDate, 1, 4);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.lblCurrentStatus, 1, 7);
            this.tblMain.Controls.Add(this.lstCuisineName, 1, 2);
            this.tblMain.Controls.Add(this.lstUserName, 1, 1);
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 104);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(801, 578);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionCuisineName
            // 
            this.lblCaptionCuisineName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisineName.AutoSize = true;
            this.lblCaptionCuisineName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCuisineName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCuisineName.Location = new System.Drawing.Point(3, 141);
            this.lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            this.lblCaptionCuisineName.Size = new System.Drawing.Size(189, 38);
            this.lblCaptionCuisineName.TabIndex = 19;
            this.lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionUserName
            // 
            this.lblCaptionUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionUserName.AutoSize = true;
            this.lblCaptionUserName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionUserName.Location = new System.Drawing.Point(3, 77);
            this.lblCaptionUserName.Name = "lblCaptionUserName";
            this.lblCaptionUserName.Size = new System.Drawing.Size(155, 38);
            this.lblCaptionUserName.TabIndex = 18;
            this.lblCaptionUserName.Text = "User Name";
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionRecipeName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 13);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(181, 38);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(403, 4);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(395, 45);
            this.txtRecipeName.TabIndex = 7;
            // 
            // lblCaptionRecipePicture
            // 
            this.lblCaptionRecipePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipePicture.AutoSize = true;
            this.lblCaptionRecipePicture.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionRecipePicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionRecipePicture.Location = new System.Drawing.Point(3, 526);
            this.lblCaptionRecipePicture.Name = "lblCaptionRecipePicture";
            this.lblCaptionRecipePicture.Size = new System.Drawing.Size(103, 38);
            this.lblCaptionRecipePicture.TabIndex = 6;
            this.lblCaptionRecipePicture.Text = "Picture";
            // 
            // lblCaptionCurrentStatus
            // 
            this.lblCaptionCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCurrentStatus.AutoSize = true;
            this.lblCaptionCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCurrentStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCurrentStatus.Location = new System.Drawing.Point(3, 461);
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
            this.lblCaptionArchivedDate.Location = new System.Drawing.Point(3, 397);
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
            this.lblCaptionPublishedDate.Location = new System.Drawing.Point(3, 333);
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
            this.lblCaptionDraftDate.Location = new System.Drawing.Point(3, 269);
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
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 205);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(115, 38);
            this.lblCaptionCalories.TabIndex = 1;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // txtRecipePicture
            // 
            this.txtRecipePicture.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecipePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipePicture.Location = new System.Drawing.Point(403, 516);
            this.txtRecipePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecipePicture.Name = "txtRecipePicture";
            this.txtRecipePicture.ReadOnly = true;
            this.txtRecipePicture.Size = new System.Drawing.Size(395, 45);
            this.txtRecipePicture.TabIndex = 13;
            // 
            // txtArchivedDate
            // 
            this.txtArchivedDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtArchivedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivedDate.Location = new System.Drawing.Point(403, 388);
            this.txtArchivedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArchivedDate.Name = "txtArchivedDate";
            this.txtArchivedDate.Size = new System.Drawing.Size(395, 45);
            this.txtArchivedDate.TabIndex = 11;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublishedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishedDate.Location = new System.Drawing.Point(403, 324);
            this.txtPublishedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.Size = new System.Drawing.Size(395, 45);
            this.txtPublishedDate.TabIndex = 10;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Location = new System.Drawing.Point(403, 260);
            this.txtDraftDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.Size = new System.Drawing.Size(395, 45);
            this.txtDraftDate.TabIndex = 9;
            // 
            // txtCalories
            // 
            this.txtCalories.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(403, 196);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(395, 45);
            this.txtCalories.TabIndex = 8;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatus.Location = new System.Drawing.Point(405, 448);
            this.lblCurrentStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(391, 64);
            this.lblCurrentStatus.TabIndex = 22;
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstCuisineName
            // 
            this.lstCuisineName.FormattingEnabled = true;
            this.lstCuisineName.Location = new System.Drawing.Point(405, 134);
            this.lstCuisineName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstCuisineName.Name = "lstCuisineName";
            this.lstCuisineName.Size = new System.Drawing.Size(205, 46);
            this.lstCuisineName.TabIndex = 23;
            // 
            // lstUserName
            // 
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(403, 67);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(212, 46);
            this.lstUserName.TabIndex = 24;
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
            this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMain.Size = new System.Drawing.Size(801, 48);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 42);
            this.btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 42);
            this.btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 988);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private TextBox txtRecipePicture;
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
    }
}