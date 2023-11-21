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
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "") { throw new Exception("Nama"); }
                else if (textBoxAlamat.Text == "") { throw new Exception("Email"); }
                else if (textBoxKota.Text == "") { throw new Exception("Kota"); }
                else
                {
                    Cinema c = new Cinema(textBoxNama.Text, textBoxAlamat.Text,
                        dateTimePickerTanggalDibuka.Value, textBoxKota.Text);
                    Cinema.TambahData(c);
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
            textBoxAlamat.Clear();
            textBoxKota.Clear();
            dateTimePickerTanggalDibuka.Value = DateTime.Now;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahCinema_Load(object sender, EventArgs e)
        {

        }
    }
}
