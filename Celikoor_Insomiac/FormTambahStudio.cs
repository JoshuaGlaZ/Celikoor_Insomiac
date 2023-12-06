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
    public partial class FormTambahStudio : Form
    {
        public FormTambahStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Studio s = new Studio();
            s.Nama = textBoxNama.Text;
            s.Kapasitas = (int)numericUpDownKapasitas.Value;
            s.Jenis = (JenisStudio)comboBoxJenisStudio.SelectedItem;
            s.Bioskop = (Cinema)comboBoxCinema.SelectedItem;
            s.Harga_weekday = int.Parse(textBoxHargaWeekday.Text);
            s.Harga_weekend = int.Parse(textBoxHargaWeekend.Text);
            Studio.MasukanData(s);
            MessageBox.Show("data berhasil ditambahkan");
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {
            comboBoxCinema.DataSource = Cinema.BacaData();
            comboBoxCinema.DisplayMember = "nama_cabang";
            comboBoxCinema.SelectedIndex = -1;

            comboBoxJenisStudio.DataSource = JenisStudio.BacaData();
            comboBoxJenisStudio.DisplayMember = "nama";
            comboBoxJenisStudio.SelectedIndex = -1;
        }
    }
}
