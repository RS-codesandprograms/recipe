namespace RecipeWinForms
{
    partial class frmCookbookList
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
            tblCookBookList = new TableLayoutPanel();
            btnNewCookbook = new Button();
            gCookbookList = new DataGridView();
            tblCookBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookList).BeginInit();
            SuspendLayout();
            // 
            // tblCookBookList
            // 
            tblCookBookList.ColumnCount = 2;
            tblCookBookList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.90909F));
            tblCookBookList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.09091F));
            tblCookBookList.Controls.Add(btnNewCookbook, 0, 0);
            tblCookBookList.Controls.Add(gCookbookList, 0, 1);
            tblCookBookList.Dock = DockStyle.Fill;
            tblCookBookList.Location = new Point(0, 0);
            tblCookBookList.Margin = new Padding(4);
            tblCookBookList.Name = "tblCookBookList";
            tblCookBookList.RowCount = 1;
            tblCookBookList.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476F));
            tblCookBookList.RowStyles.Add(new RowStyle(SizeType.Percent, 88.09524F));
            tblCookBookList.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCookBookList.Size = new Size(1100, 630);
            tblCookBookList.TabIndex = 0;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.Dock = DockStyle.Fill;
            btnNewCookbook.Location = new Point(10, 10);
            btnNewCookbook.Margin = new Padding(10);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(177, 54);
            btnNewCookbook.TabIndex = 0;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = true;
            // 
            // gCookbookList
            // 
            gCookbookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCookBookList.SetColumnSpan(gCookbookList, 2);
            gCookbookList.Dock = DockStyle.Fill;
            gCookbookList.Location = new Point(3, 77);
            gCookbookList.Name = "gCookbookList";
            gCookbookList.RowHeadersWidth = 51;
            gCookbookList.RowTemplate.Height = 29;
            gCookbookList.Size = new Size(1094, 550);
            gCookbookList.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblCookBookList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCookbookList";
            Text = "frmCookbookList";
            tblCookBookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCookBookList;
        private Button btnNewCookbook;
        private DataGridView gCookbookList;
    }
}