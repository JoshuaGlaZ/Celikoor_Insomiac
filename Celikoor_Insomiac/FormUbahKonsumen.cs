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
    public partial class FormUbahKonsumen : Form
    {
        public Konsumen konsumenUbah; 
        public FormUbahKonsumen()
        {
            InitializeComponent();
        }

        private void FormUbahKonsumen_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = konsumenUbah.Nama;
            textBoxEmail.Text = konsumenUbah.Email;
            textBoxNoHp.Text = konsumenUbah.No_hp;
            textBoxUsername.Text = konsumenUbah.Username;
            monthCalendarTanggalLahir.SelectionStart = konsumenUbah.Tgl_lahir;
            radioButtonLakilaki.Checked = konsumenUbah.Gender == "L" ? true : false;
            radioButtonPerempuan.Checked = konsumenUbah.Gender == "P" ? true : false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Konsumen k = new Konsumen();
            k.Id = konsumenUbah.Id; 
            k.Nama = textBoxNama.Text;
            k.Email = textBoxEmail.Text;
            k.No_hp = textBoxNoHp.Text;
            k.Username = textBoxUsername.Text;
            k.Tgl_lahir = monthCalendarTanggalLahir.SelectionStart;
            k.Gender = radioButtonLakilaki.Checked ? "L" : "P";
            Konsumen.UbahData(k);
            MessageBox.Show("Data konsumen berhasil diubah");
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxEmail.Clear();
            textBoxNoHp.Clear();
            textBoxUsername.Clear();
            monthCalendarTanggalLahir.SelectionStart = DateTime.Today;
            radioButtonLakilaki.Checked = true; radioButtonPerempuan.Checked = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
