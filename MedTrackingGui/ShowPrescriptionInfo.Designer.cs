﻿namespace MedTrackingGui {
	partial class ShowPrescriptionInfo {
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "100",
            "Parol",
            "15",
            "2"}, -1);
			this.btnOk = new System.Windows.Forms.Button();
			this.listViewMedicines = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblDoctorFullName = new System.Windows.Forms.Label();
			this.lblPatientFullName = new System.Windows.Forms.Label();
			this.tbPatientFullName = new System.Windows.Forms.TextBox();
			this.tbDoctorFullName = new System.Windows.Forms.TextBox();
			this.tbDateAndTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbEmployeeFullName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOk.Location = new System.Drawing.Point(425, 364);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 19;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// listViewMedicines
			// 
			this.listViewMedicines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewMedicines.FullRowSelect = true;
			this.listViewMedicines.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listViewMedicines.Location = new System.Drawing.Point(124, 116);
			this.listViewMedicines.Name = "listViewMedicines";
			this.listViewMedicines.Size = new System.Drawing.Size(376, 242);
			this.listViewMedicines.TabIndex = 16;
			this.listViewMedicines.UseCompatibleStateImageBehavior = false;
			this.listViewMedicines.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 46;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 260;
			// 
			// lblDoctorFullName
			// 
			this.lblDoctorFullName.AutoSize = true;
			this.lblDoctorFullName.Location = new System.Drawing.Point(26, 67);
			this.lblDoctorFullName.Name = "lblDoctorFullName";
			this.lblDoctorFullName.Size = new System.Drawing.Size(92, 13);
			this.lblDoctorFullName.TabIndex = 9;
			this.lblDoctorFullName.Text = "Doctor Full Name:";
			// 
			// lblPatientFullName
			// 
			this.lblPatientFullName.AutoSize = true;
			this.lblPatientFullName.Location = new System.Drawing.Point(25, 41);
			this.lblPatientFullName.Name = "lblPatientFullName";
			this.lblPatientFullName.Size = new System.Drawing.Size(93, 13);
			this.lblPatientFullName.TabIndex = 10;
			this.lblPatientFullName.Text = "Patient Full Name:";
			// 
			// tbPatientFullName
			// 
			this.tbPatientFullName.Location = new System.Drawing.Point(124, 38);
			this.tbPatientFullName.Name = "tbPatientFullName";
			this.tbPatientFullName.ReadOnly = true;
			this.tbPatientFullName.Size = new System.Drawing.Size(376, 20);
			this.tbPatientFullName.TabIndex = 20;
			// 
			// tbDoctorFullName
			// 
			this.tbDoctorFullName.Location = new System.Drawing.Point(124, 64);
			this.tbDoctorFullName.Name = "tbDoctorFullName";
			this.tbDoctorFullName.ReadOnly = true;
			this.tbDoctorFullName.Size = new System.Drawing.Size(376, 20);
			this.tbDoctorFullName.TabIndex = 20;
			// 
			// tbDateAndTime
			// 
			this.tbDateAndTime.Location = new System.Drawing.Point(124, 90);
			this.tbDateAndTime.Name = "tbDateAndTime";
			this.tbDateAndTime.ReadOnly = true;
			this.tbDateAndTime.Size = new System.Drawing.Size(376, 20);
			this.tbDateAndTime.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Date and Time:";
			// 
			// tbEmployeeFullName
			// 
			this.tbEmployeeFullName.Location = new System.Drawing.Point(124, 12);
			this.tbEmployeeFullName.Name = "tbEmployeeFullName";
			this.tbEmployeeFullName.ReadOnly = true;
			this.tbEmployeeFullName.Size = new System.Drawing.Size(376, 20);
			this.tbEmployeeFullName.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Employee Full Name:";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Price";
			// 
			// ShowPrescriptionInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnOk;
			this.ClientSize = new System.Drawing.Size(512, 399);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.listViewMedicines);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblDoctorFullName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblPatientFullName);
			this.Controls.Add(this.tbDateAndTime);
			this.Controls.Add(this.tbDoctorFullName);
			this.Controls.Add(this.tbEmployeeFullName);
			this.Controls.Add(this.tbPatientFullName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ShowPrescriptionInfo";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MedTracking - Prescription Info";
			this.Load += new System.EventHandler(this.ShowPrescriptionInfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListView listViewMedicines;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label lblDoctorFullName;
		private System.Windows.Forms.Label lblPatientFullName;
		private System.Windows.Forms.TextBox tbPatientFullName;
		private System.Windows.Forms.TextBox tbDoctorFullName;
		private System.Windows.Forms.TextBox tbDateAndTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbEmployeeFullName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}