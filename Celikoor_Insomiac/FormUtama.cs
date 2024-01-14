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
                buttonKonsumen.Visible = false;
                buttonCinema.Visible = false;
                buttonPegawai.Visible = false;
                buttonKelompok.Visible = false;
                buttonAktor.Visible = false;
                buttonGenre.Visible = false;
                buttonJenisStudio.Visible = false;
                buttonJadwalFilm.Visible = false;
                buttonStudio.Visible = false;
                buttonFilm.Visible = false;
                buttonInvoices.Visible = false;
                buttonTicket.Visible = false;
                buttonFilmStudio.Visible = false;
                buttonAktorFilm.Visible = false;
                buttonSesiFilm.Visible = false;
                buttonGenreFilm.Visible = false;
                buttonPesanTicket.Visible = true; buttonPesanTicket.Location = new Point(0, 53);
                buttonCekTiket.Visible = false;
            }
            else if (pegawaiLogin != null)
            {
                toolStripMenuItemProfile.Text = pegawaiLogin.Nama.ToUpper() + " / " + pegawaiLogin.Roles;
                if (pegawaiLogin.Roles == "ADMIN")
                {
                    buttonKonsumen.Visible = true;
                    buttonCinema.Visible = true;
                    buttonPegawai.Visible = true;
                    buttonKelompok.Visible = true;
                    buttonAktor.Visible = true;
                    buttonGenre.Visible = true;
                    buttonJenisStudio.Visible = true;
                    buttonJadwalFilm.Visible = true;
                    buttonStudio.Visible = true;
                    buttonFilm.Visible = true;
                    buttonInvoices.Visible = true;
                    buttonTicket.Visible = true;
                    buttonFilmStudio.Visible = true;
                    buttonAktorFilm.Visible = true;
                    buttonSesiFilm.Visible = true;
                    buttonGenreFilm.Visible = true;
                    buttonPesanTicket.Visible = false;
                    buttonCekTiket.Visible = true; buttonCekTiket.Location = new Point(0, 672);
                }
                else if (pegawaiLogin.Roles == "OPERATOR" || pegawaiLogin.Roles == "KASIR")
                {
                    buttonKonsumen.Visible = false;
                    buttonCinema.Visible = false;
                    buttonPegawai.Visible = false;
                    buttonKelompok.Visible = false;
                    buttonAktor.Visible = false;
                    buttonGenre.Visible = false;
                    buttonJenisStudio.Visible = false;
                    buttonJadwalFilm.Visible = false;
                    buttonStudio.Visible = false;
                    buttonFilm.Visible = false;
                    buttonInvoices.Visible = false;
                    buttonTicket.Visible = false;
                    buttonFilmStudio.Visible = false;
                    buttonAktorFilm.Visible = false;
                    buttonSesiFilm.Visible = false;
                    buttonGenreFilm.Visible = false;
                    buttonPesanTicket.Visible = false ; 
                    buttonCekTiket.Visible = true; buttonCekTiket.Location = new Point(0, 53);
                }
            }
        }

        private void timerHour_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelClock.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
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

        private void toolStripMenuItemProfile_Click(object sender, EventArgs e)
        {
            if (konsumenLogin != null)
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

        private void buttonKonsumen_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
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
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
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
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
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
        }

        private void buttonKelompok_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
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

        private void buttonAktor_Click(object sender, EventArgs e)
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

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
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

        private void buttonJenisStudio_Click(object sender, EventArgs e)
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

        private void buttonJadwalFilm_Click(object sender, EventArgs e)
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

        private void buttonStudio_Click(object sender, EventArgs e)
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

        private void buttonFilm_Click(object sender, EventArgs e)
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

        private void buttonInvoices_Click(object sender, EventArgs e)
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

        private void buttonTicket_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilmStudio_Click(object sender, EventArgs e)
        {

        }

        private void buttonAktorFilm_Click(object sender, EventArgs e)
        {

        }

        private void buttonSesiFilm_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenreFilm_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesanTicket_Click(object sender, EventArgs e)
        {
            if (konsumenLogin != null)
            {
                Form form = Application.OpenForms["FormBeliTIket"];
                if (form == null)
                {
                    FormBeliTIket beliTiket = new FormBeliTIket();
                    beliTiket.MdiParent = this;
                    beliTiket.Show();
                }
                else
                {
                    form.BringToFront();
                    form.Show();
                }
            }
        }

        private void buttonCekTiket_Click(object sender, EventArgs e)
        {

        }
        private void fILMTERLARISPERBULANSELAMA2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormLaporanFilmTerlarisPerBulan"];
                if (form == null)
                {
                    FormLaporanFilmTerlarisPerBulan laporan = new FormLaporanFilmTerlarisPerBulan();
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

        private void pEMASUKANCABANGDARIPENJUALANTIKETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormLaporanPemasukkanCabangDariPenjualanTiket"];
                if (form == null)
                {
                    FormLaporanFilmTerlarisPerBulan laporan = new FormLaporanFilmTerlarisPerBulan();
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

        private void fILMBERDASARKANJUMLAHKETIDAKHADIRANPENONTONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormLaporanFilmBerdasarkanKetidakhadiranPenonton"];
                if (form == null)
                {
                    FormLaporanFilmBerdasarkanKetidakhadiranPenonton laporan = new FormLaporanFilmBerdasarkanKetidakhadiranPenonton();
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
        private void sTUDIOBERDASARKANTINGKATUTILITASTERENDAHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormLaporanStudioBerdasarkanTingkatUtilitas"];
                if (form == null)
                {
                    FormLaporanFilmTerlarisPerBulan laporan = new FormLaporanFilmTerlarisPerBulan();
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

        private void kONSUMENBERDASARKANTONTONANGENREKOMEDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pegawaiLogin != null)
            {
                Form form = Application.OpenForms["FormLaporanKonsumenBeradasarkanGenreTontonan"];
                if (form == null)
                {
                    FormLaporanFilmTerlarisPerBulan laporan = new FormLaporanFilmTerlarisPerBulan();
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
    }
}
