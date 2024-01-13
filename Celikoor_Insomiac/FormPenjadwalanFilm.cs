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

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dataGridViewInput.CurrentRow.Index;
            loadDataGrid();
        }

        private void FormPenjadwalanFilm_Load(object sender, EventArgs e)
        {
            comboBoxCinema.DataSource = Cinema.BacaData();
            comboBoxCinema.DisplayMember = "Nama_cabang";
            comboBoxCinema.SelectedIndex = -1;

            comboBoxFilm.DataSource = Film.BacaData();
            comboBoxFilm.DisplayMember = "Judul";
            comboBoxFilm.SelectedIndex = -1;
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
                        JadwalFilm jf = new JadwalFilm();
                        jf.TanggalPutar = dateTimePickerTanggal.Value;
                        jf.JamPemutaran = "I";
                        PengecekanDouble(jf,fs);
                    }
                    if (checkBoxII.Checked)
                    {
                        JadwalFilm jf = new JadwalFilm();
                        jf.TanggalPutar = dateTimePickerTanggal.Value;
                        jf.JamPemutaran = "II";
                        PengecekanDouble(jf, fs);
                    }
                    if (checkBoxIII.Checked)
                    {
                        JadwalFilm jf = new JadwalFilm();
                        jf.TanggalPutar = dateTimePickerTanggal.Value;
                        jf.JamPemutaran = "III";
                        PengecekanDouble(jf, fs);
                    }
                    if (checkBoxIV.Checked)
                    {
                        JadwalFilm jf = new JadwalFilm();
                        jf.TanggalPutar = dateTimePickerTanggal.Value;
                        jf.JamPemutaran = "IV";
                        PengecekanDouble(jf, fs);
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonSimpan_Click(object sender, EventArgs e) // mungkin perlu dicek lagi
        {
            

        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilm.SelectedIndex != -1)
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
            if (comboBoxCinema.SelectedIndex != -1)
            {
                Cinema c = (Cinema)comboBoxCinema.SelectedValue;
                comboBoxStudio.DataSource = Studio.BacaData("cinemas_id", c.Id.ToString());
                comboBoxStudio.DisplayMember = "Nama";
                comboBoxStudio.SelectedIndex = -1;
                comboBoxStudio.Text = "";
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudio.SelectedIndex != -1)
            {
                Studio s = (Studio)comboBoxStudio.SelectedItem;
                labelNamaStudio.Text = s.Nama;
                labelHargaWeekday.Text = s.Harga_weekday + " Rp";
                labelHargaWeekend.Text = s.Harga_weekend + " Rp";
            }
        }

        private void PengecekanDouble(JadwalFilm jf, Film_Studio fs) //kalau ada data yang double dia nggak masuk
        {
            
        }

        private void loadDataGrid()
        {
            dataGridViewInput.Rows.Clear();
            foreach (JadwalFilm jf in ListJF)
            {
                foreach(Film_Studio fs in jf.DaftarFilmStudio())
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
