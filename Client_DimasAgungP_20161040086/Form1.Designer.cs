namespace Client_DimasAgungP_20161040086
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pertama = new System.Windows.Forms.TextBox();
            this.tb_kedua = new System.Windows.Forms.TextBox();
            this.btn_hasil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.penjumlahan = new System.Windows.Forms.Label();
            this.pengurangan = new System.Windows.Forms.Label();
            this.perkalian = new System.Windows.Forms.Label();
            this.pembagian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka 2";
            // 
            // tb_pertama
            // 
            this.tb_pertama.Location = new System.Drawing.Point(268, 117);
            this.tb_pertama.Name = "tb_pertama";
            this.tb_pertama.Size = new System.Drawing.Size(100, 22);
            this.tb_pertama.TabIndex = 2;
            // 
            // tb_kedua
            // 
            this.tb_kedua.Location = new System.Drawing.Point(268, 164);
            this.tb_kedua.Name = "tb_kedua";
            this.tb_kedua.Size = new System.Drawing.Size(100, 22);
            this.tb_kedua.TabIndex = 3;
            // 
            // btn_hasil
            // 
            this.btn_hasil.Location = new System.Drawing.Point(324, 273);
            this.btn_hasil.Name = "btn_hasil";
            this.btn_hasil.Size = new System.Drawing.Size(75, 23);
            this.btn_hasil.TabIndex = 4;
            this.btn_hasil.Text = "Hasil";
            this.btn_hasil.UseVisualStyleBackColor = true;
            this.btn_hasil.Click += new System.EventHandler(this.btn_hasil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasil Penjumlahan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil Pengurangan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasil Perkalian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hasil Pembagian";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // penjumlahan
            // 
            this.penjumlahan.AutoSize = true;
            this.penjumlahan.Location = new System.Drawing.Point(685, 116);
            this.penjumlahan.Name = "penjumlahan";
            this.penjumlahan.Size = new System.Drawing.Size(0, 17);
            this.penjumlahan.TabIndex = 9;
            // 
            // pengurangan
            // 
            this.pengurangan.AutoSize = true;
            this.pengurangan.Location = new System.Drawing.Point(688, 163);
            this.pengurangan.Name = "pengurangan";
            this.pengurangan.Size = new System.Drawing.Size(0, 17);
            this.pengurangan.TabIndex = 10;
            // 
            // perkalian
            // 
            this.perkalian.AutoSize = true;
            this.perkalian.Location = new System.Drawing.Point(688, 201);
            this.perkalian.Name = "perkalian";
            this.perkalian.Size = new System.Drawing.Size(0, 17);
            this.perkalian.TabIndex = 11;
            // 
            // pembagian
            // 
            this.pembagian.AutoSize = true;
            this.pembagian.Location = new System.Drawing.Point(688, 237);
            this.pembagian.Name = "pembagian";
            this.pembagian.Size = new System.Drawing.Size(0, 17);
            this.pembagian.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pembagian);
            this.Controls.Add(this.perkalian);
            this.Controls.Add(this.pengurangan);
            this.Controls.Add(this.penjumlahan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_hasil);
            this.Controls.Add(this.tb_kedua);
            this.Controls.Add(this.tb_pertama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pertama;
        private System.Windows.Forms.TextBox tb_kedua;
        private System.Windows.Forms.Button btn_hasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label penjumlahan;
        private System.Windows.Forms.Label pengurangan;
        private System.Windows.Forms.Label perkalian;
        private System.Windows.Forms.Label pembagian;
    }
}

