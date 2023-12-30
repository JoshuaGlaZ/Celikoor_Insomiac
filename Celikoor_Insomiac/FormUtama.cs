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
    public partial class FormUtama : Form
    {
        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();

                Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(152, 204, 211);
                FormLogin login = new FormLogin();
                login.Owner = this;
                login.ShowDialog();
                this.WindowState = FormWindowState.Maximized;

                Akses();

                timerHour_Tick(sender, e);
                Timer hour = new Timer();
                hour.Interval = (1000);
                hour.Tick += new EventHandler(timerHour_Tick);
                hour.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Tidak dapat terhubung ke database" +
                                "\nError : " + ex.Message, "PERINGATAN!!!");
                Application.Exit();
            }
        }

        private void Akses()
        {

            if (konsumenLogin != null)
            {
                toolStripMenuItemProfile.Text = konsumenLogin.Nama.ToUpper();
                cinemaToolStripMenuItem.Visible = false;
                pegawaiToolStripMenuItem.Visible = false;
                kelompokToolStripMenuItem.Visible = false;
                konsumenToolStripMenuItem.Visible = false;
                aktorToolStripMenuItem.Visible = false;
                genreToolStripMenuItem.Visible = false;
                studioToolStripMenuItem.Visible = false;
                jenisStudioToolStripMenuItem.Visible = false;
                jadwalFilmToolStripMenuItem.Visible = false;
                filmToolStripMenuItem.Visible = false;
                invoicesToolStripMenuItem.Visible = false;
                pemesananTiketToolStripMenuItem.Visible = true;
                laporanToolStripMenuItem.Visible = false;
            }
            else if (pegawaiLogin != null)
            {
                toolStripMenuItemProfile.Text = pegawaiLogin.Nama.ToUpper() + " / " + pegawaiLogin.Roles;
                if (pegawaiLogin.Roles == "ADMIN")
                {
                    cinemaToolStripMenuItem.Visible = true;
                    pegawaiToolStripMenuItem.Visible = true;
                    kelompokToolStripMenuItem.Visible = true;
                    konsumenToolStripMenuItem.Visible = true;
                    aktorToolStripMenuItem.Visible = true;
                    genreToolStripMenuItem.Visible = true;
                    studioToolStripMenuItem.Visible = true;
                    jenisStudioToolStripMenuItem.Visible = true;
                    jadwalFilmToolStripMenuItem.Visible = true;
                    filmToolStripMenuItem.Visible = true;
                    invoicesToolStripMenuItem.Visible = true;
                    pemesananTiketToolStripMenuItem.Visible = false;
                    laporanToolStripMenuItem.Visible = true;
                }
                else if (pegawaiLogin.Roles == "OPERATOR")
                {
                    cinemaToolStripMenuItem.Visible = false;
                    pegawaiToolStripMenuItem.Visible = false;
                    kelompokToolStripMenuItem.Visible = false;
                    konsumenToolStripMenuItem.Visible = false;
                    aktorToolStripMenuItem.Visible = false;
                    genreToolStripMenuItem.Visible = false;
                    studioToolStripMenuItem.Visible = false;
                    jenisStudioToolStripMenuItem.Visible = false;
                    jadwalFilmToolStripMenuItem.Visible = false;
                    filmToolStripMenuItem.Visible = false;
                    invoicesToolStripMenuItem.Visible = false;
                    pemesananTiketToolStripMenuItem.Visible = false;
                    laporanToolStripMenuItem.Visible = false;
                }
                else if (pegawaiLogin.Roles == "KASIR")
                {
                    cinemaToolStripMenuItem.Visible = false;
                    pegawaiToolStripMenuItem.Visible = false;
                    kelompokToolStripMenuItem.Visible = false;
                    konsumenToolStripMenuItem.Visible = false;
                    aktorToolStripMenuItem.Visible = false;
                    genreToolStripMenuItem.Visible = false;
                    studioToolStripMenuItem.Visible = false;
                    jenisStudioToolStripMenuItem.Visible = false;
                    jadwalFilmToolStripMenuItem.Visible = false;
                    filmToolStripMenuItem.Visible = false;
                    invoicesToolStripMenuItem.Visible = true;
                    pemesananTiketToolStripMenuItem.Visible = false;
                    laporanToolStripMenuItem.Visible = false;
                }
            }
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterKonsumen"];
            if (form == null)
            {
                FormMasterKonsumen konsumen = new FormMasterKonsumen();
                konsumen.MdiParent = this;
                konsumen.Show();
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

        private void timerHour_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelClock.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(konsumenLogin != null)
            {
                Form form = Application.OpenForms["FormProfileKonsumen"];
                if (form == null)
                {
                    FormProfileKonsumen kelompok = new FormProfileKonsumen();
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

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormMasterGenre"];
                if (form == null)
                {
                    FormMasterGenre kelompok = new FormMasterGenre();
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

        private void aktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormMasterAktor"];
                if (form == null)
                {
                    FormMasterAktor kelompok = new FormMasterAktor();
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

        private void jadwalFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormPenjadwalanFilm"];
                if (form == null)
                {
                    FormPenjadwalanFilm jadwal = new FormPenjadwalanFilm();
                    jadwal.MdiParent = this;
                    jadwal.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormMasterFilm"];
                if (form == null)
                {
                    FormMasterFilm jadwal = new FormMasterFilm();
                    jadwal.MdiParent = this;
                    jadwal.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormMasterInvoice"];
                if (form == null)
                {
                    FormMasterInvoice jadwal = new FormMasterInvoice();
                    jadwal.MdiParent = this;
                    jadwal.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void jenisStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormMasterJenisStudio"];
                if (form == null)
                {
                    FormMasterJenisStudio jadwal = new FormMasterJenisStudio();
                    jadwal.MdiParent = this;
                    jadwal.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormMasterStudio"];
                if (form == null)
                {
                    FormMasterStudio jadwal = new FormMasterStudio();
                    jadwal.MdiParent = this;
                    jadwal.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void pemesananTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (konsumenLogin != null)
            {
                Form form = Application.OpenForms["FormBeliTiket"];
                if (form == null)
                {
                    FormBeliTIket beliTiket = new FormBeliTIket();
                    beliTiket.MdiParent = this;
                    beliTiket.StartPosition = FormStartPosition.CenterParent;
                    beliTiket.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void laporanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormLaporan"];
                if (form == null)
                {
                    FormLaporan laporan = new FormLaporan();
                    laporan.MdiParent = this;
                    laporan.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konsumenLogin = null;
            pegawaiLogin = null;

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            this.Hide();
            FormLogin login = new FormLogin();
            login.Owner = this;
            login.FormClosed += (l, args) => this.Show();
            login.ShowDialog();
            Akses();
        }
    }
}
