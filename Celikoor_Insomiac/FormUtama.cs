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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(152, 204, 211);
            FormLogin login = new FormLogin();
            login.Owner = this;
            login.ShowDialog();
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterKonsumen"];
            if (form == null)
            {
                FormMasterKonsumen cinema = new FormMasterKonsumen();
                cinema.MdiParent = this;
                cinema.Show();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterCinema"];
            if (form == null)
            {
                FormMasterCinema cinema = new FormMasterCinema();
                cinema.MdiParent = this;
                cinema.Show();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterPegawai"];
            if (form == null)
            {
                FormMasterPegawai pegawai = new FormMasterPegawai();
                pegawai.MdiParent = this;
                pegawai.Show();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
        }

        private void kelompokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterKelompok"];
            if (form == null)
            {
                FormMasterKelompok kelompok = new FormMasterKelompok();
                kelompok.MdiParent = this;
                kelompok.Show();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
        }
    }
}
