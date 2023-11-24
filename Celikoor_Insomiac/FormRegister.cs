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
            FormLogin frm = (FormLogin)this.Owner;

            Konsumen k = new Konsumen();
            k.Nama = textBoxNama.Text;
            k.Email = textBoxEmail.Text;
            k.No_hp = textBoxNoHp.Text;
            k.Tgl_lahir = dateTimePicker1.Value;
            if (radioButtonLakiLaki.Checked)
            {
                k.Gender = "Laki Laki";
                
            }
            else if (radioButtonPerempuan.Checked)
            {
                k.Gender = "Perempuan";
            }

            k.Username= textBoxUsername.Text;
            k.Password= textBoxPassword.Text;

            if(textBoxPassword.Text == textBoxUlangiPassword.Text)
            {
                Konsumen.TambahData(k);
                frm.Visible = true;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Password Salah");
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
