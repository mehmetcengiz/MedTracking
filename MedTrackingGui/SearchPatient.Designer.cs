namespace MedTrackingGui
{
    partial class SearchPatient
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.lvEmployees = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnOk = new System.Windows.Forms.Button();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Enabled = false;
			this.btnSearch.Location = new System.Drawing.Point(425, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 98);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lvEmployees
			// 
			this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvEmployees.FullRowSelect = true;
			this.lvEmployees.Location = new System.Drawing.Point(70, 116);
			this.lvEmployees.Name = "lvEmployees";
			this.lvEmployees.Size = new System.Drawing.Size(430, 242);
			this.lvEmployees.TabIndex = 13;
			this.lvEmployees.UseCompatibleStateImageBehavior = false;
			this.lvEmployees.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 44;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Surname";
			this.columnHeader3.Width = 76;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Phone";
			this.columnHeader4.Width = 85;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOk.Location = new System.Drawing.Point(425, 364);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 14;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(70, 64);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(349, 20);
			this.tbPhone.TabIndex = 11;
			this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Phone:";
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(70, 38);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(349, 20);
			this.tbSurname.TabIndex = 10;
			this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Surname:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(70, 12);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(349, 20);
			this.tbName.TabIndex = 8;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Address:";
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(70, 90);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(349, 20);
			this.tbAddress.TabIndex = 11;
			this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Address";
			this.columnHeader5.Width = 134;
			// 
			// SearchPatient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnOk;
			this.ClientSize = new System.Drawing.Size(512, 399);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lvEmployees);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchPatient";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SearchPatient";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ListView lvEmployees;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	}
}