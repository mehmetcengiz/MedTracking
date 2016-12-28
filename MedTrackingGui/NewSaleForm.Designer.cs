namespace MedTrackingGui
{
    partial class NewSaleForm
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
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "100",
            "Parol",
            "15",
            "2"}, -1);
			this.nudQuantity = new System.Windows.Forms.NumericUpDown();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.listViewMedicines = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddMedicineToList = new System.Windows.Forms.Button();
			this.lblMedicines = new System.Windows.Forms.Label();
			this.cbMedicines = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// nudQuantity
			// 
			this.nudQuantity.Location = new System.Drawing.Point(322, 12);
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.Size = new System.Drawing.Size(50, 20);
			this.nudQuantity.TabIndex = 1;
			this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(344, 283);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(425, 283);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// listViewMedicines
			// 
			this.listViewMedicines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
			this.listViewMedicines.FullRowSelect = true;
			this.listViewMedicines.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
			this.listViewMedicines.Location = new System.Drawing.Point(76, 39);
			this.listViewMedicines.Name = "listViewMedicines";
			this.listViewMedicines.Size = new System.Drawing.Size(424, 238);
			this.listViewMedicines.TabIndex = 4;
			this.listViewMedicines.UseCompatibleStateImageBehavior = false;
			this.listViewMedicines.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 45;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 280;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Quantity";
			this.columnHeader4.Width = 58;
			// 
			// btnAddMedicineToList
			// 
			this.btnAddMedicineToList.Enabled = false;
			this.btnAddMedicineToList.Location = new System.Drawing.Point(378, 10);
			this.btnAddMedicineToList.Name = "btnAddMedicineToList";
			this.btnAddMedicineToList.Size = new System.Drawing.Size(122, 23);
			this.btnAddMedicineToList.TabIndex = 2;
			this.btnAddMedicineToList.Text = "Add &Medicine To List";
			this.btnAddMedicineToList.UseVisualStyleBackColor = true;
			this.btnAddMedicineToList.Click += new System.EventHandler(this.btnAddMedicineToList_Click);
			// 
			// lblMedicines
			// 
			this.lblMedicines.AutoSize = true;
			this.lblMedicines.Location = new System.Drawing.Point(12, 14);
			this.lblMedicines.Name = "lblMedicines";
			this.lblMedicines.Size = new System.Drawing.Size(58, 13);
			this.lblMedicines.TabIndex = 7;
			this.lblMedicines.Text = "Medicines:";
			// 
			// cbMedicines
			// 
			this.cbMedicines.FormattingEnabled = true;
			this.cbMedicines.Location = new System.Drawing.Point(76, 12);
			this.cbMedicines.Name = "cbMedicines";
			this.cbMedicines.Size = new System.Drawing.Size(240, 21);
			this.cbMedicines.TabIndex = 0;
			this.cbMedicines.SelectedIndexChanged += new System.EventHandler(this.cbMedicines_SelectedIndexChanged);
			// 
			// NewSaleForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(512, 318);
			this.Controls.Add(this.nudQuantity);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.listViewMedicines);
			this.Controls.Add(this.btnAddMedicineToList);
			this.Controls.Add(this.lblMedicines);
			this.Controls.Add(this.cbMedicines);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewSaleForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MedTracking - New Sale";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSale_FormClosing);
			this.Load += new System.EventHandler(this.NewSale_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.NumericUpDown nudQuantity;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ListView listViewMedicines;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnAddMedicineToList;
		private System.Windows.Forms.Label lblMedicines;
		private System.Windows.Forms.ComboBox cbMedicines;
	}
}