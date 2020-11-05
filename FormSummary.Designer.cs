namespace Projek_3
{
    partial class FormSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.tglsummary = new System.Windows.Forms.DateTimePicker();
            this.Proses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tgl. Akhir Bulan";
            // 
            // tglsummary
            // 
            this.tglsummary.CustomFormat = " ";
            this.tglsummary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglsummary.Location = new System.Drawing.Point(222, 84);
            this.tglsummary.Name = "tglsummary";
            this.tglsummary.Size = new System.Drawing.Size(108, 20);
            this.tglsummary.TabIndex = 11;
            this.tglsummary.ValueChanged += new System.EventHandler(this.tglsummary_ValueChanged);
            this.tglsummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tglsummary_KeyDown);
            // 
            // Proses
            // 
            this.Proses.Location = new System.Drawing.Point(216, 144);
            this.Proses.Name = "Proses";
            this.Proses.Size = new System.Drawing.Size(75, 23);
            this.Proses.TabIndex = 13;
            this.Proses.Text = "Proses";
            this.Proses.UseVisualStyleBackColor = true;
            this.Proses.Click += new System.EventHandler(this.Proses_Click);
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.Proses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tglsummary);
            this.Name = "FormSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tglsummary;
        private System.Windows.Forms.Button Proses;

    }
}