using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1204027_Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TA_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^.*/.*$", RegexOptions.IgnoreCase);
            if (regex.IsMatch(TA.Text))
            {
                epWarning.Clear();
            }
            else
            {
                epWarning.SetError(TA, "Regex Tidak Sesuai");
            }
        }

        private void PilihMatkul_Click(object sender, EventArgs e)
        {
            if ((lk.Checked == true || prm.Checked == true) && NIM.Text != "" && NAMA.Text != "" && ALAMAT.Text != "" && PROGSTU.Text != "" && TA.Text != "" && SEMESTER.Text != "")
            {
                Size = new Size(784, 639);
                if (kurikulum2006.Checked == true)
                {
                    Matkul.Enabled = true;
                    checkBox12.Enabled = false;
                    checkBox9.Enabled = false;
                }
                else if (kurikulum2010.Checked == true)
                {
                    Matkul.Enabled = true;
                    MTK.Enabled = false;
                    checkBox9.Enabled = false;
                }

                else if (kurikulum2014.Checked == true)
                {
                    Matkul.Enabled = true;
                    MTK.Enabled = false;
                    checkBox12.Enabled = false;
                }
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            string kelas = " ";
            if (MTK.Checked) { kelas += MTK.Text; }
            if (pemrograman1.Checked) { kelas += pemrograman1.Text; }
            if (checkBox10.Checked) { kelas += checkBox10.Text; }
            if (checkBox11.Checked) { kelas += checkBox11.Text; }
            if (checkBox12.Checked) { kelas += checkBox12.Text; }
            if (checkBox3.Checked) { kelas += checkBox3.Text; }
            if (checkBox4.Checked) { kelas += checkBox4.Text; }
            if (checkBox5.Checked) { kelas += checkBox5.Text; }
            if (checkBox6.Checked) { kelas += checkBox6.Text; }
            if (checkBox7.Checked) { kelas += checkBox7.Text; }
            if (checkBox8.Checked) { kelas += checkBox8.Text; }
            if (checkBox9.Checked) { kelas += checkBox9.Text; }
            string jk = lk.Checked == true ? lk.Text : prm.Text;
            string kurikulum = "";
            if (kurikulum2006.Checked) { kurikulum = kurikulum2006.Text; } else if (kurikulum2010.Checked) { kurikulum = kurikulum2010.Text; } else if (kurikulum2014.Checked) { kurikulum = kurikulum2014.Text; }
            string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", NIM.Text, NAMA.Text, jk, ALAMAT.Text, prm.Text, TA.Text, SEMESTER.Text, kurikulum, kelas);
            MessageBox.Show(message);
        }

        private void simpan_Click_1(object sender, EventArgs e)
        {
            string kelas = " ";
            if (MTK.Checked) { kelas += MTK.Text; }
            if (pemrograman1.Checked) { kelas += pemrograman1.Text; }
            if (checkBox10.Checked) { kelas += checkBox10.Text; }
            if (checkBox11.Checked) { kelas += checkBox11.Text; }
            if (checkBox12.Checked) { kelas += checkBox12.Text; }
            if (checkBox3.Checked) { kelas += checkBox3.Text; }
            if (checkBox4.Checked) { kelas += checkBox4.Text; }
            if (checkBox5.Checked) { kelas += checkBox5.Text; }
            if (checkBox6.Checked) { kelas += checkBox6.Text; }
            if (checkBox7.Checked) { kelas += checkBox7.Text; }
            if (checkBox8.Checked) { kelas += checkBox8.Text; }
            if (checkBox9.Checked) { kelas += checkBox9.Text; }
            string jk = lk.Checked == true ? lk.Text : prm.Text;
            string kurikulum = "";
            if (kurikulum2006.Checked) { kurikulum = kurikulum2006.Text; } else if (kurikulum2010.Checked) { kurikulum = kurikulum2010.Text; } else if (kurikulum2014.Checked) { kurikulum = kurikulum2014.Text; }
            string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", NIM.Text, NAMA.Text, jk, ALAMAT.Text, prm.Text, TA.Text, SEMESTER.Text, kurikulum, kelas);
            MessageBox.Show(message);
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
