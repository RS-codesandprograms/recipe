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
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            tblMain.Font = new Font("Segoe UI", 12F);
            tblMain.Location = new Point(0, 32);
            tblMain.Margin = new Padding(2);
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
            tblMain.Size = new Size(467, 459);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.BackColor = SystemColors.Control;
            lblCaptionCuisineName.ForeColor = SystemColors.WindowText;
            lblCaptionCuisineName.Location = new Point(0, 72);
            lblCaptionCuisineName.Margin = new Padding(0, 2, 0, 2);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(61, 21);
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
            lblCaptionUserName.Location = new Point(0, 39);
            lblCaptionUserName.Margin = new Padding(0, 2, 0, 2);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(42, 21);
            lblCaptionUserName.TabIndex = 10;
            lblCaptionUserName.Text = "User";
            lblCaptionUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.White;
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(109, 2);
            txtRecipeName.Margin = new Padding(0, 2, 0, 2);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(374, 29);
            txtRecipeName.TabIndex = 0;
            // 
            // lblCurrentStatuslbl
            // 
            lblCurrentStatuslbl.Anchor = AnchorStyles.Left;
            lblCurrentStatuslbl.AutoSize = true;
            lblCurrentStatuslbl.BackColor = SystemColors.Control;
            lblCurrentStatuslbl.ForeColor = SystemColors.WindowText;
            lblCurrentStatuslbl.Location = new Point(0, 135);
            lblCurrentStatuslbl.Margin = new Padding(0, 2, 0, 2);
            lblCurrentStatuslbl.Name = "lblCurrentStatuslbl";
            lblCurrentStatuslbl.Size = new Size(109, 21);
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
            lblCaptionCalories.Location = new Point(0, 105);
            lblCaptionCalories.Margin = new Padding(0, 2, 0, 2);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(105, 21);
            lblCaptionCalories.TabIndex = 16;
            lblCaptionCalories.Text = "Num Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.White;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(109, 101);
            txtCalories.Margin = new Padding(0, 2, 0, 2);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(374, 29);
            txtCalories.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            lstCuisineName.BackColor = Color.White;
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(109, 68);
            lstCuisineName.Margin = new Padding(0, 2, 0, 2);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(374, 29);
            lstCuisineName.TabIndex = 2;
            // 
            // lstUserName
            // 
            lstUserName.BackColor = Color.White;
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(109, 35);
            lstUserName.Margin = new Padding(0, 2, 0, 2);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(374, 29);
            lstUserName.TabIndex = 1;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.BackColor = SystemColors.Control;
            lblCaptionRecipeName.ForeColor = SystemColors.WindowText;
            lblCaptionRecipeName.Location = new Point(0, 6);
            lblCaptionRecipeName.Margin = new Padding(0, 2, 0, 2);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(102, 21);
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
            lblCurrentStatus.Location = new Point(109, 134);
            lblCurrentStatus.Margin = new Padding(0, 2, 0, 2);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(374, 23);
            lblCurrentStatus.TabIndex = 17;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.ForeColor = SystemColors.WindowText;
            lblStatusDates.Location = new Point(0, 179);
            lblStatusDates.Margin = new Padding(0, 2, 0, 2);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(95, 21);
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
            tblStatusDates.Location = new Point(112, 161);
            tblStatusDates.Margin = new Padding(3, 2, 3, 2);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle());
            tblStatusDates.RowStyles.Add(new RowStyle());
            tblStatusDates.Size = new Size(368, 58);
            tblStatusDates.TabIndex = 19;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(0, 0);
            lblDrafted.Margin = new Padding(0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(122, 21);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(122, 0);
            lblPublished.Margin = new Padding(0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(122, 21);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(244, 0);
            lblArchived.Margin = new Padding(0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(124, 21);
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
            lblDraftDate.Location = new Point(0, 23);
            lblDraftDate.Margin = new Padding(0, 2, 0, 2);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(122, 33);
            lblDraftDate.TabIndex = 3;
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.BackColor = SystemColors.ControlDark;
            lblPublishedDate.BorderStyle = BorderStyle.FixedSingle;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(122, 23);
            lblPublishedDate.Margin = new Padding(0, 2, 0, 2);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(122, 33);
            lblPublishedDate.TabIndex = 4;
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.BackColor = SystemColors.ControlDark;
            lblArchivedDate.BorderStyle = BorderStyle.FixedSingle;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(244, 23);
            lblArchivedDate.Margin = new Padding(0, 2, 0, 2);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(124, 33);
            lblArchivedDate.TabIndex = 5;
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 2);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 223);
            tbChildRecords.Margin = new Padding(3, 2, 3, 2);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(477, 254);
            tbChildRecords.TabIndex = 5;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 30);
            tbIngredients.Margin = new Padding(3, 2, 3, 2);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3, 2, 3, 2);
            tbIngredients.Size = new Size(469, 220);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 2);
            tblIngredients.Margin = new Padding(3, 2, 3, 2);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(463, 216);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Location = new Point(3, 2);
            btnSaveIngredients.Margin = new Padding(3, 2, 3, 2);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(93, 29);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 35);
            gIngredients.Margin = new Padding(3, 2, 3, 2);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(457, 179);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 30);
            tbSteps.Margin = new Padding(3, 2, 3, 2);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3, 2, 3, 2);
            tbSteps.Size = new Size(469, 220);
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
            tblSteps.Location = new Point(3, 2);
            tblSteps.Margin = new Padding(3, 2, 3, 2);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSteps.Size = new Size(463, 216);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Location = new Point(3, 2);
            btnSaveSteps.Margin = new Padding(3, 2, 3, 2);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(93, 29);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 35);
            gSteps.Margin = new Padding(3, 2, 3, 2);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(457, 179);
            gSteps.TabIndex = 1;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F);
            tsMain.ImageScalingSize = new Size(28, 28);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, btnChangeStatus });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Padding = new Padding(0, 2, 2, 0);
            tsMain.Size = new Size(467, 33);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Margin = new Padding(0, 3, 0, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Margin = new Padding(0, 3, 0, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "&Delete";
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Alignment = ToolStripItemAlignment.Right;
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Margin = new Padding(0, 3, 0, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(122, 25);
            btnChangeStatus.Text = "Change Status...";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(467, 491);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Margin = new Padding(2);
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