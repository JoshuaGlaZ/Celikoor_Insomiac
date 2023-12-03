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
using Insomiac_lib;

namespace Celikoor_Insomiac
{
    public partial class FormProfileKonsumen : Form
    {
        public FormProfileKonsumen()
        {
            InitializeComponent();
        }
        Konsumen user;
        FormUtama frm;

        private void FormProfileKonsumen_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent; 
            user = frm.konsumenLogin;
            labelUsername.Text = user.Username;
            labelNama.Text = user.Nama;
            labelTgl.Text = user.Tgl_lahir.ToString("dddd, dd MMMM yyyy");
            labelEmail.Text = user.Email;
            labelHP.Text = user.No_hp;
            labelKelamin.Text = user.Gender == "L" ? "Laki-laki" : "Perempuan"; 
            labelSaldo.Text = user.Saldo.ToString();

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
