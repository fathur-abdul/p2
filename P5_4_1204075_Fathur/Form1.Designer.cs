namespace P5_4_1204075_Fathur
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPKN = new System.Windows.Forms.CheckBox();
            this.cbPAI = new System.Windows.Forms.CheckBox();
            this.cbDokter = new System.Windows.Forms.CheckBox();
            this.cbLogistik = new System.Windows.Forms.CheckBox();
            this.cbMesin = new System.Windows.Forms.CheckBox();
            this.cbTI = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox1.Location = new System.Drawing.Point(255, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "FORM PENDAFTARAN";
            // 
            // textNama
            // 
            this.textNama.BackColor = System.Drawing.SystemColors.ControlText;
            this.textNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNama.ForeColor = System.Drawing.SystemColors.Window;
            this.textNama.Location = new System.Drawing.Point(371, 105);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(236, 23);
            this.textNama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(255, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.JenisKelamin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JenisKelamin.Location = new System.Drawing.Point(255, 153);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(100, 18);
            this.JenisKelamin.TabIndex = 5;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // Combo
            // 
            this.Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Combo.FormattingEnabled = true;
            this.Combo.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.Combo.Location = new System.Drawing.Point(371, 145);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(160, 26);
            this.Combo.TabIndex = 6;
            this.Combo.Text = "--Pilih Jenis Kelamin--";
            this.Combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(255, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tanggal Lahir";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Date.Location = new System.Drawing.Point(371, 196);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(170, 24);
            this.Date.TabIndex = 8;
            this.Date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPKN);
            this.groupBox1.Controls.Add(this.cbPAI);
            this.groupBox1.Controls.Add(this.cbDokter);
            this.groupBox1.Controls.Add(this.cbLogistik);
            this.groupBox1.Controls.Add(this.cbMesin);
            this.groupBox1.Controls.Add(this.cbTI);
            this.groupBox1.Location = new System.Drawing.Point(56, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cbPKN
            // 
            this.cbPKN.AutoSize = true;
            this.cbPKN.ForeColor = System.Drawing.Color.Black;
            this.cbPKN.Location = new System.Drawing.Point(7, 53);
            this.cbPKN.Name = "cbPKN";
            this.cbPKN.Size = new System.Drawing.Size(48, 17);
            this.cbPKN.TabIndex = 5;
            this.cbPKN.Text = "PKN";
            this.cbPKN.UseVisualStyleBackColor = true;
            // 
            // cbPAI
            // 
            this.cbPAI.AutoSize = true;
            this.cbPAI.ForeColor = System.Drawing.Color.Black;
            this.cbPAI.Location = new System.Drawing.Point(7, 86);
            this.cbPAI.Name = "cbPAI";
            this.cbPAI.Size = new System.Drawing.Size(142, 17);
            this.cbPAI.TabIndex = 4;
            this.cbPAI.Text = "Pendidikan Agama Islam";
            this.cbPAI.UseVisualStyleBackColor = true;
            // 
            // cbDokter
            // 
            this.cbDokter.AutoSize = true;
            this.cbDokter.ForeColor = System.Drawing.Color.Black;
            this.cbDokter.Location = new System.Drawing.Point(155, 86);
            this.cbDokter.Name = "cbDokter";
            this.cbDokter.Size = new System.Drawing.Size(58, 17);
            this.cbDokter.TabIndex = 3;
            this.cbDokter.Text = "Dokter";
            this.cbDokter.UseVisualStyleBackColor = true;
            // 
            // cbLogistik
            // 
            this.cbLogistik.AutoSize = true;
            this.cbLogistik.ForeColor = System.Drawing.Color.Black;
            this.cbLogistik.Location = new System.Drawing.Point(155, 19);
            this.cbLogistik.Name = "cbLogistik";
            this.cbLogistik.Size = new System.Drawing.Size(120, 17);
            this.cbLogistik.TabIndex = 2;
            this.cbLogistik.Text = "Manajemen Logistik";
            this.cbLogistik.UseVisualStyleBackColor = true;
            // 
            // cbMesin
            // 
            this.cbMesin.AutoSize = true;
            this.cbMesin.ForeColor = System.Drawing.Color.Black;
            this.cbMesin.Location = new System.Drawing.Point(155, 53);
            this.cbMesin.Name = "cbMesin";
            this.cbMesin.Size = new System.Drawing.Size(54, 17);
            this.cbMesin.TabIndex = 1;
            this.cbMesin.Text = "Mesin";
            this.cbMesin.UseVisualStyleBackColor = true;
            // 
            // cbTI
            // 
            this.cbTI.AutoSize = true;
            this.cbTI.ForeColor = System.Drawing.Color.Black;
            this.cbTI.Location = new System.Drawing.Point(7, 20);
            this.cbTI.Name = "cbTI";
            this.cbTI.Size = new System.Drawing.Size(114, 17);
            this.cbTI.TabIndex = 0;
            this.cbTI.Text = "Teknik Informatika";
            this.cbTI.UseVisualStyleBackColor = true;
            this.cbTI.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Location = new System.Drawing.Point(482, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 127);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbJadwal2.Location = new System.Drawing.Point(20, 52);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(159, 17);
            this.rbJadwal2.TabIndex = 3;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa & Jum\'at 10.00 - 14.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.ForeColor = System.Drawing.Color.Black;
            this.rbJadwal4.Location = new System.Drawing.Point(20, 98);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(126, 17);
            this.rbJadwal4.TabIndex = 2;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu 10.00 - 14.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbJadwal3.Location = new System.Drawing.Point(20, 75);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(151, 17);
            this.rbJadwal3.TabIndex = 1;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Rabu & Sabtu 10.00 - 14.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbJadwal1.Location = new System.Drawing.Point(20, 29);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(152, 17);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin & Kamis 10.00 - 14.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            this.rbJadwal1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(429, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Selesai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(319, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tampilkan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPKN;
        private System.Windows.Forms.CheckBox cbPAI;
        private System.Windows.Forms.CheckBox cbDokter;
        private System.Windows.Forms.CheckBox cbLogistik;
        private System.Windows.Forms.CheckBox cbMesin;
        private System.Windows.Forms.CheckBox cbTI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

