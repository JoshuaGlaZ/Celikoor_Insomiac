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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "") { throw new Exception("Nama"); }
                else if (textBoxDeskripsi.Text == "") { throw new Exception("Deskripsi"); }
                else
                {
                    Genre newGenre = new Genre();
                    newGenre.NamaGenre = textBoxNama.Text;
                    newGenre.Deskripsi = textBoxDeskripsi.Text;
                    Genre.TambahData(newGenre);
                    MessageBox.Show("Data berhasil ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data " + ex.Message + " belum diisi");
            }
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
    }
}
