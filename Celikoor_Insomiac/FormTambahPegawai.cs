using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insomiac_lib;

namespace Celikoor_Insomiac
{
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "") { throw new Exception("Nama"); }
                else if (textBoxEmail.Text == "") { throw new Exception("Email"); }
                else if (textBoxUsername.Text == "") { throw new Exception("Username"); }
                else if (textBoxPassword.Text == "") { throw new Exception("Password"); }
                else if (comboBox1.SelectedIndex == -1) { throw new Exception("Roles"); }
                else
                {
                    Pegawai p = new Pegawai(textBoxNama.Text, textBoxEmail.Text, textBoxUsername.Text, textBoxPassword.Text, comboBox1.Text);
                    Pegawai.TambahData(p);
                    MessageBox.Show("Data berhasil ditambahkan");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data "+ex+" belum diisi");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("KASIR");
            comboBox1.Items.Add("OPERATOR");
        }
    }
}
