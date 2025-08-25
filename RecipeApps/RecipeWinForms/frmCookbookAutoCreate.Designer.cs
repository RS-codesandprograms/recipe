namespace RecipeWinForms
{
    partial class frmCookbookAutoCreate
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
            tblAutoCreateCkbk = new TableLayoutPanel();
            lstUserName = new ComboBox();
            btnCreateCkbk = new Button();
            tblAutoCreateCkbk.SuspendLayout();
            SuspendLayout();
            // 
            // tblAutoCreateCkbk
            // 
            tblAutoCreateCkbk.ColumnCount = 2;
            tblAutoCreateCkbk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAutoCreateCkbk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAutoCreateCkbk.Controls.Add(lstUserName, 0, 1);
            tblAutoCreateCkbk.Controls.Add(btnCreateCkbk, 1, 1);
            tblAutoCreateCkbk.Dock = DockStyle.Fill;
            tblAutoCreateCkbk.Location = new Point(0, 0);
            tblAutoCreateCkbk.Name = "tblAutoCreateCkbk";
            tblAutoCreateCkbk.RowCount = 3;
            tblAutoCreateCkbk.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblAutoCreateCkbk.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblAutoCreateCkbk.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblAutoCreateCkbk.Size = new Size(1050, 271);
            tblAutoCreateCkbk.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(100, 93);
            lstUserName.Margin = new Padding(100, 3, 100, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(325, 29);
            lstUserName.TabIndex = 0;
            // 
            // btnCreateCkbk
            // 
            btnCreateCkbk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateCkbk.Location = new Point(625, 93);
            btnCreateCkbk.Margin = new Padding(100, 3, 100, 3);
            btnCreateCkbk.Name = "btnCreateCkbk";
            btnCreateCkbk.Size = new Size(325, 84);
            btnCreateCkbk.TabIndex = 1;
            btnCreateCkbk.Text = "Create Cookbook";
            btnCreateCkbk.UseVisualStyleBackColor = true;
            // 
            // frmCookbookAutoCreate
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 271);
            Controls.Add(tblAutoCreateCkbk);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmCookbookAutoCreate";
            Text = "Auto-Create a Cookbook";
            tblAutoCreateCkbk.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblAutoCreateCkbk;
        private ComboBox lstUserName;
        private Button btnCreateCkbk;
    }
}