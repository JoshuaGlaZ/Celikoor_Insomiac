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
    public partial class FormLaporanPemasukkanCabangDariPenjualanTiket : Form
    {
        List<LaporanPenjualanTiketCabang> listLaporan = new List<LaporanPenjualanTiketCabang>();
        public FormLaporanPemasukkanCabangDariPenjualanTiket()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporanPemasukkanCabangDariPenjualanTiket_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listLaporan = LaporanPenjualanTiketCabang.BacaData();
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace("Nama Cabang", "nama_cabang").Replace("Total Penjualan","TotalPenjualan");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text;
            listLaporan = LaporanPenjualanTiketCabang.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            LaporanPenjualanTiketCabang.CetakLaporan(listLaporan);
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            comboBoxUrut_SelectedIndexChanged(sender, e);
        }
    }
}
