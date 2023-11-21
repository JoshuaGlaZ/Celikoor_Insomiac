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
    public partial class FormTambahKonsumen : Form
    {
        public FormTambahKonsumen()
        {
            InitializeComponent();
        }

        private void FormTambahKonsumen_Load(object sender, EventArgs e)
        {

        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "") { throw new Exception("Nama"); }
                else if (textBoxEmail.Text == "") { throw new Exception("Email"); }
                else if (textBoxNoHp.Text == "") { throw new Exception("No Hp"); }
                else if (textBoxUsername.Text == "") { throw new Exception("Username"); }
                else if (Konsumen.CheckUmur(monthCalendarTanggalLahir.SelectionStart) < 3) 
                { MessageBox.Show("Umur tidak cukup"); }
                else if (radioButtonLakilaki.Checked == false && radioButtonPerempuan.Checked == false) 
                { throw new Exception("Gender"); }
                else if (textBoxPassword.Text != textBoxUlangiPassword.Text)
                { MessageBox.Show("Password tidak cocok"); }
                else
                {
                    Konsumen p = new Konsumen(textBoxNama.Text, textBoxEmail.Text, textBoxNoHp.Text, radioButtonPerempuan.Checked ? "P" : "L",
                        monthCalendarTanggalLahir.SelectionStart, textBoxUsername.Text, textBoxPassword.Text);
                    Konsumen.TambahData(p);
                    MessageBox.Show("Data berhasil ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data " + ex.Message + " belum diisi");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxEmail.Clear();
            textBoxNoHp.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUlangiPassword.Clear();
            monthCalendarTanggalLahir.SelectionStart = DateTime.Today;
            radioButtonLakilaki.Checked = true; radioButtonPerempuan.Checked = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
