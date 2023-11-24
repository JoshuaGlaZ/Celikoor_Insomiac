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
    public partial class FormTambahAktor: Form
    {
        public FormTambahAktor()
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
                else if (textBoxNegara.Text == "") { throw new Exception("Negara"); }
                else if (Aktor.CheckUmur(monthCalendarTanggalLahir.SelectionStart) < 3) 
                { MessageBox.Show("Umur tidak cukup"); }
                else if (radioButtonLakilaki.Checked == false && radioButtonPerempuan.Checked == false) 
                { throw new Exception("Gender"); }
                else
                {
                    Aktor c = new Aktor();
                    c.Nama = textBoxNama.Text;
                    c.NegaraAsal = textBoxNegara.Text;
                    c.TglLahir = monthCalendarTanggalLahir.SelectionStart;
                    c.Gender = radioButtonLakilaki.Checked ? "L" : "P";
                    Aktor.TambahData(c);
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
            textBoxNegara.Clear();
            monthCalendarTanggalLahir.SelectionStart = DateTime.Today;
            radioButtonLakilaki.Checked = true; radioButtonPerempuan.Checked = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
