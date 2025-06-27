namespace RecipeWinForms
{
    partial class frmRecipeList
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
            tblRecipeList = new TableLayoutPanel();
            btnNewRecipe = new Button();
            gRecipeList = new DataGridView();
            tblRecipeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).BeginInit();
            SuspendLayout();
            // 
            // tblRecipeList
            // 
            tblRecipeList.ColumnCount = 1;
            tblRecipeList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipeList.Controls.Add(btnNewRecipe, 0, 0);
            tblRecipeList.Controls.Add(gRecipeList, 0, 1);
            tblRecipeList.Dock = DockStyle.Fill;
            tblRecipeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblRecipeList.Location = new Point(0, 0);
            tblRecipeList.Name = "tblRecipeList";
            tblRecipeList.RowCount = 2;
            tblRecipeList.RowStyles.Add(new RowStyle());
            tblRecipeList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipeList.Size = new Size(800, 450);
            tblRecipeList.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Location = new Point(15, 15);
            btnNewRecipe.Margin = new Padding(15);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(157, 37);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipeList
            // 
            gRecipeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeList.Dock = DockStyle.Fill;
            gRecipeList.Location = new Point(15, 82);
            gRecipeList.Margin = new Padding(15);
            gRecipeList.Name = "gRecipeList";
            gRecipeList.RowTemplate.Height = 25;
            gRecipeList.Size = new Size(770, 353);
            gRecipeList.TabIndex = 1;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblRecipeList);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tblRecipeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gRecipeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblRecipeList;
        private Button btnNewRecipe;
        private DataGridView gRecipeList;
    }
}