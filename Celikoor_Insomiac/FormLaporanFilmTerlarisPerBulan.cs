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
    public partial class FormLaporanFilmTerlarisPerBulan : Form
    {
        List<LaporanFilmLaris> listLaporan = new List<LaporanFilmLaris>();
        public FormLaporanFilmTerlarisPerBulan()
        {
            InitializeComponent();
        }

        private void FormLaporanFilmTerlarisPerBulan_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listLaporan = LaporanFilmLaris.BacaData();
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "Bulan")
            {
                textBoxCari.Visible = false;
                comboBoxBulan.Visible = true;
            }
            else
            {
                textBoxCari.Visible = true;
                comboBoxBulan.Visible = false;
            }
        }
        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace("Jumlah Penonton", "COUNT(t.films_id)").Replace("Bulan", "MONTHNAME(jf.tanggal)"); ;
            string nilai = kriteria == "MONTHNAME(jf.tanggal)" ? comboBoxBulan.Text : textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace("Jumlah Penonton", "COUNT(t.films_id) DESC").Replace("Bulan", "MONTHNAME(jf.tanggal)"); ;
            listLaporan = LaporanFilmLaris.BacaData(kriteria, nilai, order);
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

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);

        }
    }
}
