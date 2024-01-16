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
    public partial class FormUbahKelompok : Form
    {
        public Kelompok current_kelompok;
        public FormUbahKelompok()
        {
            InitializeComponent();
        }

        private void FormUbahKelompok_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = current_kelompok.Nama;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "") { throw new Exception("Nama"); }
                Kelompok k = new Kelompok();
                k.Id = current_kelompok.Id;
                k.Nama = textBoxNama.Text;
                Kelompok.UbahData(k);
                MessageBox.Show("Data kelompok berhasil diubah");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data " + ex.Message + " belum diisi");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
