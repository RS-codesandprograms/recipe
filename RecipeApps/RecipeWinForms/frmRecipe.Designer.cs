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
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionDraftDate = new System.Windows.Forms.Label();
            this.lblCaptionPublishedDate = new System.Windows.Forms.Label();
            this.lblCaptionArchivedDate = new System.Windows.Forms.Label();
            this.lblCaptionCurrentStatus = new System.Windows.Forms.Label();
            this.lblCaptionPicture = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtPublishedDate = new System.Windows.Forms.TextBox();
            this.txtArchivedDate = new System.Windows.Forms.TextBox();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionDraftDate, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionPublishedDate, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionArchivedDate, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionCurrentStatus, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionPicture, 0, 6);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Controls.Add(this.txtDraftDate, 1, 2);
            this.tblMain.Controls.Add(this.txtPublishedDate, 1, 3);
            this.tblMain.Controls.Add(this.txtArchivedDate, 1, 4);
            this.tblMain.Controls.Add(this.txtCurrentStatus, 1, 5);
            this.tblMain.Controls.Add(this.txtPicture, 1, 6);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.Size = new System.Drawing.Size(800, 578);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionRecipeName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 22);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(181, 38);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCalories.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 104);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(115, 38);
            this.lblCaptionCalories.TabIndex = 1;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDraftDate
            // 
            this.lblCaptionDraftDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDraftDate.AutoSize = true;
            this.lblCaptionDraftDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionDraftDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionDraftDate.Location = new System.Drawing.Point(3, 186);
            this.lblCaptionDraftDate.Name = "lblCaptionDraftDate";
            this.lblCaptionDraftDate.Size = new System.Drawing.Size(145, 38);
            this.lblCaptionDraftDate.TabIndex = 2;
            this.lblCaptionDraftDate.Text = "Draft Date";
            // 
            // lblCaptionPublishedDate
            // 
            this.lblCaptionPublishedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPublishedDate.AutoSize = true;
            this.lblCaptionPublishedDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionPublishedDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionPublishedDate.Location = new System.Drawing.Point(3, 268);
            this.lblCaptionPublishedDate.Name = "lblCaptionPublishedDate";
            this.lblCaptionPublishedDate.Size = new System.Drawing.Size(204, 38);
            this.lblCaptionPublishedDate.TabIndex = 3;
            this.lblCaptionPublishedDate.Text = "Published Date";
            // 
            // lblCaptionArchivedDate
            // 
            this.lblCaptionArchivedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionArchivedDate.AutoSize = true;
            this.lblCaptionArchivedDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionArchivedDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionArchivedDate.Location = new System.Drawing.Point(3, 350);
            this.lblCaptionArchivedDate.Name = "lblCaptionArchivedDate";
            this.lblCaptionArchivedDate.Size = new System.Drawing.Size(191, 38);
            this.lblCaptionArchivedDate.TabIndex = 4;
            this.lblCaptionArchivedDate.Text = "Archived Date";
            // 
            // lblCaptionCurrentStatus
            // 
            this.lblCaptionCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCurrentStatus.AutoSize = true;
            this.lblCaptionCurrentStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionCurrentStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionCurrentStatus.Location = new System.Drawing.Point(3, 432);
            this.lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            this.lblCaptionCurrentStatus.Size = new System.Drawing.Size(192, 38);
            this.lblCaptionCurrentStatus.TabIndex = 5;
            this.lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // lblCaptionPicture
            // 
            this.lblCaptionPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPicture.AutoSize = true;
            this.lblCaptionPicture.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaptionPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaptionPicture.Location = new System.Drawing.Point(3, 516);
            this.lblCaptionPicture.Name = "lblCaptionPicture";
            this.lblCaptionPicture.Size = new System.Drawing.Size(103, 38);
            this.lblCaptionPicture.TabIndex = 6;
            this.lblCaptionPicture.Text = "Picture";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(403, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(394, 45);
            this.txtRecipeName.TabIndex = 7;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(403, 85);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(394, 45);
            this.txtCalories.TabIndex = 8;
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Location = new System.Drawing.Point(403, 167);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.Size = new System.Drawing.Size(394, 45);
            this.txtDraftDate.TabIndex = 9;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishedDate.Location = new System.Drawing.Point(403, 249);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.Size = new System.Drawing.Size(394, 45);
            this.txtPublishedDate.TabIndex = 10;
            // 
            // txtArchivedDate
            // 
            this.txtArchivedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivedDate.Location = new System.Drawing.Point(403, 331);
            this.txtArchivedDate.Name = "txtArchivedDate";
            this.txtArchivedDate.Size = new System.Drawing.Size(394, 45);
            this.txtArchivedDate.TabIndex = 11;
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentStatus.Location = new System.Drawing.Point(403, 413);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.Size = new System.Drawing.Size(394, 45);
            this.txtCurrentStatus.TabIndex = 12;
            this.txtCurrentStatus.TextChanged += new System.EventHandler(this.txtCurrentStatus_TextChanged);
            // 
            // txtPicture
            // 
            this.txtPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPicture.Location = new System.Drawing.Point(403, 495);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(394, 45);
            this.txtPicture.TabIndex = 13;
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
    }
}