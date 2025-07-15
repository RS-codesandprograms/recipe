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
            tblMain = new TableLayoutPanel();
            lblRecipePicture = new Label();
            lblCaptionCuisineName = new Label();
            lblCaptionUserName = new Label();
            txtRecipeName = new TextBox();
            lblCaptionRecipePicture = new Label();
            lblCaptionCurrentStatus = new Label();
            lblCaptionArchivedDate = new Label();
            lblCaptionPublishedDate = new Label();
            lblCaptionDraftDate = new Label();
            lblCaptionCalories = new Label();
            txtArchivedDate = new TextBox();
            txtPublishedDate = new TextBox();
            txtDraftDate = new TextBox();
            txtCalories = new TextBox();
            lblCurrentStatus = new Label();
            lstCuisineName = new ComboBox();
            lstUserName = new ComboBox();
            lblCaptionRecipeName = new Label();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblRecipePicture, 1, 8);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 2);
            tblMain.Controls.Add(lblCaptionUserName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblCaptionRecipePicture, 0, 8);
            tblMain.Controls.Add(lblCaptionCurrentStatus, 0, 7);
            tblMain.Controls.Add(lblCaptionArchivedDate, 0, 6);
            tblMain.Controls.Add(lblCaptionPublishedDate, 0, 5);
            tblMain.Controls.Add(lblCaptionDraftDate, 0, 4);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(txtArchivedDate, 1, 6);
            tblMain.Controls.Add(txtPublishedDate, 1, 5);
            tblMain.Controls.Add(txtDraftDate, 1, 4);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblCurrentStatus, 1, 7);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 69);
            tblMain.Margin = new Padding(2, 3, 2, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblMain.Size = new Size(534, 585);
            tblMain.TabIndex = 0;
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.AutoSize = true;
            lblRecipePicture.BackColor = Color.White;
            lblRecipePicture.BorderStyle = BorderStyle.Fixed3D;
            lblRecipePicture.Dock = DockStyle.Fill;
            lblRecipePicture.Location = new Point(270, 492);
            lblRecipePicture.Margin = new Padding(3, 4, 3, 4);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(261, 53);
            lblRecipePicture.TabIndex = 8;
            lblRecipePicture.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.BackColor = SystemColors.Control;
            lblCaptionCuisineName.ForeColor = SystemColors.WindowText;
            lblCaptionCuisineName.Location = new Point(2, 138);
            lblCaptionCuisineName.Margin = new Padding(2, 0, 2, 0);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(131, 28);
            lblCaptionCuisineName.TabIndex = 9;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.BackColor = SystemColors.Control;
            lblCaptionUserName.ForeColor = SystemColors.WindowText;
            lblCaptionUserName.Location = new Point(2, 77);
            lblCaptionUserName.Margin = new Padding(2, 0, 2, 0);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(108, 28);
            lblCaptionUserName.TabIndex = 10;
            lblCaptionUserName.Text = "User Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.White;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(269, 3);
            txtRecipeName.Margin = new Padding(2, 3, 2, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(263, 34);
            txtRecipeName.TabIndex = 0;
            // 
            // lblCaptionRecipePicture
            // 
            lblCaptionRecipePicture.Anchor = AnchorStyles.Left;
            lblCaptionRecipePicture.AutoSize = true;
            lblCaptionRecipePicture.BackColor = SystemColors.Control;
            lblCaptionRecipePicture.ForeColor = SystemColors.WindowText;
            lblCaptionRecipePicture.Location = new Point(2, 504);
            lblCaptionRecipePicture.Margin = new Padding(2, 0, 2, 0);
            lblCaptionRecipePicture.Name = "lblCaptionRecipePicture";
            lblCaptionRecipePicture.Size = new Size(72, 28);
            lblCaptionRecipePicture.TabIndex = 11;
            lblCaptionRecipePicture.Text = "Picture";
            // 
            // lblCaptionCurrentStatus
            // 
            lblCaptionCurrentStatus.Anchor = AnchorStyles.Left;
            lblCaptionCurrentStatus.AutoSize = true;
            lblCaptionCurrentStatus.BackColor = SystemColors.Control;
            lblCaptionCurrentStatus.ForeColor = SystemColors.WindowText;
            lblCaptionCurrentStatus.Location = new Point(2, 443);
            lblCaptionCurrentStatus.Margin = new Padding(2, 0, 2, 0);
            lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            lblCaptionCurrentStatus.Size = new Size(135, 28);
            lblCaptionCurrentStatus.TabIndex = 12;
            lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // lblCaptionArchivedDate
            // 
            lblCaptionArchivedDate.Anchor = AnchorStyles.Left;
            lblCaptionArchivedDate.AutoSize = true;
            lblCaptionArchivedDate.BackColor = SystemColors.Control;
            lblCaptionArchivedDate.ForeColor = SystemColors.WindowText;
            lblCaptionArchivedDate.Location = new Point(2, 382);
            lblCaptionArchivedDate.Margin = new Padding(2, 0, 2, 0);
            lblCaptionArchivedDate.Name = "lblCaptionArchivedDate";
            lblCaptionArchivedDate.Size = new Size(135, 28);
            lblCaptionArchivedDate.TabIndex = 13;
            lblCaptionArchivedDate.Text = "Archived Date";
            // 
            // lblCaptionPublishedDate
            // 
            lblCaptionPublishedDate.Anchor = AnchorStyles.Left;
            lblCaptionPublishedDate.AutoSize = true;
            lblCaptionPublishedDate.BackColor = SystemColors.Control;
            lblCaptionPublishedDate.ForeColor = SystemColors.WindowText;
            lblCaptionPublishedDate.Location = new Point(2, 321);
            lblCaptionPublishedDate.Margin = new Padding(2, 0, 2, 0);
            lblCaptionPublishedDate.Name = "lblCaptionPublishedDate";
            lblCaptionPublishedDate.Size = new Size(143, 28);
            lblCaptionPublishedDate.TabIndex = 14;
            lblCaptionPublishedDate.Text = "Published Date";
            // 
            // lblCaptionDraftDate
            // 
            lblCaptionDraftDate.Anchor = AnchorStyles.Left;
            lblCaptionDraftDate.AutoSize = true;
            lblCaptionDraftDate.BackColor = SystemColors.Control;
            lblCaptionDraftDate.ForeColor = SystemColors.WindowText;
            lblCaptionDraftDate.Location = new Point(2, 260);
            lblCaptionDraftDate.Margin = new Padding(2, 0, 2, 0);
            lblCaptionDraftDate.Name = "lblCaptionDraftDate";
            lblCaptionDraftDate.Size = new Size(102, 28);
            lblCaptionDraftDate.TabIndex = 15;
            lblCaptionDraftDate.Text = "Draft Date";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = SystemColors.Control;
            lblCaptionCalories.ForeColor = SystemColors.WindowText;
            lblCaptionCalories.Location = new Point(2, 199);
            lblCaptionCalories.Margin = new Padding(2, 0, 2, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 16;
            lblCaptionCalories.Text = "Calories";
            // 
            // txtArchivedDate
            // 
            txtArchivedDate.BackColor = Color.White;
            txtArchivedDate.Dock = DockStyle.Fill;
            txtArchivedDate.Location = new Point(269, 369);
            txtArchivedDate.Margin = new Padding(2, 3, 2, 3);
            txtArchivedDate.Name = "txtArchivedDate";
            txtArchivedDate.Size = new Size(263, 34);
            txtArchivedDate.TabIndex = 6;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.BackColor = Color.White;
            txtPublishedDate.Dock = DockStyle.Fill;
            txtPublishedDate.Location = new Point(269, 308);
            txtPublishedDate.Margin = new Padding(2, 3, 2, 3);
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(263, 34);
            txtPublishedDate.TabIndex = 5;
            // 
            // txtDraftDate
            // 
            txtDraftDate.BackColor = Color.White;
            txtDraftDate.Dock = DockStyle.Fill;
            txtDraftDate.Location = new Point(269, 247);
            txtDraftDate.Margin = new Padding(2, 3, 2, 3);
            txtDraftDate.Name = "txtDraftDate";
            txtDraftDate.ReadOnly = true;
            txtDraftDate.Size = new Size(263, 34);
            txtDraftDate.TabIndex = 4;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.White;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(269, 186);
            txtCalories.Margin = new Padding(2, 3, 2, 3);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(263, 34);
            txtCalories.TabIndex = 3;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = Color.White;
            lblCurrentStatus.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(270, 431);
            lblCurrentStatus.Margin = new Padding(3, 4, 3, 4);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(261, 53);
            lblCurrentStatus.TabIndex = 7;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstCuisineName
            // 
            lstCuisineName.BackColor = Color.White;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(270, 126);
            lstCuisineName.Margin = new Padding(3, 4, 3, 4);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(138, 36);
            lstCuisineName.TabIndex = 2;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.White;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(269, 64);
            lstUserName.Margin = new Padding(2, 3, 2, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(142, 36);
            lstUserName.TabIndex = 1;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = SystemColors.Control;
            lblCaptionRecipeName.ForeColor = SystemColors.WindowText;
            lblCaptionRecipeName.Location = new Point(2, 16);
            lblCaptionRecipeName.Margin = new Padding(2, 0, 2, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(28, 28);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Padding = new Padding(0, 0, 2, 0);
            tsMain.Size = new Size(534, 35);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(534, 655);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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