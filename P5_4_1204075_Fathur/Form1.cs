using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1204075_Fathur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
        {
                    jadwal = "Senin & Kamis 10.00 - 14.00";
        }
            else if (rbJadwal2.Checked)
        {
                    jadwal = "Selasa & Jum'at 10.00 - 14.00";
        }
            else if (rbJadwal3.Checked)
        {
                    jadwal = "Rabu & Sabtu 10.00 - 14.00";
        }
            else if (rbJadwal4.Checked)
        {
                     jadwal = "Minggu 10.00 - 14.00";
        }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string kelas = "";

            if (cbTI.Checked)
            {
                kelas = kelas + "Teknik Informatika, ";
            }
            if (cbLogistik.Checked)
            {
                kelas = kelas + "Logistik, ";
            }
            if (cbMesin.Checked)
            {
                kelas = kelas + "Mesin, ";
            }
            if (cbPKN.Checked)
            {
                kelas = kelas + "PKN, ";
            }
            if (cbPAI.Checked)
            {
                kelas = kelas + "PAI, ";
            }
            if (cbDokter.Checked)
            {
                kelas = kelas + "Dokter, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus Memilih salah satu dari plihan kelas", "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Nama : " + textNama.Text +
                "\nJenis Kelamin : " + Combo.Text +
                "\nTanggal Lahir : " + Date.Text +
                "\nPilihan Kelas : " + cbDokter.Text +
                "\nPilihan Jadwal : " + rbJadwal2.Text,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
                    
