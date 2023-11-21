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
    public partial class FormUbahCinema : Form
    {
        public Cinema cinemaUbah; 
        public FormUbahCinema()
        {
            InitializeComponent();
        }

        private void FormUbahCinema_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = cinemaUbah.Nama_cabang;
            textBoxAlamat.Text = cinemaUbah.Alamat;
            dateTimePickerTanggalDibuka.Value = cinemaUbah.Tgl_buka;
            textBoxKota.Text = cinemaUbah.Kota;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Cinema c = new Cinema();
            c.Id = cinemaUbah.Id;
            c.Nama_cabang = textBoxNama.Text;
            c.Alamat = textBoxAlamat.Text;
            c.Tgl_buka = dateTimePickerTanggalDibuka.Value;
            c.Kota = textBoxKota.Text;
            Cinema.UbahData(c);
            MessageBox.Show("Data Cinema berhasil diubah");
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxAlamat.Clear();
            textBoxKota.Clear();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
