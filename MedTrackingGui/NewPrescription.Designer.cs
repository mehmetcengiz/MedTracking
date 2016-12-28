namespace MedTrackingGui {
    partial class NewPrescription {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "100",
            "Parol",
            "15",
            "2"}, -1);
			this.cbPatientFullNames = new System.Windows.Forms.ComboBox();
			this.lblPatientFullName = new System.Windows.Forms.Label();
			this.btnAddNewPatient = new System.Windows.Forms.Button();
			this.cbDoctorFullNames = new System.Windows.Forms.ComboBox();
			this.lblDoctorFullName = new System.Windows.Forms.Label();
			this.btnAddNewDoctor = new System.Windows.Forms.Button();
			this.lblMedicines = new System.Windows.Forms.Label();
			this.listViewMedicines = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbMedicines = new System.Windows.Forms.ComboBox();
			this.btnAddMedicineToList = new System.Windows.Forms.Button();
			this.nudQuantity = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// cbPatientFullNames
			// 
			this.cbPatientFullNames.FormattingEnabled = true;
			this.cbPatientFullNames.Location = new System.Drawing.Point(111, 13);
			this.cbPatientFullNames.Name = "cbPatientFullNames";
			this.cbPatientFullNames.Size = new System.Drawing.Size(261, 21);
			this.cbPatientFullNames.TabIndex = 0;
			this.cbPatientFullNames.SelectedIndexChanged += new System.EventHandler(this.cbPatientFullNames_SelectedIndexChanged);
			// 
			// lblPatientFullName
			// 
			this.lblPatientFullName.AutoSize = true;
			this.lblPatientFullName.Location = new System.Drawing.Point(12, 16);
			this.lblPatientFullName.Name = "lblPatientFullName";
			this.lblPatientFullName.Size = new System.Drawing.Size(93, 13);
			this.lblPatientFullName.TabIndex = 1;
			this.lblPatientFullName.Text = "Patient Full Name:";
			// 
			// btnAddNewPatient
			// 
			this.btnAddNewPatient.Location = new System.Drawing.Point(378, 12);
			this.btnAddNewPatient.Name = "btnAddNewPatient";
			this.btnAddNewPatient.Size = new System.Drawing.Size(122, 23);
			this.btnAddNewPatient.TabIndex = 6;
			this.btnAddNewPatient.Text = "Add New &Patient";
			this.btnAddNewPatient.UseVisualStyleBackColor = true;
			this.btnAddNewPatient.Click += new System.EventHandler(this.btnAddNewPatient_Click);
			// 
			// cbDoctorFullNames
			// 
			this.cbDoctorFullNames.FormattingEnabled = true;
			this.cbDoctorFullNames.Location = new System.Drawing.Point(111, 40);
			this.cbDoctorFullNames.Name = "cbDoctorFullNames";
			this.cbDoctorFullNames.Size = new System.Drawing.Size(261, 21);
			this.cbDoctorFullNames.TabIndex = 1;
			this.cbDoctorFullNames.SelectedIndexChanged += new System.EventHandler(this.cbDoctorFullNames_SelectedIndexChanged);
			// 
			// lblDoctorFullName
			// 
			this.lblDoctorFullName.AutoSize = true;
			this.lblDoctorFullName.Location = new System.Drawing.Point(13, 43);
			this.lblDoctorFullName.Name = "lblDoctorFullName";
			this.lblDoctorFullName.Size = new System.Drawing.Size(92, 13);
			this.lblDoctorFullName.TabIndex = 1;
			this.lblDoctorFullName.Text = "Doctor Full Name:";
			// 
			// btnAddNewDoctor
			// 
			this.btnAddNewDoctor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddNewDoctor.Location = new System.Drawing.Point(378, 39);
			this.btnAddNewDoctor.Name = "btnAddNewDoctor";
			this.btnAddNewDoctor.Size = new System.Drawing.Size(122, 23);
			this.btnAddNewDoctor.TabIndex = 7;
			this.btnAddNewDoctor.Text = "Add New &Doctor";
			this.btnAddNewDoctor.UseVisualStyleBackColor = true;
			this.btnAddNewDoctor.Click += new System.EventHandler(this.btnAddNewDoctor_Click);
			// 
			// lblMedicines
			// 
			this.lblMedicines.AutoSize = true;
			this.lblMedicines.Location = new System.Drawing.Point(47, 70);
			this.lblMedicines.Name = "lblMedicines";
			this.lblMedicines.Size = new System.Drawing.Size(58, 13);
			this.lblMedicines.TabIndex = 1;
			this.lblMedicines.Text = "Medicines:";
			// 
			// listViewMedicines
			// 
			this.listViewMedicines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
			this.listViewMedicines.FullRowSelect = true;
			this.listViewMedicines.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
			this.listViewMedicines.Location = new System.Drawing.Point(111, 94);
			this.listViewMedicines.Name = "listViewMedicines";
			this.listViewMedicines.Size = new System.Drawing.Size(389, 238);
			this.listViewMedicines.TabIndex = 8;
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
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(425, 338);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(344, 338);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbMedicines
			// 
			this.cbMedicines.FormattingEnabled = true;
			this.cbMedicines.Location = new System.Drawing.Point(111, 67);
			this.cbMedicines.Name = "cbMedicines";
			this.cbMedicines.Size = new System.Drawing.Size(205, 21);
			this.cbMedicines.TabIndex = 2;
			this.cbMedicines.SelectedIndexChanged += new System.EventHandler(this.cbMedicines_SelectedIndexChanged);
			// 
			// btnAddMedicineToList
			// 
			this.btnAddMedicineToList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddMedicineToList.Enabled = false;
			this.btnAddMedicineToList.Location = new System.Drawing.Point(378, 65);
			this.btnAddMedicineToList.Name = "btnAddMedicineToList";
			this.btnAddMedicineToList.Size = new System.Drawing.Size(122, 23);
			this.btnAddMedicineToList.TabIndex = 4;
			this.btnAddMedicineToList.Text = "Add &Medicine To List";
			this.btnAddMedicineToList.UseVisualStyleBackColor = true;
			this.btnAddMedicineToList.Click += new System.EventHandler(this.btnAddMedicineToList_Click);
			// 
			// nudQuantity
			// 
			this.nudQuantity.Location = new System.Drawing.Point(322, 67);
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.Size = new System.Drawing.Size(50, 20);
			this.nudQuantity.TabIndex = 3;
			this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
			// 
			// NewPrescription
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(512, 373);
			this.Controls.Add(this.nudQuantity);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.listViewMedicines);
			this.Controls.Add(this.btnAddMedicineToList);
			this.Controls.Add(this.btnAddNewDoctor);
			this.Controls.Add(this.btnAddNewPatient);
			this.Controls.Add(this.lblMedicines);
			this.Controls.Add(this.lblDoctorFullName);
			this.Controls.Add(this.lblPatientFullName);
			this.Controls.Add(this.cbMedicines);
			this.Controls.Add(this.cbDoctorFullNames);
			this.Controls.Add(this.cbPatientFullNames);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewPrescription";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MedTracking - New Prescription";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPrescription_FormClosing);
			this.Load += new System.EventHandler(this.NewPrescription_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPatientFullNames;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Button btnAddNewPatient;
        private System.Windows.Forms.ComboBox cbDoctorFullNames;
        private System.Windows.Forms.Label lblDoctorFullName;
        private System.Windows.Forms.Button btnAddNewDoctor;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.ListView listViewMedicines;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ComboBox cbMedicines;
		private System.Windows.Forms.Button btnAddMedicineToList;
		private System.Windows.Forms.NumericUpDown nudQuantity;
	}
}