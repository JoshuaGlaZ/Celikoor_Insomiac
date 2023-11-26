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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Konsumen k = new Konsumen();
            k.Nama = textBoxNama.Text;
            k.Email = textBoxEmail.Text;
            k.No_hp = textBoxNoHp.Text;
            k.Tgl_lahir = dateTimePickerLahir.Value;

            if (radioButtonLakiLaki.Checked)
            {
                k.Gender = "L";

            }
            else if (radioButtonPerempuan.Checked)
            {
                k.Gender = "P";
            }

            k.Username = textBoxUsername.Text;
            k.Password = textBoxPassword.Text;

            if (textBoxPassword.Text == textBoxUlangiPassword.Text)
            {
                Konsumen.TambahData(k);
                this.Owner.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password tidak cocok. Coba lagi.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }

        #region Placeholder

        private void textBoxNama_Enter(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "     Nama Lengkap     ")
            {
                textBoxNama.Text = "";
            }
            if (textBoxNama.Text != "     Nama Lengkap     ")
            {
                textBoxNama.ForeColor = Color.FromArgb(25, 34, 56);
            }
        }

        private void textBoxNama_Leave(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                textBoxNama.Text = "     Nama Lengkap     ";
                textBoxNama.ForeColor = Color.FromArgb(195, 195, 195);
            }
        }

        private void textBoxNoHp_Enter(object sender, EventArgs e)
        {
            if (textBoxNoHp.Text == "     Nomor Handphone     ")
            {
                textBoxNoHp.Text = "";
            }
            if (textBoxNoHp.Text != "     Nomor Handphone     ")
            {
                textBoxNoHp.ForeColor = Color.FromArgb(25, 34, 56);
            }
        }

        private void textBoxNoHp_Leave(object sender, EventArgs e)
        {
            if (textBoxNoHp.Text == "")
            {
                textBoxNoHp.Text = "     Nomor Handphone     ";
                textBoxNoHp.ForeColor = Color.FromArgb(195, 195, 195);
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "     Alamat Email     ")
            {
                textBoxEmail.Text = "";
            }
            if (textBoxEmail.Text != "     Alamat Email     ")
            {
                textBoxEmail.ForeColor = Color.FromArgb(25, 34, 56);
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "     Alamat Email     ";
                textBoxEmail.ForeColor = Color.FromArgb(195, 195, 195);
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "     Username     ")
            {
                textBoxUsername.Text = "";
            }
            if (textBoxUsername.Text != "     Username     ")
            {
                textBoxUsername.ForeColor = Color.FromArgb(25, 34, 56);
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "     Username     ";
                textBoxUsername.ForeColor = Color.FromArgb(195, 195, 195);
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

        private void textBoxUlangiPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxUlangiPassword.Text == "     Ulangi Password     ")
            {
                textBoxUlangiPassword.Text = "";
            }
        }

        private void textBoxUlangiPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxUlangiPassword.Text == "")
            {
                textBoxUlangiPassword.Text = "     Ulangi Password     ";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "     Password     " || textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.FromArgb(195, 195, 195);
            }

            else if (textBoxPassword.Text != "     Password     ")
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.FromArgb(25, 34, 56);
            }
        }

        private void textBoxUlangiPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUlangiPassword.Text == "     Ulangi Password     " || textBoxUlangiPassword.Text == "")
            {
                textBoxUlangiPassword.UseSystemPasswordChar = false;
                textBoxUlangiPassword.ForeColor = Color.FromArgb(195, 195, 195);
            }

            else if (textBoxUlangiPassword.Text != "     Ulangi Password     ")
            {
                textBoxUlangiPassword.UseSystemPasswordChar = true;
                textBoxUlangiPassword.ForeColor = Color.FromArgb(25, 34, 56);
            }
        }


        #endregion

        
    }
}
