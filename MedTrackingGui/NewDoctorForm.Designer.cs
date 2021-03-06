﻿namespace MedTrackingGui {
	partial class NewDoctorForm {
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbDiplomaNumber = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(122, 252);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(203, 252);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(76, 116);
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(202, 130);
			this.tbAddress.TabIndex = 4;
			this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Address:";
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(76, 90);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(202, 20);
			this.tbPhone.TabIndex = 3;
			this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Phone:";
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(76, 64);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(202, 20);
			this.tbSurname.TabIndex = 2;
			this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Surname:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(76, 38);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(202, 20);
			this.tbName.TabIndex = 1;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Diploma #:";
			// 
			// tbDiplomaNumber
			// 
			this.tbDiplomaNumber.Location = new System.Drawing.Point(76, 12);
			this.tbDiplomaNumber.Name = "tbDiplomaNumber";
			this.tbDiplomaNumber.Size = new System.Drawing.Size(202, 20);
			this.tbDiplomaNumber.TabIndex = 0;
			this.tbDiplomaNumber.TextChanged += new System.EventHandler(this.tbDiplomaNumber_TextChanged);
			// 
			// NewDoctorForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(290, 287);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbDiplomaNumber);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewDoctorForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MedTracking - New Doctor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDoctorForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbDiplomaNumber;
	}
}