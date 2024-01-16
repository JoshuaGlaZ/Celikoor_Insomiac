﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insomiac_lib;

namespace Celikoor_Insomiac
{
    public partial class FormPenjadwalanFilm : Form
    {
        List<JadwalFilm> ListJF = new List<JadwalFilm>();
        public FormPenjadwalanFilm()
        {
            InitializeComponent();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshLabel()
        {
            labelNamaStudio.Text = "(nama studio)";
            labelHargaWeekday.Text = "(nama harga weekday)";
            labelHargaWeekend.Text = "(nama harga weekend)";

            labelSinopsis.Text = "(sinopsis)";
            labelDurasi.Text = "(durasi)";
            labelAktorUtama.Text = "(aktor, aktor...)";
            labelGenre.Text = "(genre, genre)";
            labelKelompok.Text = "(kelompok)";
        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e) //masih perlu dilengkapi
        {
            string tgl = dataGridViewInput.CurrentRow.Cells["TanggalCol"].Value.ToString();
            string jamputar = dataGridViewInput.CurrentRow.Cells["JamCol"].Value.ToString();
            foreach (JadwalFilm jf in ListJF)
            {
                if (jf.TanggalPutar.ToString("yyyy-MM-dd").Equals(tgl) && jf.JamPemutaran.Equals(jamputar))
                {
                    MessageBox.Show(jf.TanggalPutar.ToString("yyyy-MM-dd") + "\t" + tgl + "\n" + jf.JamPemutaran + "\t" + jamputar);
                    MessageBox.Show("p " + jf.ListFS.Count);
                    foreach(Film_Studio fs in jf.ListFS)
                    {
                        if (fs.Flm.Equals(Film.BacaData("judul", dataGridViewInput.CurrentRow.Cells["JudulFilmCol"].Value.ToString())[0]) && fs.Std.Equals(Studio.BacaData("nama", dataGridViewInput.CurrentRow.Cells["StudioCol"].Value.ToString())[0])) { jf.ListFS.Remove(fs); break; }
                    }
                    MessageBox.Show("p " + jf.ListFS.Count);
                    if (jf.ListFS.Count == 0) { ListJF.Remove(jf); }
                    MessageBox.Show("data berhasil dihapus");
                }
            }
            loadDataGrid();
        }

        private void FormPenjadwalanFilm_Load(object sender, EventArgs e)
        {
            comboBoxCinema.DataSource = Cinema.BacaData();
            comboBoxCinema.DisplayMember = "Nama_cabang";
            comboBoxCinema.SelectedItem = null;

            comboBoxFilm.DataSource = Film.BacaData();
            comboBoxFilm.SelectedItem = null;

            RefreshLabel();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStudio.SelectedIndex == -1) { throw new Exception("harap isi studio terlebih dulu"); }
                else
                {
                    Film_Studio fs = new Film_Studio();
                    fs.Std = (Studio)comboBoxStudio.SelectedItem;
                    fs.Flm = (Film)comboBoxFilm.SelectedItem;

                    if (checkBoxI.Checked)
                    {
                        checkDobel(fs, "I");
                    }
                    if (checkBoxII.Checked)
                    {
                        checkDobel(fs, "II");
                    }
                    if (checkBoxIII.Checked)
                    {
                        checkDobel(fs, "III");
                    }
                    if (checkBoxIV.Checked)
                    {
                        checkDobel(fs, "IV");
                    }
                    loadDataGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void checkDobel(Film_Studio fs, string kode)
        {
            bool check = true;
            foreach (JadwalFilm x in ListJF) //mengecek jadwalnya sudah ada atau belum
            {
                if (x.TanggalPutar == dateTimePickerTanggal.Value && x.JamPemutaran == kode)
                {
                    bool check2 = true;
                    foreach(Film_Studio y in x.DaftarFilmStudio())
                    {
                        if(y.Std.Nama == fs.Std.Nama) { check2 = false; break; }
                    }
                    if (check2) { x.ListFS.Add(fs); }
                    check = false; 
                    break; 
                }
            }
            if (check)
            {
                JadwalFilm jf = new JadwalFilm();
                jf.TanggalPutar = dateTimePickerTanggal.Value;
                jf.JamPemutaran = kode;
                jf.ListFS.Add(fs);
                ListJF.Add(jf);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            foreach (JadwalFilm jf in ListJF)
            {
                JadwalFilm.masukanData(jf);
                jf.Id = JadwalFilm.BacaData(jf.TanggalPutar.ToString("yyyy-MM-dd"), jf.JamPemutaran).Id;
                jf.TambahDataFilmStudio(); //buat masukin film_studio dan sesi film
            }
            MessageBox.Show("data berhasil dimasukan");
        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilm.Text != "")
            {
                Film f = (Film)comboBoxFilm.SelectedItem;
                labelSinopsis.Text = f.Sinopsis.ToString();
                labelDurasi.Text = f.Durasi.ToString();
                labelAktorUtama.Text = f.tampilkanAktor();
                labelGenre.Text = f.tampilkanGenre();
                labelKelompok.Text = f.Kelompok.Nama;
            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCinema.Text != "")
            {
                Cinema c = (Cinema)comboBoxCinema.SelectedValue;
                comboBoxStudio.DataSource = Studio.BacaData("cinemas_id", c.Id.ToString());
                comboBoxStudio.SelectedItem = null;
                RefreshLabel();
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudio.Text != "")
            {
                Studio s = (Studio)comboBoxStudio.SelectedItem;
                labelNamaStudio.Text = s.Nama;  
                labelHargaWeekday.Text = s.Harga_weekday.ToString("C", CultureInfo.CurrentCulture) ;
                labelHargaWeekend.Text = s.Harga_weekend.ToString("C", CultureInfo.CurrentCulture) ;
            }
        }

        private void loadDataGrid()
        {
            dataGridViewInput.Rows.Clear();
            foreach (JadwalFilm jf in ListJF)
            {
                foreach(Film_Studio fs in jf.ListFS)
                {
                    dataGridViewInput.Rows.Add(fs.Flm.Judul, fs.Std.Bioskop.Nama_cabang, fs.Std.Nama, jf.TanggalPutar.ToString("yyyy-MM-dd"), jf.JamPemutaran);
                }
            }
            if (dataGridViewInput.Rows.Count >= 1 && dataGridViewInput.Columns.Count == 5)
            {
                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                bcolHapus.HeaderText = "Hapus Data";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "buttonHapus";
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(240, 84, 84);
                bcolHapus.DefaultCellStyle.ForeColor = Color.FromArgb(18, 18, 18);
                bcolHapus.UseColumnTextForButtonValue = true;
                dataGridViewInput.Columns.Add(bcolHapus);
            }
        }
    }
}
