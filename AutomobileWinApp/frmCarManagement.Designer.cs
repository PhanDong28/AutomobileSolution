namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            IbCarID = new Label();
            IbCarName = new Label();
            IbManufacturer = new Label();
            IbPrice = new Label();
            IbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            txtManufacturer = new TextBox();
            btnLoad = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // IbCarID
            // 
            IbCarID.AutoSize = true;
            IbCarID.Location = new Point(42, 22);
            IbCarID.Name = "IbCarID";
            IbCarID.Size = new Size(61, 25);
            IbCarID.TabIndex = 0;
            IbCarID.Text = "Car ID";
            // 
            // IbCarName
            // 
            IbCarName.AutoSize = true;
            IbCarName.Location = new Point(42, 72);
            IbCarName.Name = "IbCarName";
            IbCarName.Size = new Size(90, 25);
            IbCarName.TabIndex = 1;
            IbCarName.Text = "Car Name";
            // 
            // IbManufacturer
            // 
            IbManufacturer.AutoSize = true;
            IbManufacturer.Location = new Point(42, 122);
            IbManufacturer.Name = "IbManufacturer";
            IbManufacturer.Size = new Size(117, 25);
            IbManufacturer.TabIndex = 2;
            IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            IbPrice.AutoSize = true;
            IbPrice.Location = new Point(446, 22);
            IbPrice.Name = "IbPrice";
            IbPrice.Size = new Size(49, 25);
            IbPrice.TabIndex = 3;
            IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            IbReleaseYear.AutoSize = true;
            IbReleaseYear.Location = new Point(446, 72);
            IbReleaseYear.Name = "IbReleaseYear";
            IbReleaseYear.Size = new Size(102, 25);
            IbReleaseYear.TabIndex = 4;
            IbReleaseYear.Text = "ReleaseYear";
            IbReleaseYear.Click += label1_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(168, 12);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(186, 31);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(168, 66);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(186, 31);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(561, 16);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 31);
            txtPrice.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(561, 66);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(202, 31);
            txtReleaseYear.TabIndex = 8;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(168, 116);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(186, 31);
            txtManufacturer.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(168, 173);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(368, 173);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 228);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.RowTemplate.Height = 33;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(788, 165);
            dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(368, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(txtManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(IbReleaseYear);
            Controls.Add(IbPrice);
            Controls.Add(IbManufacturer);
            Controls.Add(IbCarName);
            Controls.Add(IbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbCarID;
        private Label IbCarName;
        private Label IbManufacturer;
        private Label IbPrice;
        private Label IbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private TextBox txtManufacturer;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnNew;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}