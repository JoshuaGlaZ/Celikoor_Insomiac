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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Konsumen k = Konsumen.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
            Pegawai p = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

            if (k != null || p != null)
            {
                FormUtama frm = (FormUtama)this.Owner;
                frm.Visible = true;
                frm.konsumenLogin = k;
                frm.pegawaiLogin = p;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login tidak valid, silahkan coba lagi", "Konfirmasi");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelREgister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Owner= this;
            this.Visible = false;
            register.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
        }
    }
}
