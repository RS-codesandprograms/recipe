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
            tblRecipe = new TableLayoutPanel();
            lblCookbookname = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            lblDateCreated = new Label();
            lblCreationDate = new Label();
            textBox1 = new TextBox();
            ckbActive = new CheckBox();
            txtCookbookName = new TextBox();
            lstUser = new ComboBox();
            tblCookbook.SuspendLayout();
            tblDetails.SuspendLayout();
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
            tblDetails.ColumnStyles.Add(new ColumnStyle());
            tblDetails.ColumnStyles.Add(new ColumnStyle());
            tblDetails.ColumnStyles.Add(new ColumnStyle());
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tblDetails.Controls.Add(btnSave, 0, 0);
            tblDetails.Controls.Add(btnDelete, 1, 0);
            tblDetails.Controls.Add(lblCookbookname, 0, 1);
            tblDetails.Controls.Add(lblUser, 0, 2);
            tblDetails.Controls.Add(lblPrice, 0, 4);
            tblDetails.Controls.Add(lblActive, 0, 5);
            tblDetails.Controls.Add(lblDateCreated, 2, 3);
            tblDetails.Controls.Add(lblCreationDate, 2, 4);
            tblDetails.Controls.Add(textBox1, 1, 4);
            tblDetails.Controls.Add(ckbActive, 1, 5);
            tblDetails.Controls.Add(txtCookbookName, 1, 1);
            tblDetails.Controls.Add(lstUser, 1, 2);
            tblDetails.Dock = DockStyle.Fill;
            tblDetails.Location = new Point(3, 3);
            tblDetails.Name = "tblDetails";
            tblDetails.RowCount = 6;
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblDetails.Size = new Size(619, 309);
            tblDetails.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 45);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(170, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 45);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 2;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 318);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipe.Size = new Size(619, 309);
            tblRecipe.TabIndex = 1;
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
            lblDateCreated.Location = new Point(331, 164);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(126, 28);
            lblDateCreated.TabIndex = 6;
            lblDateCreated.Text = "Date Created";
            lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.Dock = DockStyle.Fill;
            lblCreationDate.Location = new Point(338, 214);
            lblCreationDate.Margin = new Padding(10);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(112, 31);
            lblCreationDate.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 8;
            // 
            // ckbActive
            // 
            ckbActive.AutoSize = true;
            ckbActive.Location = new Point(170, 258);
            ckbActive.Name = "ckbActive";
            ckbActive.Size = new Size(18, 17);
            ckbActive.TabIndex = 9;
            ckbActive.UseVisualStyleBackColor = true;
            // 
            // txtCookbookName
            // 
            tblDetails.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(170, 54);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(287, 34);
            txtCookbookName.TabIndex = 10;
            // 
            // lstUser
            // 
            tblDetails.SetColumnSpan(lstUser, 2);
            lstUser.Dock = DockStyle.Fill;
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(170, 105);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(287, 36);
            lstUser.TabIndex = 11;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 630);
            Controls.Add(tblCookbook);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblCookbook.ResumeLayout(false);
            tblDetails.ResumeLayout(false);
            tblDetails.PerformLayout();
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
        private Label lblCreationDate;
        private TextBox textBox1;
        private CheckBox ckbActive;
        private TextBox txtCookbookName;
        private ComboBox lstUser;
    }
}