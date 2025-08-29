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
            tblMealList.Margin = new Padding(3, 2, 3, 2);
            tblMealList.Name = "tblMealList";
            tblMealList.RowCount = 1;
            tblMealList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMealList.Size = new Size(700, 338);
            tblMealList.TabIndex = 0;
            // 
            // gMealList
            // 
            gMealList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMealList.Dock = DockStyle.Fill;
            gMealList.Location = new Point(9, 8);
            gMealList.Margin = new Padding(9, 8, 9, 8);
            gMealList.Name = "gMealList";
            gMealList.RowHeadersWidth = 51;
            gMealList.RowTemplate.Height = 29;
            gMealList.Size = new Size(682, 322);
            gMealList.TabIndex = 0;
            // 
            // frmMealList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tblMealList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMealList";
            Text = "Meal List";
            tblMealList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gMealList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMealList;
        private DataGridView gMealList;
    }
}