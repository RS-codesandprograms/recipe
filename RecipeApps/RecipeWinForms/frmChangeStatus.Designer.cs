namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            tblChangeStatus = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            tblControls = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            lblTitle = new Label();
            lblCurrentStatusText = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblStatusDates = new Label();
            lblDraftDate = new Label();
            lblPublishedDate = new Label();
            lblArchivedDate = new Label();
            tblChangeStatus.SuspendLayout();
            tblControls.SuspendLayout();
            SuspendLayout();
            // 
            // tblChangeStatus
            // 
            tblChangeStatus.ColumnCount = 5;
            tblChangeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblChangeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblChangeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblChangeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblChangeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblChangeStatus.Controls.Add(lblCurrentStatus, 2, 1);
            tblChangeStatus.Controls.Add(tblControls, 0, 4);
            tblChangeStatus.Controls.Add(lblTitle, 0, 0);
            tblChangeStatus.Controls.Add(lblCurrentStatusText, 0, 1);
            tblChangeStatus.Controls.Add(lblDrafted, 1, 2);
            tblChangeStatus.Controls.Add(lblPublished, 2, 2);
            tblChangeStatus.Controls.Add(lblArchived, 3, 2);
            tblChangeStatus.Controls.Add(lblStatusDates, 0, 3);
            tblChangeStatus.Controls.Add(lblDraftDate, 1, 3);
            tblChangeStatus.Controls.Add(lblPublishedDate, 2, 3);
            tblChangeStatus.Controls.Add(lblArchivedDate, 3, 3);
            tblChangeStatus.Dock = DockStyle.Fill;
            tblChangeStatus.Location = new Point(0, 0);
            tblChangeStatus.Name = "tblChangeStatus";
            tblChangeStatus.RowCount = 6;
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6470585F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6470585F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6470585F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblChangeStatus.Size = new Size(674, 321);
            tblChangeStatus.TabIndex = 0;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            tblChangeStatus.SetColumnSpan(lblCurrentStatus, 2);
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(271, 53);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(262, 53);
            lblCurrentStatus.TabIndex = 10;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblControls
            // 
            tblControls.ColumnCount = 10;
            tblChangeStatus.SetColumnSpan(tblControls, 5);
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblControls.Controls.Add(btnDraft, 1, 0);
            tblControls.Controls.Add(btnPublish, 4, 0);
            tblControls.Controls.Add(btnArchive, 7, 0);
            tblControls.Dock = DockStyle.Fill;
            tblControls.Location = new Point(3, 232);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 1;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControls.Size = new Size(668, 64);
            tblControls.TabIndex = 0;
            // 
            // btnDraft
            // 
            btnDraft.BackColor = SystemColors.ButtonShadow;
            tblControls.SetColumnSpan(btnDraft, 2);
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(76, 10);
            btnDraft.Margin = new Padding(10);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(112, 44);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = false;
            // 
            // btnPublish
            // 
            btnPublish.BackColor = SystemColors.ButtonShadow;
            tblControls.SetColumnSpan(btnPublish, 2);
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Location = new Point(274, 10);
            btnPublish.Margin = new Padding(10);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(112, 44);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = SystemColors.ButtonShadow;
            tblControls.SetColumnSpan(btnArchive, 2);
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Location = new Point(472, 10);
            btnArchive.Margin = new Padding(10);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(112, 44);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tblChangeStatus.SetColumnSpan(lblTitle, 5);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(668, 53);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Recipe Name";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatusText
            // 
            lblCurrentStatusText.AutoSize = true;
            tblChangeStatus.SetColumnSpan(lblCurrentStatusText, 2);
            lblCurrentStatusText.Dock = DockStyle.Fill;
            lblCurrentStatusText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatusText.Location = new Point(3, 53);
            lblCurrentStatusText.Name = "lblCurrentStatusText";
            lblCurrentStatusText.Size = new Size(262, 53);
            lblCurrentStatusText.TabIndex = 2;
            lblCurrentStatusText.Text = "Current Status:";
            lblCurrentStatusText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Bottom;
            lblDrafted.Location = new Point(137, 131);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(128, 28);
            lblDrafted.TabIndex = 3;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Bottom;
            lblPublished.Location = new Point(271, 131);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(128, 28);
            lblPublished.TabIndex = 4;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Bottom;
            lblArchived.Location = new Point(405, 131);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(128, 28);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 159);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(128, 70);
            lblStatusDates.TabIndex = 6;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.BackColor = SystemColors.ControlLight;
            lblDraftDate.BorderStyle = BorderStyle.FixedSingle;
            lblDraftDate.Dock = DockStyle.Fill;
            lblDraftDate.Location = new Point(144, 169);
            lblDraftDate.Margin = new Padding(10);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(114, 50);
            lblDraftDate.TabIndex = 7;
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.BackColor = SystemColors.ControlLight;
            lblPublishedDate.BorderStyle = BorderStyle.FixedSingle;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(278, 169);
            lblPublishedDate.Margin = new Padding(10);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(114, 50);
            lblPublishedDate.TabIndex = 8;
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.BackColor = SystemColors.ControlLight;
            lblArchivedDate.BorderStyle = BorderStyle.FixedSingle;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(412, 169);
            lblArchivedDate.Margin = new Padding(10);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(114, 50);
            lblArchivedDate.TabIndex = 9;
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 321);
            Controls.Add(tblChangeStatus);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblChangeStatus.ResumeLayout(false);
            tblChangeStatus.PerformLayout();
            tblControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblChangeStatus;
        private TableLayoutPanel tblControls;
        private Label lblTitle;
        private Label lblCurrentStatusText;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private Label lblDraftDate;
        private Label lblPublishedDate;
        private Label lblArchivedDate;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private Label lblCurrentStatus;
    }
}