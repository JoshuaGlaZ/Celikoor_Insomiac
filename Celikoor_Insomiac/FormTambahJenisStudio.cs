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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }


        private void FormTambahJenisStudio_Load(object sender, EventArgs e)
        {
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxDeskripsi.Clear();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            JenisStudio js = new JenisStudio();
            js.Nama = textBoxNama.Text;
            js.Deskripsi = textBoxDeskripsi.Text;
            JenisStudio.TambahData(js);
            MessageBox.Show("Data jenis kelompok berhasil ditambahkan");
        }
    }
}
