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
    public partial class FormUbahAktor : Form
    {
        public Aktor aktorUbah; 
        public FormUbahAktor()
        {
            InitializeComponent();
        }

        private void FormUbahKonsumen_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = aktorUbah.Nama;
            textBoxNegara.Text = aktorUbah.NegaraAsal;
            monthCalendarTanggalLahir.SelectionStart = aktorUbah.TglLahir;
            radioButtonLakilaki.Checked = aktorUbah.Gender == "L" ? true : false;
            radioButtonPerempuan.Checked = aktorUbah.Gender == "P" ? true : false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            aktorUbah.Nama = textBoxNama.Text;
            aktorUbah.NegaraAsal = textBoxNegara.Text;
            aktorUbah.TglLahir = monthCalendarTanggalLahir.SelectionStart;
            aktorUbah.Gender = radioButtonLakilaki.Checked ? "L" : "P";
            Aktor.UbahData(aktorUbah);
            MessageBox.Show("Data konsumen berhasil diubah");
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxNegara.Clear();
            monthCalendarTanggalLahir.SelectionStart = DateTime.Today;
            radioButtonLakilaki.Checked = true; radioButtonPerempuan.Checked = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonLakilaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonKosongi_Click_1(object sender, EventArgs e)
        {

        }
    }
}
