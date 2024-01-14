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
    public partial class FormBeliTIket : Form
    {
        public FormBeliTIket()
        {
            InitializeComponent();
        }

        private void FormBeliTIket_Load(object sender, EventArgs e)
        {
            List<Film> listFilm = Film.BacaData();
            comboBoxJudul.DataSource = listFilm;
            comboBoxJudul.DisplayMember = "Judul";

            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "nama_cabang";

            List<Film_Studio> listStudios = Film_Studio.BacaData(" ", " ");
            comboBoxStudio.DataSource = listStudios;
            comboBoxStudio.DisplayMember = "Studio";

            //List<Sesi_Film> listSesi = Sesi_Film.bacaData("", "");
            //comboBoxTanggal.DataSource = listSesi;
            comboBoxTanggal.DisplayMember = "tanggal";


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Studio std = (Studio)comboBoxStudio.SelectedItem;
            labelHarga.Text = std.Harga_weekday.ToString();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {

        }
    }
}
