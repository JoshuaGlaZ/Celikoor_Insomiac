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
    public partial class FormUbahPegawai : Form
    {
        public Pegawai current_pegawai;
        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            comboBoxRoles.Items.Add("ADMIN");
            comboBoxRoles.Items.Add("KASIR");
            comboBoxRoles.Items.Add("OPERATOR");
            textBoxNama.Text = current_pegawai.Nama;
            textBoxEmail.Text = current_pegawai.Email;
            textBoxUsername.Text = current_pegawai.Username;
            comboBoxRoles.Text = current_pegawai.Roles;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Pegawai p = new Pegawai();
            p.Id = current_pegawai.Id;
            p.Nama = textBoxNama.Text;
            p.Email = textBoxEmail.Text;
            p.Username = textBoxUsername.Text;
            p.Roles = comboBoxRoles.Text;
            Pegawai.UbahData(p);
            MessageBox.Show("Data pegawai berhasil diubah");
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            comboBoxRoles.SelectedIndex = -1;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
