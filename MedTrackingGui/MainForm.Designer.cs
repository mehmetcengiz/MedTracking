﻿namespace MedTrackingGui
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
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnNewPrescription = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalMedicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTodaySales.Location = new System.Drawing.Point(258, 9);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(125, 24);
            this.lblTodaySales.TabIndex = 4;
            this.lblTodaySales.Text = "Today Sales";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colType,
            this.colEmployee,
            this.colPatient,
            this.colDate,
            this.colTotalMedicine,
            this.colTotalPrice});
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(645, 288);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colNumber
            // 
            this.colNumber.Text = "#";
            this.colNumber.Width = 33;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 78;
            // 
            // colEmployee
            // 
            this.colEmployee.Text = "Employee";
            this.colEmployee.Width = 119;
            // 
            // colPatient
            // 
            this.colPatient.Text = "Patient";
            this.colPatient.Width = 112;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 99;
            // 
            // colTotalMedicine
            // 
            this.colTotalMedicine.Text = "Total Medicine";
            this.colTotalMedicine.Width = 82;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Total Price";
            this.colTotalPrice.Width = 114;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 427);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTodaySales);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.btnNewPrescription);
            this.Controls.Add(this.btnNewSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Tracking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnNewPrescription;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.ColumnHeader colPatient;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colTotalMedicine;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
    }
}