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
			this.btnNewSale = new System.Windows.Forms.Button();
			this.btnNewPrescription = new System.Windows.Forms.Button();
			this.btnSearchEmployee = new System.Windows.Forms.Button();
			this.btnSearchPatient = new System.Windows.Forms.Button();
			this.lblTodaySales = new System.Windows.Forms.Label();
			this.listViewSales = new System.Windows.Forms.ListView();
			this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTotalMedicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnNewSale
			// 
			this.btnNewSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewSale.Location = new System.Drawing.Point(538, 332);
			this.btnNewSale.Name = "btnNewSale";
			this.btnNewSale.Size = new System.Drawing.Size(119, 39);
			this.btnNewSale.TabIndex = 1;
			this.btnNewSale.Text = "New &Sale";
			this.btnNewSale.UseVisualStyleBackColor = true;
			this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
			// 
			// btnNewPrescription
			// 
			this.btnNewPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewPrescription.Location = new System.Drawing.Point(538, 377);
			this.btnNewPrescription.Name = "btnNewPrescription";
			this.btnNewPrescription.Size = new System.Drawing.Size(119, 39);
			this.btnNewPrescription.TabIndex = 2;
			this.btnNewPrescription.Text = "New &Prescription";
			this.btnNewPrescription.UseVisualStyleBackColor = true;
			this.btnNewPrescription.Click += new System.EventHandler(this.btnNewPrescription_Click);
			// 
			// btnSearchEmployee
			// 
			this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearchEmployee.Location = new System.Drawing.Point(12, 377);
			this.btnSearchEmployee.Name = "btnSearchEmployee";
			this.btnSearchEmployee.Size = new System.Drawing.Size(119, 38);
			this.btnSearchEmployee.TabIndex = 4;
			this.btnSearchEmployee.Text = "Search &Employee";
			this.btnSearchEmployee.UseVisualStyleBackColor = true;
			this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
			// 
			// btnSearchPatient
			// 
			this.btnSearchPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearchPatient.Location = new System.Drawing.Point(12, 332);
			this.btnSearchPatient.Name = "btnSearchPatient";
			this.btnSearchPatient.Size = new System.Drawing.Size(119, 39);
			this.btnSearchPatient.TabIndex = 3;
			this.btnSearchPatient.Text = "Search P&atient";
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
			// listViewSales
			// 
			this.listViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colType,
            this.colEmployee,
            this.colDate,
            this.colTotalMedicine,
            this.colTotalPrice});
			this.listViewSales.FullRowSelect = true;
			this.listViewSales.Location = new System.Drawing.Point(12, 38);
			this.listViewSales.MultiSelect = false;
			this.listViewSales.Name = "listViewSales";
			this.listViewSales.Size = new System.Drawing.Size(645, 288);
			this.listViewSales.TabIndex = 0;
			this.listViewSales.UseCompatibleStateImageBehavior = false;
			this.listViewSales.View = System.Windows.Forms.View.Details;
			this.listViewSales.DoubleClick += new System.EventHandler(this.listViewSales_DoubleClick);
			this.listViewSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewSales_KeyDown);
			// 
			// colNumber
			// 
			this.colNumber.Text = "#";
			this.colNumber.Width = 33;
			// 
			// colType
			// 
			this.colType.Text = "Type";
			this.colType.Width = 71;
			// 
			// colEmployee
			// 
			this.colEmployee.Text = "Employee";
			this.colEmployee.Width = 111;
			// 
			// colDate
			// 
			this.colDate.Text = "Date";
			this.colDate.Width = 117;
			// 
			// colTotalMedicine
			// 
			this.colTotalMedicine.Text = "Total Medicine";
			this.colTotalMedicine.Width = 82;
			// 
			// colTotalPrice
			// 
			this.colTotalPrice.Text = "Total Price";
			this.colTotalPrice.Width = 105;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 427);
			this.Controls.Add(this.listViewSales);
			this.Controls.Add(this.lblTodaySales);
			this.Controls.Add(this.btnSearchPatient);
			this.Controls.Add(this.btnSearchEmployee);
			this.Controls.Add(this.btnNewPrescription);
			this.Controls.Add(this.btnNewSale);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MedTracking";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
        private System.Windows.Forms.ListView listViewSales;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colTotalMedicine;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
    }
}