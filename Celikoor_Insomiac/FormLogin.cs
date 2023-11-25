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
        FormUtama frm;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Konsumen k = Konsumen.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
            Pegawai p = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

            if (k != null || p != null)
            {
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

        #region Placeholder

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "     Username     ")
            {
                textBoxUsername.Text = "";
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "     Username     ";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "     Password     ")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "     Password     ";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "     Password     " || textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }

            else if (textBoxPassword.Text != "     Password     ")
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        #endregion

        
    }
}
