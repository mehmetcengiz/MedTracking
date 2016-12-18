namespace MedTrackingGui
{
    partial class NewSale
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
            this.btnSaveSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveSale
            // 
            this.btnSaveSale.Location = new System.Drawing.Point(263, 280);
            this.btnSaveSale.Name = "btnSaveSale";
            this.btnSaveSale.Size = new System.Drawing.Size(91, 30);
            this.btnSaveSale.TabIndex = 0;
            this.btnSaveSale.Text = "Save Sale";
            this.btnSaveSale.UseVisualStyleBackColor = true;
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 322);
            this.Controls.Add(this.btnSaveSale);
            this.Name = "NewSale";
            this.Text = "NewSale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSale;
    }
}