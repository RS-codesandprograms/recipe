namespace RecipeWinForms
{
    partial class frmCookbook
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
            tblCookbook = new TableLayoutPanel();
            tblDetails = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookname = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            lblDateCreated = new Label();
            lblCookbookCreationDate = new Label();
            txtPrice = new TextBox();
            ckbIsActive = new CheckBox();
            txtCookbookName = new TextBox();
            lstUserName = new ComboBox();
            tblRecipe = new TableLayoutPanel();
            btnRecipeSave = new Button();
            gCookbookRecipe = new DataGridView();
            tblCookbook.SuspendLayout();
            tblDetails.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblCookbook
            // 
            tblCookbook.ColumnCount = 1;
            tblCookbook.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbook.Controls.Add(tblDetails, 0, 0);
            tblCookbook.Controls.Add(tblRecipe, 0, 1);
            tblCookbook.Dock = DockStyle.Fill;
            tblCookbook.Location = new Point(0, 0);
            tblCookbook.Margin = new Padding(4);
            tblCookbook.Name = "tblCookbook";
            tblCookbook.RowCount = 2;
            tblCookbook.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbook.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbook.Size = new Size(625, 630);
            tblCookbook.TabIndex = 0;
            // 
            // tblDetails
            // 
            tblDetails.ColumnCount = 4;
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1428566F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1428566F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1428566F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.57142854F));
            tblDetails.Controls.Add(btnSave, 0, 0);
            tblDetails.Controls.Add(btnDelete, 1, 0);
            tblDetails.Controls.Add(lblCookbookname, 0, 1);
            tblDetails.Controls.Add(lblUser, 0, 2);
            tblDetails.Controls.Add(lblPrice, 0, 4);
            tblDetails.Controls.Add(lblActive, 0, 5);
            tblDetails.Controls.Add(lblDateCreated, 2, 3);
            tblDetails.Controls.Add(lblCookbookCreationDate, 2, 4);
            tblDetails.Controls.Add(txtPrice, 1, 4);
            tblDetails.Controls.Add(ckbIsActive, 1, 5);
            tblDetails.Controls.Add(txtCookbookName, 1, 1);
            tblDetails.Controls.Add(lstUserName, 1, 2);
            tblDetails.Dock = DockStyle.Fill;
            tblDetails.Location = new Point(3, 3);
            tblDetails.Name = "tblDetails";
            tblDetails.RowCount = 6;
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblDetails.Size = new Size(619, 309);
            tblDetails.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(192, 45);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(201, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(192, 45);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookname
            // 
            lblCookbookname.Anchor = AnchorStyles.Left;
            lblCookbookname.AutoSize = true;
            lblCookbookname.Location = new Point(3, 62);
            lblCookbookname.Name = "lblCookbookname";
            lblCookbookname.Size = new Size(161, 28);
            lblCookbookname.TabIndex = 2;
            lblCookbookname.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 113);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 215);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 268);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(66, 28);
            lblActive.TabIndex = 5;
            lblActive.Text = "Active";
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.None;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(432, 164);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(126, 28);
            lblDateCreated.TabIndex = 6;
            lblDateCreated.Text = "Date Created";
            lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCookbookCreationDate
            // 
            lblCookbookCreationDate.AutoSize = true;
            lblCookbookCreationDate.BackColor = SystemColors.ControlDark;
            lblCookbookCreationDate.Dock = DockStyle.Fill;
            lblCookbookCreationDate.Location = new Point(399, 207);
            lblCookbookCreationDate.Margin = new Padding(3);
            lblCookbookCreationDate.Name = "lblCookbookCreationDate";
            lblCookbookCreationDate.Size = new Size(192, 45);
            lblCookbookCreationDate.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(201, 207);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(192, 34);
            txtPrice.TabIndex = 8;
            // 
            // ckbIsActive
            // 
            ckbIsActive.AutoSize = true;
            ckbIsActive.Dock = DockStyle.Fill;
            ckbIsActive.Location = new Point(201, 258);
            ckbIsActive.Name = "ckbIsActive";
            ckbIsActive.Size = new Size(192, 48);
            ckbIsActive.TabIndex = 9;
            ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtCookbookName
            // 
            tblDetails.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(201, 54);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(390, 34);
            txtCookbookName.TabIndex = 10;
            // 
            // lstUserName
            // 
            tblDetails.SetColumnSpan(lstUserName, 2);
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(201, 105);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(390, 36);
            lstUserName.TabIndex = 11;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 2;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.14863F));
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.85137F));
            tblRecipe.Controls.Add(btnRecipeSave, 0, 0);
            tblRecipe.Controls.Add(gCookbookRecipe, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 318);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7993526F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 82.2006454F));
            tblRecipe.Size = new Size(619, 309);
            tblRecipe.TabIndex = 1;
            // 
            // btnRecipeSave
            // 
            btnRecipeSave.Location = new Point(3, 3);
            btnRecipeSave.Name = "btnRecipeSave";
            btnRecipeSave.Size = new Size(192, 45);
            btnRecipeSave.TabIndex = 0;
            btnRecipeSave.Text = "Save";
            btnRecipeSave.UseVisualStyleBackColor = true;
            // 
            // gCookbookRecipe
            // 
            gCookbookRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblRecipe.SetColumnSpan(gCookbookRecipe, 2);
            gCookbookRecipe.Dock = DockStyle.Fill;
            gCookbookRecipe.Location = new Point(3, 58);
            gCookbookRecipe.Name = "gCookbookRecipe";
            gCookbookRecipe.RowHeadersWidth = 51;
            gCookbookRecipe.Size = new Size(613, 248);
            gCookbookRecipe.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 630);
            Controls.Add(tblCookbook);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblCookbook.ResumeLayout(false);
            tblDetails.ResumeLayout(false);
            tblDetails.PerformLayout();
            tblRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCookbook;
        private TableLayoutPanel tblDetails;
        private TableLayoutPanel tblRecipe;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookname;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private Label lblDateCreated;
        private Label lblCookbookCreationDate;
        private TextBox txtPrice;
        private CheckBox ckbActive;
        private TextBox txtCookbookName;
        private ComboBox lstUserName;
        private Button btnRecipeSave;
        private DataGridView gCookbookRecipe;
        private CheckBox ckbIsActive;
    }
}