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
            lblCurrentStatusText = new Label();
            lblCurrentStatus = new Label();
            btnDraft = new Button();
            btnArchive = new Button();
            btnPublish = new Button();
            lblTitle = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblStatusDates = new Label();
            lblDraftDate = new Label();
            lblPublishedDate = new Label();
            lblArchivedDate = new Label();
            tblChangeStatus.SuspendLayout();
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
            tblChangeStatus.Controls.Add(lblCurrentStatusText, 0, 2);
            tblChangeStatus.Controls.Add(lblCurrentStatus, 0, 3);
            tblChangeStatus.Controls.Add(btnDraft, 1, 5);
            tblChangeStatus.Controls.Add(btnArchive, 3, 5);
            tblChangeStatus.Controls.Add(btnPublish, 2, 5);
            tblChangeStatus.Controls.Add(lblTitle, 0, 1);
            tblChangeStatus.Controls.Add(lblDrafted, 1, 3);
            tblChangeStatus.Controls.Add(lblPublished, 2, 3);
            tblChangeStatus.Controls.Add(lblArchived, 3, 3);
            tblChangeStatus.Controls.Add(lblStatusDates, 0, 4);
            tblChangeStatus.Controls.Add(lblDraftDate, 1, 4);
            tblChangeStatus.Controls.Add(lblPublishedDate, 2, 4);
            tblChangeStatus.Controls.Add(lblArchivedDate, 3, 4);
            tblChangeStatus.Dock = DockStyle.Fill;
            tblChangeStatus.Location = new Point(0, 0);
            tblChangeStatus.Name = "tblChangeStatus";
            tblChangeStatus.RowCount = 7;
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999943F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblChangeStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tblChangeStatus.Size = new Size(734, 367);
            tblChangeStatus.TabIndex = 0;
            // 
            // lblCurrentStatusText
            // 
            lblCurrentStatusText.AutoSize = true;
            tblChangeStatus.SetColumnSpan(lblCurrentStatusText, 6);
            lblCurrentStatusText.Dock = DockStyle.Fill;
            lblCurrentStatusText.Font = new Font("Segoe UI", 18F);
            lblCurrentStatusText.Location = new Point(3, 133);
            lblCurrentStatusText.Name = "lblCurrentStatusText";
            lblCurrentStatusText.Size = new Size(728, 33);
            lblCurrentStatusText.TabIndex = 12;
            lblCurrentStatusText.Text = "Current Status:";
            lblCurrentStatusText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Segoe UI", 16F);
            lblCurrentStatus.ForeColor = SystemColors.Control;
            lblCurrentStatus.Location = new Point(3, 166);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(140, 33);
            lblCurrentStatus.TabIndex = 11;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDraft
            // 
            btnDraft.BackColor = SystemColors.ButtonShadow;
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(156, 242);
            btnDraft.Margin = new Padding(10);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(126, 13);
            btnDraft.TabIndex = 14;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = SystemColors.ButtonShadow;
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Location = new Point(448, 242);
            btnArchive.Margin = new Padding(10);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(126, 13);
            btnArchive.TabIndex = 13;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // btnPublish
            // 
            btnPublish.BackColor = SystemColors.ButtonShadow;
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Location = new Point(302, 242);
            btnPublish.Margin = new Padding(10);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(126, 13);
            btnPublish.TabIndex = 12;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tblChangeStatus.SetColumnSpan(lblTitle, 5);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(728, 33);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Recipe Name";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Bottom;
            lblDrafted.Location = new Point(149, 171);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(140, 28);
            lblDrafted.TabIndex = 3;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Bottom;
            lblPublished.Location = new Point(295, 171);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(140, 28);
            lblPublished.TabIndex = 4;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Bottom;
            lblArchived.Location = new Point(441, 171);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(140, 28);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 199);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(140, 33);
            lblStatusDates.TabIndex = 6;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.BackColor = SystemColors.ControlLight;
            lblDraftDate.BorderStyle = BorderStyle.FixedSingle;
            lblDraftDate.Dock = DockStyle.Fill;
            lblDraftDate.Location = new Point(156, 209);
            lblDraftDate.Margin = new Padding(10);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(126, 13);
            lblDraftDate.TabIndex = 7;
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.BackColor = SystemColors.ControlLight;
            lblPublishedDate.BorderStyle = BorderStyle.FixedSingle;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(302, 209);
            lblPublishedDate.Margin = new Padding(10);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(126, 13);
            lblPublishedDate.TabIndex = 8;
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.BackColor = SystemColors.ControlLight;
            lblArchivedDate.BorderStyle = BorderStyle.FixedSingle;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(448, 209);
            lblArchivedDate.Margin = new Padding(10);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(126, 13);
            lblArchivedDate.TabIndex = 9;
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 367);
            Controls.Add(tblChangeStatus);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblChangeStatus.ResumeLayout(false);
            tblChangeStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblChangeStatus;
        private Label lblTitle;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private Label lblDraftDate;
        private Label lblPublishedDate;
        private Label lblArchivedDate;
        private Label lblCurrentStatus;
        private Label lblCurrentStatusText;
        private Button btnArchive;
        private Button btnPublish;
        private Button btnDraft;
    }
}