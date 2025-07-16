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
            lblCaptionCuisineName = new Label();
            lblCaptionUserName = new Label();
            txtRecipeName = new TextBox();
            lblCurrentStatuslbl = new Label();
            lblCaptionCalories = new Label();
            txtCalories = new TextBox();
            lstCuisineName = new ComboBox();
            lstUserName = new ComboBox();
            lblCaptionRecipeName = new Label();
            lblCurrentStatus = new Label();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblDraftDate = new Label();
            lblPublishedDate = new Label();
            lblArchivedDate = new Label();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            btnChangeStatus = new ToolStripButton();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 2);
            tblMain.Controls.Add(lblCaptionUserName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblCurrentStatuslbl, 0, 4);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStatus, 1, 4);
            tblMain.Controls.Add(lblStatusDates, 0, 5);
            tblMain.Controls.Add(tblStatusDates, 1, 5);
            tblMain.Controls.Add(tbChildRecords, 0, 6);
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 43);
            tblMain.Margin = new Padding(2, 3, 2, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(534, 612);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.BackColor = SystemColors.Control;
            lblCaptionCuisineName.ForeColor = SystemColors.WindowText;
            lblCaptionCuisineName.Location = new Point(0, 89);
            lblCaptionCuisineName.Margin = new Padding(0, 3, 0, 3);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(74, 28);
            lblCaptionCuisineName.TabIndex = 9;
            lblCaptionCuisineName.Text = "Cuisine";
            lblCaptionCuisineName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.BackColor = SystemColors.Control;
            lblCaptionUserName.ForeColor = SystemColors.WindowText;
            lblCaptionUserName.Location = new Point(0, 47);
            lblCaptionUserName.Margin = new Padding(0, 3, 0, 3);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(51, 28);
            lblCaptionUserName.TabIndex = 10;
            lblCaptionUserName.Text = "User";
            lblCaptionUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.White;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(135, 3);
            txtRecipeName.Margin = new Padding(0, 3, 0, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(400, 34);
            txtRecipeName.TabIndex = 0;
            // 
            // lblCurrentStatuslbl
            // 
            lblCurrentStatuslbl.Anchor = AnchorStyles.Left;
            lblCurrentStatuslbl.AutoSize = true;
            lblCurrentStatuslbl.BackColor = SystemColors.Control;
            lblCurrentStatuslbl.ForeColor = SystemColors.WindowText;
            lblCurrentStatuslbl.Location = new Point(0, 168);
            lblCurrentStatuslbl.Margin = new Padding(0, 3, 0, 3);
            lblCurrentStatuslbl.Name = "lblCurrentStatuslbl";
            lblCurrentStatuslbl.Size = new Size(135, 28);
            lblCurrentStatuslbl.TabIndex = 15;
            lblCurrentStatuslbl.Text = "Current Status";
            lblCurrentStatuslbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = SystemColors.Control;
            lblCaptionCalories.ForeColor = SystemColors.WindowText;
            lblCaptionCalories.Location = new Point(0, 130);
            lblCaptionCalories.Margin = new Padding(0, 3, 0, 3);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(129, 28);
            lblCaptionCalories.TabIndex = 16;
            lblCaptionCalories.Text = "Num Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.White;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(135, 127);
            txtCalories.Margin = new Padding(0, 3, 0, 3);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(400, 34);
            txtCalories.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            lstCuisineName.BackColor = Color.White;
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(135, 85);
            lstCuisineName.Margin = new Padding(0, 3, 0, 3);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(400, 36);
            lstCuisineName.TabIndex = 2;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.White;
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(135, 43);
            lstUserName.Margin = new Padding(0, 3, 0, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(400, 36);
            lstUserName.TabIndex = 1;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = SystemColors.Control;
            lblCaptionRecipeName.ForeColor = SystemColors.WindowText;
            lblCaptionRecipeName.Location = new Point(0, 6);
            lblCaptionRecipeName.Margin = new Padding(0, 3, 0, 3);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            lblCaptionRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = SystemColors.ControlDark;
            lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(135, 167);
            lblCurrentStatus.Margin = new Padding(0, 3, 0, 3);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(400, 30);
            lblCurrentStatus.TabIndex = 17;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.ForeColor = SystemColors.WindowText;
            lblStatusDates.Location = new Point(0, 227);
            lblStatusDates.Margin = new Padding(0, 3, 0, 3);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 18;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblPublished, 1, 0);
            tblStatusDates.Controls.Add(lblArchived, 2, 0);
            tblStatusDates.Controls.Add(lblDraftDate, 0, 1);
            tblStatusDates.Controls.Add(lblPublishedDate, 1, 1);
            tblStatusDates.Controls.Add(lblArchivedDate, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(138, 203);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle());
            tblStatusDates.RowStyles.Add(new RowStyle());
            tblStatusDates.Size = new Size(394, 77);
            tblStatusDates.TabIndex = 19;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(0, 0);
            lblDrafted.Margin = new Padding(0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(131, 28);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(131, 0);
            lblPublished.Margin = new Padding(0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(131, 28);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(262, 0);
            lblArchived.Margin = new Padding(0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(132, 28);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.BackColor = SystemColors.ControlDark;
            lblDraftDate.BorderStyle = BorderStyle.FixedSingle;
            lblDraftDate.Dock = DockStyle.Fill;
            lblDraftDate.Location = new Point(0, 31);
            lblDraftDate.Margin = new Padding(0, 3, 0, 3);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(131, 43);
            lblDraftDate.TabIndex = 3;
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.BackColor = SystemColors.ControlDark;
            lblPublishedDate.BorderStyle = BorderStyle.FixedSingle;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(131, 31);
            lblPublishedDate.Margin = new Padding(0, 3, 0, 3);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(131, 43);
            lblPublishedDate.TabIndex = 4;
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.BackColor = SystemColors.ControlDark;
            lblArchivedDate.BorderStyle = BorderStyle.FixedSingle;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(262, 31);
            lblArchivedDate.Margin = new Padding(0, 3, 0, 3);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(132, 43);
            lblArchivedDate.TabIndex = 5;
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 2);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 286);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(529, 338);
            tbChildRecords.TabIndex = 20;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(521, 297);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(515, 291);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(106, 39);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 48);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(509, 240);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 37);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(521, 297);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSteps.Size = new Size(515, 291);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(106, 39);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 48);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(509, 240);
            gSteps.TabIndex = 1;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(28, 28);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, btnChangeStatus });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Padding = new Padding(0, 2, 2, 0);
            tsMain.Size = new Size(534, 40);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Margin = new Padding(0, 3, 0, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Margin = new Padding(0, 3, 0, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "&Delete";
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Alignment = ToolStripItemAlignment.Right;
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Margin = new Padding(0, 3, 0, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(152, 32);
            btnChangeStatus.Text = "Change Status...";
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
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblCaptionCuisineName;
        private Label lblCaptionUserName;
        private Label lblCaptionLastName;
        private TextBox txtLastName;
        private Label lblCurrentStatuslbl;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ComboBox lstCuisineName;
        private ComboBox lstUserName;
        private ToolStripButton btnChangeStatus;
        private Label lblCurrentStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblDraftDate;
        private Label lblPublishedDate;
        private Label lblArchivedDate;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}