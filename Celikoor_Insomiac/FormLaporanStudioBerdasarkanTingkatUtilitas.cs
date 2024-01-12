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
    public partial class FormLaporanStudioBerdasarkanTingkatUtilitas : Form
    {
        List<LaporanTingkatUtilitasStudio> listLaporan = new List<LaporanTingkatUtilitasStudio>();
        public FormLaporanStudioBerdasarkanTingkatUtilitas()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporanStudioBerdasarkanTingkatUtilitas_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxBulan.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listLaporan = LaporanTingkatUtilitasStudio.BacaData();
            dataGridViewHasil.DataSource = listLaporan;
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterPencarian()

        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterPencarian()
        }

        private void filterPencarian()
        {
            string bulan = comboBoxBulan.SelectedItem.ToString();
            string order = comboBoxUrut.SelectedItem.ToString();
            listLaporan = LaporanTingkatUtilitasStudio.BacaData();
            dataGridViewHasil.DataSource = listLaporan;

        }
    }
}
