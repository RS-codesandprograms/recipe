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
            lblDateCreated = new Label();
            lblCookbookCreationDate = new Label();
            txtPrice = new TextBox();
            ckbIsActive = new CheckBox();
            txtCookbookName = new TextBox();
            lstUserName = new ComboBox();
            lblActive = new Label();
            pRecipe = new Panel();
            tblRecipe = new TableLayoutPanel();
            btnRecipeSave = new Button();
            gCookbookRecipe = new DataGridView();
            tblCookbook.SuspendLayout();
            tblDetails.SuspendLayout();
            pRecipe.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblCookbook
            // 
            tblCookbook.ColumnCount = 1;
            tblCookbook.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbook.Controls.Add(tblDetails, 0, 0);
            tblCookbook.Controls.Add(pRecipe, 0, 1);
            tblCookbook.Dock = DockStyle.Fill;
            tblCookbook.Location = new Point(0, 0);
            tblCookbook.Margin = new Padding(4);
            tblCookbook.Name = "tblCookbook";
            tblCookbook.RowCount = 2;
            tblCookbook.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbook.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbook.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCookbook.Size = new Size(693, 630);
            tblCookbook.TabIndex = 0;
            // 
            // tblDetails
            // 
            tblDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblDetails.ColumnCount = 4;
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7647057F));
            tblDetails.Controls.Add(btnSave, 0, 0);
            tblDetails.Controls.Add(btnDelete, 1, 0);
            tblDetails.Controls.Add(lblCookbookname, 0, 1);
            tblDetails.Controls.Add(lblUser, 0, 2);
            tblDetails.Controls.Add(lblPrice, 0, 4);
            tblDetails.Controls.Add(lblDateCreated, 2, 3);
            tblDetails.Controls.Add(lblCookbookCreationDate, 2, 4);
            tblDetails.Controls.Add(txtPrice, 1, 4);
            tblDetails.Controls.Add(ckbIsActive, 1, 5);
            tblDetails.Controls.Add(txtCookbookName, 1, 1);
            tblDetails.Controls.Add(lstUserName, 1, 2);
            tblDetails.Controls.Add(lblActive, 0, 5);
            tblDetails.Location = new Point(3, 3);
            tblDetails.Name = "tblDetails";
            tblDetails.RowCount = 6;
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8571453F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8571434F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8571434F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142839F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8571434F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8571434F));
            tblDetails.Size = new Size(687, 309);
            tblDetails.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(205, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(196, 49);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookname
            // 
            lblCookbookname.AutoSize = true;
            lblCookbookname.Location = new Point(3, 55);
            lblCookbookname.Name = "lblCookbookname";
            lblCookbookname.Size = new Size(161, 28);
            lblCookbookname.TabIndex = 2;
            lblCookbookname.Text = "Cookbook Name";
            lblCookbookname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 110);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 198);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Bottom;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(442, 170);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(126, 28);
            lblDateCreated.TabIndex = 6;
            lblDateCreated.Text = "Date Created";
            lblDateCreated.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblCookbookCreationDate
            // 
            lblCookbookCreationDate.AutoSize = true;
            lblCookbookCreationDate.BackColor = SystemColors.ControlDark;
            lblCookbookCreationDate.Dock = DockStyle.Fill;
            lblCookbookCreationDate.Location = new Point(407, 201);
            lblCookbookCreationDate.Margin = new Padding(3);
            lblCookbookCreationDate.Name = "lblCookbookCreationDate";
            lblCookbookCreationDate.Size = new Size(196, 49);
            lblCookbookCreationDate.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(205, 201);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 34);
            txtPrice.TabIndex = 4;
            // 
            // ckbIsActive
            // 
            ckbIsActive.Checked = true;
            ckbIsActive.CheckState = CheckState.Checked;
            ckbIsActive.Dock = DockStyle.Top;
            ckbIsActive.Location = new Point(205, 256);
            ckbIsActive.Name = "ckbIsActive";
            ckbIsActive.Size = new Size(196, 50);
            ckbIsActive.TabIndex = 5;
            ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtCookbookName
            // 
            tblDetails.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(205, 58);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(398, 34);
            txtCookbookName.TabIndex = 2;
            // 
            // lstUserName
            // 
            tblDetails.SetColumnSpan(lstUserName, 2);
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(205, 113);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(398, 36);
            lstUserName.TabIndex = 3;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 253);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(66, 28);
            lblActive.TabIndex = 5;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pRecipe
            // 
            pRecipe.BorderStyle = BorderStyle.FixedSingle;
            pRecipe.Controls.Add(tblRecipe);
            pRecipe.Dock = DockStyle.Fill;
            pRecipe.Location = new Point(3, 318);
            pRecipe.Name = "pRecipe";
            pRecipe.Size = new Size(687, 309);
            pRecipe.TabIndex = 1;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 2;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.14863F));
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.85137F));
            tblRecipe.Controls.Add(btnRecipeSave, 0, 0);
            tblRecipe.Controls.Add(gCookbookRecipe, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(0, 0);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7993526F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 82.2006454F));
            tblRecipe.Size = new Size(685, 307);
            tblRecipe.TabIndex = 2;
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
            gCookbookRecipe.Location = new Point(3, 57);
            gCookbookRecipe.Name = "gCookbookRecipe";
            gCookbookRecipe.RowHeadersWidth = 51;
            gCookbookRecipe.ScrollBars = ScrollBars.Horizontal;
            gCookbookRecipe.Size = new Size(679, 247);
            gCookbookRecipe.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 630);
            Controls.Add(tblCookbook);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblCookbook.ResumeLayout(false);
            tblDetails.ResumeLayout(false);
            tblDetails.PerformLayout();
            pRecipe.ResumeLayout(false);
            tblRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCookbook;
        private TableLayoutPanel tblDetails;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookname;
        private Label lblUser;
        private Label lblPrice;
        private Label lblDateCreated;
        private Label lblCookbookCreationDate;
        private TextBox txtPrice;
        private CheckBox ckbActive;
        private TextBox txtCookbookName;
        private ComboBox lstUserName;
        private Panel pRecipe;
        private TableLayoutPanel tblRecipe;
        private Button btnRecipeSave;
        private DataGridView gCookbookRecipe;
        private CheckBox ckbIsActive;
        private Label lblActive;
    }
}