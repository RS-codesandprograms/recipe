namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            tblMain = new TableLayoutPanel();
            pnlOptionButton = new FlowLayoutPanel();
            optStaff = new RadioButton();
            optCuisineType = new RadioButton();
            optIngredient = new RadioButton();
            optMeasurementType = new RadioButton();
            optCourse = new RadioButton();
            gData = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlOptionButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(pnlOptionButton, 0, 0);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // pnlOptionButton
            // 
            pnlOptionButton.Controls.Add(optStaff);
            pnlOptionButton.Controls.Add(optCuisineType);
            pnlOptionButton.Controls.Add(optIngredient);
            pnlOptionButton.Controls.Add(optMeasurementType);
            pnlOptionButton.Controls.Add(optCourse);
            pnlOptionButton.Dock = DockStyle.Fill;
            pnlOptionButton.Location = new Point(10, 10);
            pnlOptionButton.Margin = new Padding(10);
            pnlOptionButton.Name = "pnlOptionButton";
            pnlOptionButton.Size = new Size(167, 547);
            pnlOptionButton.TabIndex = 0;
            // 
            // optStaff
            // 
            optStaff.AutoSize = true;
            optStaff.Location = new Point(3, 3);
            optStaff.Name = "optStaff";
            optStaff.Size = new Size(80, 32);
            optStaff.TabIndex = 0;
            optStaff.TabStop = true;
            optStaff.Text = "Users";
            optStaff.TextAlign = ContentAlignment.MiddleCenter;
            optStaff.UseVisualStyleBackColor = true;
            // 
            // optCuisineType
            // 
            optCuisineType.AutoSize = true;
            optCuisineType.Location = new Point(3, 41);
            optCuisineType.Name = "optCuisineType";
            optCuisineType.Size = new Size(103, 32);
            optCuisineType.TabIndex = 1;
            optCuisineType.TabStop = true;
            optCuisineType.Text = "Cuisines";
            optCuisineType.TextAlign = ContentAlignment.MiddleCenter;
            optCuisineType.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(3, 79);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(131, 32);
            optIngredient.TabIndex = 2;
            optIngredient.TabStop = true;
            optIngredient.Text = "Ingredients";
            optIngredient.TextAlign = ContentAlignment.MiddleCenter;
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurementType
            // 
            optMeasurementType.AutoSize = true;
            optMeasurementType.Location = new Point(3, 117);
            optMeasurementType.Name = "optMeasurementType";
            optMeasurementType.Size = new Size(160, 32);
            optMeasurementType.TabIndex = 3;
            optMeasurementType.TabStop = true;
            optMeasurementType.Text = "Measurements";
            optMeasurementType.TextAlign = ContentAlignment.MiddleCenter;
            optMeasurementType.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Location = new Point(3, 155);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(101, 32);
            optCourse.TabIndex = 4;
            optCourse.TabStop = true;
            optCourse.Text = "Courses";
            optCourse.TextAlign = ContentAlignment.MiddleCenter;
            optCourse.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(197, 10);
            gData.Margin = new Padding(10);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(893, 547);
            gData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(952, 577);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 43);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "DataMaintenance";
            tblMain.ResumeLayout(false);
            pnlOptionButton.ResumeLayout(false);
            pnlOptionButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptionButton;
        private RadioButton optStaff;
        private RadioButton optCuisineType;
        private RadioButton optIngredient;
        private RadioButton optMeasurementType;
        private RadioButton optCourse;
        private DataGridView gData;
        private Button btnSave;
    }
}