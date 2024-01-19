using Insomiac_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Insomiac
{
    public partial class FormBeliTIket : Form
    {
        FormUtama mainForm;
        List<Cinema> listCinema = new List<Cinema>();
        List<string> listKodeKursi = new List<string>();
        List<string> listKodeKursiTaken = new List<string>();

        bool isFrozen = true; 
        public FormBeliTIket()
        {
            InitializeComponent();
        }

        private void FormBeliTIket_Load(object sender, EventArgs e)
        {
            mainForm = (FormUtama)this.MdiParent; 
            List<Film> listFilm = Film.BacaData();
            labelComingSoon.Visible = false; 
            comboBoxJudul.DataSource = listFilm;
            comboBoxJudul.DisplayMember = "Judul";
            labelSaldo.Text = mainForm.konsumenLogin.Saldo.ToString(); 
            isFrozen = true;

            pictureBoxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPoster.Image = null;

            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox == true)
                {
                    CheckBox checkbox = (CheckBox)control;

                    checkbox.Checked = false;
                    checkbox.Visible = false;
                }
            }
        }

        private void buttonPembayaran_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Tanggal = DateTime.Now;
            invoice.Grand_total = int.Parse(labelTotalAkhir.Text);
            invoice.Diskon_nominal = int.Parse(labelDiskon.Text);
            invoice.Pelanggan = mainForm.konsumenLogin; 
            foreach(string nomorKursi in listKodeKursi)
            {
                invoice.AddTicket(nomorKursi, double.Parse(labelHarga.Text), (JadwalFilm)comboBoxTanggal.SelectedItem, (Studio)comboBoxStudio.SelectedItem, (Film)comboBoxJudul.SelectedItem); 
            }
            if(mainForm.konsumenLogin.Saldo >= double.Parse(labelTotalAkhir.Text))
            {
                Invoice.CreateInvoice(invoice);
                MessageBox.Show("Transaksi Berhasil");
                mainForm.konsumenLogin.Saldo -= double.Parse(labelTotalAkhir.Text);
                Konsumen.UbahData(mainForm.konsumenLogin);
            }
            else
            {
                MessageBox.Show("Saldo Anda Tidak Cukup");
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Studio std = (Studio)comboBoxStudio.SelectedItem;
            DateTime today = DateTime.Now;
            labelTIPE.Text = std.Jenis.ToString();
            labelKursi.Text = std.Kapasitas.ToString() + " Kursi";
            listKodeKursiTaken = Invoice.BacaKursi((JadwalFilm)comboBoxTanggal.SelectedItem, (Film)comboBoxJudul.SelectedItem, (Studio)comboBoxStudio.SelectedItem);
            if(today.DayOfWeek == DayOfWeek.Sunday || today.DayOfWeek == DayOfWeek.Saturday)
            {
                labelHarga.Text = std.Harga_weekend.ToString();
            }
            else
            {
                labelHarga.Text = std.Harga_weekday.ToString();
            }

            UpdateKursi();
            isFrozen = true; 
            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)control;
                    if(checkbox.Visible)
                    {
                        foreach (string kodeKursi in listKodeKursiTaken)
                        {
                            if(checkbox.Name == ConvertKodeKursi(kodeKursi))
                            {
                                checkbox.Checked = true;
                                checkbox.Enabled = false; 
                            }
                        }
                    }
                }
            }
            isFrozen = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTanggal_SelectedIndexChanged(object sender, EventArgs e)
        {
            JadwalFilm jadwalFilm = (JadwalFilm)comboBoxTanggal.SelectedItem;
            listCinema.Clear();
            comboBoxStudio.Items.Clear();

            List<string> listNamaBioskop = new List<string>();
            foreach(Film_Studio fs in jadwalFilm.ListFS)
            {
                if(!(listNamaBioskop).Contains(fs.Std.Bioskop.Nama_cabang))
                {
                    listNamaBioskop.Add(fs.Std.Bioskop.Nama_cabang);
                    listCinema.Add(fs.Std.Bioskop); 
                }
            }
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
            comboBoxCinema_SelectionChangeCommitted(sender, e);
        }
        public string ConvertNumberKursi(string nomorKursi)
        {
            string kodeKursi = "";
            int urutanKursi = int.Parse(nomorKursi.Substring(7));
            if(urutanKursi%12 > 0 && urutanKursi%12 <= 4)
            {
                kodeKursi += "A";
            }
            else if(urutanKursi % 12 > 4 && urutanKursi%12 <= 8)
            {
                kodeKursi += "B";
            }
            else if(urutanKursi % 12 == 0 || urutanKursi % 12 > 8 && urutanKursi % 12 <= 11)
            {
                kodeKursi += "C";
            }
            int nomorKelompok = urutanKursi % 4; 
            if(nomorKelompok == 0)
            {
                nomorKelompok = 4; 
            }
            int baris = (int)(Math.Floor((urutanKursi - 0.1)/ 12.0));
            kodeKursi += (nomorKelompok + 4 * baris).ToString();
            return kodeKursi; 
            
        }
        public void UpdateKursi()
        {
            Studio studio = (Studio)comboBoxStudio.SelectedItem;
            int jumlahKursi = studio.Kapasitas;
            isFrozen = true;
            List<CheckBox> checkBoxList = new List<CheckBox>();

            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)control;
                    checkbox.Enabled = true; 
                    checkbox.Checked = false;
                    checkbox.Visible = false; 
                    checkBoxList.Add(checkbox);
                }
            }
            foreach(CheckBox checkbo  in checkBoxList)
            {
                int urutan = int.Parse(checkbo.Name.Substring(7));
                if(urutan <= jumlahKursi)
                {
                    checkbo.Visible = true; 
                }
            }

            isFrozen = false; 
        }
        public void UpdateTotalKursi()
        {
            int total = 0; 
            string totalKursi = "";
            for(int index = 0; index < listKodeKursi.Count; index++)
            {
                if (index != listKodeKursi.Count - 1)
                {
                    totalKursi += listKodeKursi[index] + " , ";
                }
                else
                {
                    totalKursi += listKodeKursi[index];
                }
                total += int.Parse(labelHarga.Text);
            }
            labelTotalKursi.Text = totalKursi;
            labelDiskon.Text = (listKodeKursi.Count() * int.Parse(labelHarga.Text) * ((Film)comboBoxJudul.SelectedItem).Diskon / 100.0).ToString();
            labelTotal.Text = total.ToString();
            labelTotalAkhir.Text = (total - double.Parse(labelDiskon.Text)).ToString();

        }
        public string ConvertKodeKursi(string kodeKursi)
        {
            string kursi = "checkBo";
            int urutanKursi = 0;
            int nomorKelompok = 0;
            if(kodeKursi.Substring(0,1) == "A")
            {
                urutanKursi = int.Parse(kodeKursi.Substring(1));
                int baris = (int)(Math.Floor((urutanKursi - 0.1)/ 4.0));
                nomorKelompok = urutanKursi % 4; 
                if(nomorKelompok == 0)
                {
                    nomorKelompok = 4; 
                }
                nomorKelompok += baris * 12; 
            }
            else if(kodeKursi.Substring(0, 1) == "B")
            {
                urutanKursi = int.Parse(kodeKursi.Substring(1));
                int baris = (int)(Math.Floor((urutanKursi - 0.1) / 4.0));
                nomorKelompok = urutanKursi % 4;
                if (nomorKelompok == 0)
                {
                    nomorKelompok = 4;
                }
                nomorKelompok += baris * 12;
                nomorKelompok += 4;
            }
            else if(kodeKursi.Substring(0, 1) == "C")
            {
                urutanKursi = int.Parse(kodeKursi.Substring(1));
                int baris = (int)(Math.Floor((urutanKursi - 0.1) / 4.0));
                nomorKelompok = urutanKursi % 4;
                if (nomorKelompok == 0)
                {
                    nomorKelompok = 4;
                }
                nomorKelompok += baris * 12;
                nomorKelompok += 8;
            }
            kursi += nomorKelompok.ToString();
            return kursi; 
        }

        private void checkBo1_CheckedChanged(object sender, EventArgs e)
        {
            if (isFrozen == false)
            {
                CheckBox checkBox = (CheckBox)sender;
                if(checkBox.Checked == true)
                {
                    string urutanKursi = checkBox.Name;
                    listKodeKursi.Add(ConvertNumberKursi(urutanKursi));
                }
                else if (checkBox.Checked == false)
                {
                    string urutanKursi = checkBox.Name;
                    listKodeKursi.Remove(ConvertNumberKursi(urutanKursi));
                }
            }
            UpdateTotalKursi();
        }

        private void comboBoxJudul_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Film judulFilm;
            listCinema.Clear();
            comboBoxStudio.Items.Clear();
            judulFilm = (Film)comboBoxJudul.SelectedItem;
            comboBoxTanggal.DataSource = JadwalFilm.BacaData(judulFilm);

            if (comboBoxTanggal.Items.Count!=0)
            {
                labelComingSoon.Visible = false;
                labelHarga.Visible = true;
                labelRp.Visible = true;
                labelTIPE.Visible = true;
                labelKursi.Visible = true;
                labelSesi.Visible = true;
                labelStudio.Visible = true;
                labelCinema.Visible = true;
                labelTHARGA.Visible = true;
                comboBoxTanggal.Visible = true;
                comboBoxCinema.Visible = true;
                comboBoxStudio.Visible = true; 
            }
            else
            {
                labelComingSoon.Visible = true;
                labelHarga.Visible = false;
                labelRp.Visible = false;
                labelTIPE.Visible = false;
                labelKursi.Visible = false;
                labelSesi.Visible = false;
                labelStudio.Visible = false;
                labelCinema.Visible = false;
                labelTHARGA.Visible = false;
                comboBoxTanggal.Visible = false;
                comboBoxCinema.Visible = false;
                comboBoxStudio.Visible = false;
            }
            textBoxSinopsis.Text = judulFilm.Sinopsis;
            labelKelompok.Text = judulFilm.Kelompok.ToString();
            label1Durasi.Text = judulFilm.Durasi.ToString();
            textBoxGenre.Text = judulFilm.tampilkanGenre();
            textBoxAktor.Text = judulFilm.tampilkanAktor();
            
            if (File.Exists(Directory.GetCurrentDirectory().Replace(@"\Celikoor_Insomiac\bin\Debug", @"\Assets\" + judulFilm.CoverPath)))
            {
                pictureBoxPoster.Image = Image.FromFile(Directory.GetCurrentDirectory().Replace(@"\Celikoor_Insomiac\bin\Debug", @"\Assets\" + judulFilm.CoverPath));
            }
            else
            {
                MessageBox.Show(judulFilm.CoverPath + " tidak ditemukan");
            }
        }

        private void comboBoxCinema_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxStudio.Items.Clear();
            JadwalFilm jadwalFilm = (JadwalFilm)comboBoxTanggal.SelectedItem;
            foreach (Film_Studio fs in jadwalFilm.ListFS)
            {
                if (((Cinema)comboBoxCinema.SelectedItem).Nama_cabang == fs.Std.Bioskop.Nama_cabang)
                {
                    comboBoxStudio.Items.Add(fs.Std);
                }
            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
