namespace Projek_3
{
    partial class Form2
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
            this.namabarang = new System.Windows.Forms.TextBox();
            this.tglmasuk = new System.Windows.Forms.DateTimePicker();
            this.simpan = new System.Windows.Forms.Button();
            this.kodebarang = new System.Windows.Forms.TextBox();
            this.jenisbarang = new System.Windows.Forms.TextBox();
            this.jumlahbarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namabarang
            // 
            this.namabarang.Location = new System.Drawing.Point(337, 112);
            this.namabarang.Name = "namabarang";
            this.namabarang.Size = new System.Drawing.Size(176, 20);
            this.namabarang.TabIndex = 2;
            // 
            // tglmasuk
            // 
            this.tglmasuk.CustomFormat = " ";
            this.tglmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglmasuk.Location = new System.Drawing.Point(337, 86);
            this.tglmasuk.Name = "tglmasuk";
            this.tglmasuk.Size = new System.Drawing.Size(102, 20);
            this.tglmasuk.TabIndex = 1;
            this.tglmasuk.ValueChanged += new System.EventHandler(this.tglmasuk_ValueChanged);
            this.tglmasuk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tglmasuk_KeyDown);
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(347, 217);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(75, 23);
            this.simpan.TabIndex = 5;
            this.simpan.Text = "simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click_1);
            // 
            // kodebarang
            // 
            this.kodebarang.Location = new System.Drawing.Point(337, 60);
            this.kodebarang.Name = "kodebarang";
            this.kodebarang.Size = new System.Drawing.Size(52, 20);
            this.kodebarang.TabIndex = 0;
            // 
            // jenisbarang
            // 
            this.jenisbarang.Location = new System.Drawing.Point(337, 138);
            this.jenisbarang.Name = "jenisbarang";
            this.jenisbarang.Size = new System.Drawing.Size(176, 20);
            this.jenisbarang.TabIndex = 3;
            // 
            // jumlahbarang
            // 
            this.jumlahbarang.Location = new System.Drawing.Point(337, 164);
            this.jumlahbarang.Name = "jumlahbarang";
            this.jumlahbarang.Size = new System.Drawing.Size(176, 20);
            this.jumlahbarang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tgl. Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jenis Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jumlah Barang";
            // 
            // btnSummary
            // 
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSummary.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(616, 27);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(83, 27);
            this.btnSummary.TabIndex = 12;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(747, 424);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jumlahbarang);
            this.Controls.Add(this.jenisbarang);
            this.Controls.Add(this.kodebarang);
            this.Controls.Add(this.tglmasuk);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.namabarang);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox namabarang;
        private System.Windows.Forms.DateTimePicker tglmasuk;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox kodebarang;
        private System.Windows.Forms.TextBox jenisbarang;
        private System.Windows.Forms.TextBox jumlahbarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSummary;
    }
}