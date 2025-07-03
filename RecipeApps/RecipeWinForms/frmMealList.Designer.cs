namespace RecipeWinForms
{
    partial class frmMealList
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
            tblMealList = new TableLayoutPanel();
            gMealList = new DataGridView();
            tblMealList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gMealList).BeginInit();
            SuspendLayout();
            // 
            // tblMealList
            // 
            tblMealList.ColumnCount = 1;
            tblMealList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMealList.Controls.Add(gMealList, 0, 0);
            tblMealList.Dock = DockStyle.Fill;
            tblMealList.Location = new Point(0, 0);
            tblMealList.Name = "tblMealList";
            tblMealList.RowCount = 1;
            tblMealList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMealList.Size = new Size(800, 450);
            tblMealList.TabIndex = 0;
            // 
            // gMealList
            // 
            gMealList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMealList.Dock = DockStyle.Fill;
            gMealList.Location = new Point(10, 10);
            gMealList.Margin = new Padding(10);
            gMealList.Name = "gMealList";
            gMealList.RowHeadersWidth = 51;
            gMealList.RowTemplate.Height = 29;
            gMealList.Size = new Size(780, 430);
            gMealList.TabIndex = 0;
            // 
            // frmMealList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMealList);
            Name = "frmMealList";
            Text = "frmMealList";
            tblMealList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gMealList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMealList;
        private DataGridView gMealList;
    }
}