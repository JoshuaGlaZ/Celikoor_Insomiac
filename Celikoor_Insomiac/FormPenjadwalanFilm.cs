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
        List<Sesi_Film> ListSF = new List<Sesi_Film>();
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
            ListSF.Remove(ListSF[id]);
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
                if (checkBoxI.Checked) {
                    Sesi_Film sf = new Sesi_Film();

                    JadwalFilm jf = new JadwalFilm();
                    jf.TanggalPutar = dateTimePickerTanggal.Value;
                    jf.JamPemutaran = "I";
                    sf.Jf = jf;

                    Film_Studio fs = new Film_Studio();
                    fs.Std = (Studio)comboBoxStudio.SelectedItem;
                    fs.Flm = (Film)comboBoxFilm.SelectedItem;
                    sf.Fs = fs;

                    PengecekanDouble(sf);
                }
                if (checkBoxII.Checked) {
                    Sesi_Film sf = new Sesi_Film();

                    JadwalFilm jf = new JadwalFilm();
                    jf.TanggalPutar = dateTimePickerTanggal.Value;
                    jf.JamPemutaran = "II";
                    sf.Jf = jf;

                    Film_Studio fs = new Film_Studio();
                    fs.Std = (Studio)comboBoxStudio.SelectedItem;
                    fs.Flm = (Film)comboBoxFilm.SelectedItem;
                    sf.Fs = fs;

                    PengecekanDouble(sf);
                }
                if (checkBoxIII.Checked) {
                    Sesi_Film sf = new Sesi_Film();

                    JadwalFilm jf = new JadwalFilm();
                    jf.TanggalPutar = dateTimePickerTanggal.Value;
                    jf.JamPemutaran = "III";
                    sf.Jf = jf;

                    Film_Studio fs = new Film_Studio();
                    fs.Std = (Studio)comboBoxStudio.SelectedItem;
                    fs.Flm = (Film)comboBoxFilm.SelectedItem;
                    sf.Fs = fs;

                    PengecekanDouble(sf);
                }
                if (checkBoxIV.Checked) {
                    Sesi_Film sf = new Sesi_Film();

                    JadwalFilm jf = new JadwalFilm();
                    jf.TanggalPutar = dateTimePickerTanggal.Value;
                    jf.JamPemutaran = "IV";
                    sf.Jf = jf;

                    Film_Studio fs = new Film_Studio();
                    fs.Std = (Studio)comboBoxStudio.SelectedItem;
                    fs.Flm = (Film)comboBoxFilm.SelectedItem;
                    sf.Fs = fs;

                    PengecekanDouble(sf);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonSimpan_Click(object sender, EventArgs e) // mungkin perlu dicek lagi
        {
            foreach(Sesi_Film sf in ListSF)
            {
                List<JadwalFilm> ljf = JadwalFilm.BacaData("");
                List<Film_Studio> lsf = Film_Studio.BacaData("", "");
                bool check = true;

                foreach(JadwalFilm jf in ljf) //mengecek apakah jadwal_film dari sesi film sudah ditambahkan atau belum
                {
                    if(sf.Jf.JamPemutaran==jf.JamPemutaran && sf.Jf.TanggalPutar == jf.TanggalPutar) { check = false; break; }
                }
                if (check) { JadwalFilm.masukanData(sf.Jf); }

                check = true;
                foreach (Film_Studio fs in lsf) //mengecek apakah film_studio dari sesi film sudah ditambahkan atau belum
                {
                    if (sf.Fs.Flm.Judul == fs.Flm.Judul && sf.Fs.Std.Nama == fs.Std.Nama) { check = false; break; }
                }
                if (check) { Film_Studio.MasukanData(sf.Fs); }

                check = true;
                foreach (Sesi_Film x in Sesi_Film.bacaData("","")) //mengecek apakah ada sesi_film yg dobel
                {
                    if (sf.Jf.Id == sf.Jf.Id && sf.Fs.Std.Id == sf.Fs.Std.Id && sf.Fs.Flm.Id == x.Fs.Flm.Id) { check = false; break; }
                }
                if (check) { Sesi_Film.MasukanData(sf); MessageBox.Show("data berhasil dimasukan"); }
            }
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

        private void PengecekanDouble(Sesi_Film sf) //kalau ada data yang double dia nggak masuk
        {
            bool check = true;
            foreach (Sesi_Film x in ListSF)
            {
                bool checkJadwal = sf.Jf.JamPemutaran == x.Jf.JamPemutaran && sf.Jf.TanggalPutar == sf.Jf.TanggalPutar;
                bool checkFilmStudio = sf.Fs.Flm.Judul == x.Fs.Flm.Judul && sf.Fs.Std.Nama == sf.Fs.Std.Nama;
                if (checkJadwal && checkFilmStudio) 
                { 
                    check = false; 
                    MessageBox.Show("ada data dobel\n"+
                        sf.Jf.JamPemutaran +" \t "+ x.Jf.JamPemutaran+"\n"+
                        sf.Jf.TanggalPutar + " \t " + x.Jf.TanggalPutar + "\n" +
                        sf.Fs.Flm.Judul +" \t "+ x.Fs.Flm.Judul+"\n"+
                        sf.Fs.Std.Nama + " \t " + x.Fs.Std.Nama + "\n"); 
                    break; }
            }
            if (check)
            {
                ListSF.Add(sf);
                loadDataGrid();
            }
        }

        private void loadDataGrid()
        {
            dataGridViewInput.Rows.Clear();
            foreach (Sesi_Film x in ListSF)
            {
                dataGridViewInput.Rows.Add(x.Fs.Flm.Judul, x.Fs.Std.Bioskop.Nama_cabang, x.Fs.Std.Nama, x.Jf.TanggalPutar.ToString("yyyy-MM-dd"), x.Jf.JamPemutaran);
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
