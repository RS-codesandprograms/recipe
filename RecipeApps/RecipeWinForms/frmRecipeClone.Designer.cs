namespace RecipeWinForms
{
    partial class frmRecipeClone
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
            tblRecipeClone = new TableLayoutPanel();
            lstRecipeName = new ComboBox();
            btnClone = new Button();
            tblRecipeClone.SuspendLayout();
            SuspendLayout();
            // 
            // tblRecipeClone
            // 
            tblRecipeClone.ColumnCount = 2;
            tblRecipeClone.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeClone.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeClone.Controls.Add(lstRecipeName, 0, 0);
            tblRecipeClone.Controls.Add(btnClone, 0, 1);
            tblRecipeClone.Dock = DockStyle.Fill;
            tblRecipeClone.Location = new Point(0, 0);
            tblRecipeClone.Margin = new Padding(4, 4, 4, 4);
            tblRecipeClone.Name = "tblRecipeClone";
            tblRecipeClone.RowCount = 2;
            tblRecipeClone.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipeClone.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipeClone.Size = new Size(1034, 270);
            tblRecipeClone.TabIndex = 0;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(240, 90);
            lstRecipeName.Margin = new Padding(3, 3, 3, 10);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(274, 36);
            lstRecipeName.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClone.Location = new Point(374, 145);
            btnClone.Margin = new Padding(3, 10, 3, 3);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(140, 40);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // frmRecipeClone
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 270);
            Controls.Add(tblRecipeClone);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmRecipeClone";
            Text = "Clone a Recipe";
            tblRecipeClone.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblRecipeClone;
        private ComboBox lstRecipeName;
        private Button btnClone;
    }
}