namespace MedTrackingGui
{
    partial class MainForm
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
            this.dataSaleList = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.saleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnNewPrescription = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSaleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSaleList
            // 
            this.dataSaleList.AllowUserToAddRows = false;
            this.dataSaleList.AllowUserToDeleteRows = false;
            this.dataSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSaleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleType,
            this.employee,
            this.patient,
            this.date,
            this.totalMedicine,
            this.totalPrice});
            this.dataSaleList.Location = new System.Drawing.Point(12, 12);
            this.dataSaleList.Name = "dataSaleList";
            this.dataSaleList.ReadOnly = true;
            this.dataSaleList.Size = new System.Drawing.Size(645, 168);
            this.dataSaleList.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // saleType
            // 
            this.saleType.HeaderText = "Type";
            this.saleType.Name = "saleType";
            this.saleType.ReadOnly = true;
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee";
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            // 
            // patient
            // 
            this.patient.HeaderText = "Patient";
            this.patient.Name = "patient";
            this.patient.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // totalMedicine
            // 
            this.totalMedicine.HeaderText = "Total Medicine";
            this.totalMedicine.Name = "totalMedicine";
            this.totalMedicine.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "TotalPrice";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(538, 332);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(119, 39);
            this.btnNewSale.TabIndex = 1;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = true;
            // 
            // btnNewPrescription
            // 
            this.btnNewPrescription.Location = new System.Drawing.Point(538, 377);
            this.btnNewPrescription.Name = "btnNewPrescription";
            this.btnNewPrescription.Size = new System.Drawing.Size(119, 39);
            this.btnNewPrescription.TabIndex = 1;
            this.btnNewPrescription.Text = "New Prescription";
            this.btnNewPrescription.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(12, 377);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(119, 38);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(12, 332);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(119, 39);
            this.btnSearchPatient.TabIndex = 3;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 427);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.btnNewPrescription);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.dataSaleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dataSaleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSaleList;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnNewPrescription;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnSearchPatient;
    }
}