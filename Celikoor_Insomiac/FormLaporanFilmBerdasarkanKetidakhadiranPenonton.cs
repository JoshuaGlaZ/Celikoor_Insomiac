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
    public partial class FormLaporanFilmBerdasarkanKetidakhadiranPenonton : Form
    {
        List<LaporanFilmKetidakhadiranPenonton> listLaporan = new List<LaporanFilmKetidakhadiranPenonton>();
        public FormLaporanFilmBerdasarkanKetidakhadiranPenonton()
        {
            InitializeComponent();
        }

        private void FormLaporanFilmBerdasarkanBanyakKetidakhadiranPenonton_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listLaporan = LaporanFilmKetidakhadiranPenonton.BacaData();
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace("Jumlah Ketidakhadiran Penonton", "COUNT(t.films_id)");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace("Jumlah Ketidakhadiran Penonton", "COUNT(t.films_id) DESC");
            listLaporan = LaporanFilmKetidakhadiranPenonton.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
