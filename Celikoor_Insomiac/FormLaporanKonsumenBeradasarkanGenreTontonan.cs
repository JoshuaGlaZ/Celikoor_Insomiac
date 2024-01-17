using Insomiac_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Insomiac
{
    public partial class FormLaporanKonsumenBeradasarkanGenreTontonan : Form
    {
        List<LaporanGenreTontonanKonsumen> listLaporan = new List<LaporanGenreTontonanKonsumen>();
        public FormLaporanKonsumenBeradasarkanGenreTontonan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporanKonsumenBeradasarkanGenreTontonan_Load(object sender, EventArgs e)
        {
            List<Genre> listGenre = Genre.BacaData();
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "nama";

            this.MinimumSize = this.Size;
            comboBoxGenre.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listLaporan = LaporanGenreTontonanKonsumen.BacaData();
            dataGridViewHasil.DataSource = listLaporan;
        
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterPencarian();
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterPencarian();
        }

        private void filterPencarian()
        {
            string nilai = comboBoxGenre.SelectedItem.ToString();
            string order = comboBoxUrut.SelectedItem.ToString();
            listLaporan = LaporanGenreTontonanKonsumen.BacaData(nilai, order);
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            LaporanGenreTontonanKonsumen.CetakLaporan(listLaporan);
        }
    }
}
