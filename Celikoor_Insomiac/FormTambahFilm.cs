using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insomiac_lib;

namespace Celikoor_Insomiac
{
    public partial class FormTambahFilm : Form
    {
        List<Film> listFilm = new List<Film>();
        public FormTambahFilm()
        {
            InitializeComponent();
        }

        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            List<Aktor> listAktor = Aktor.BacaData();
            comboBoxActor.DataSource = listAktor;
            comboBoxActor.DisplayMember = "Nama";

            List<Genre> listGenre = Genre.BacaData();
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "NamaGenre";

            List<Kelompok> listKelompok = Kelompok.BacaData();
            comboBoxKelompok.DataSource = listKelompok;
            comboBoxKelompok.DisplayMember = "Nama";

            comboBoxBahasa.SelectedIndex = 0;
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        { 
            try
            {
                List<Film> listFilmCheck = Film.BacaData();
                foreach (Film f in listFilmCheck)
                {
                    foreach (Aktor_Film af in f.ListAktor)
                    {
                        List<Aktor_Film> listAktorCheck = f.BacaDataAktor(af.Atr.Id.ToString(), f.Id.ToString());
                    }
                    foreach (Genre_Film gf in f.ListGenre)
                    {
                        List<Genre_Film> listGenreCheck = f.BacaDataGenre(f.Id.ToString(), gf.Gnr.Id.ToString());
                    }
                }
                string filmSucceed = "";
                if (listFilm.Count > 0)
                {
                    foreach(Film filmSave in listFilm)
                    {
                        Film.TambahData(filmSave);
                        filmSucceed += "Film = " + filmSave.Judul + filmSave.ToStringAktorGenre() + "\n";
                    }
                    MessageBox.Show("Data film berhasil ditambah\n" + filmSucceed);
                }
                else
                {
                    throw new Exception("Belum menambah film yang ingin disimpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Cover Image";
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            open.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\Celikoor_Insomiac\bin\Debug", @"\Assets\");
            if (open.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(open.FileName);
                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxCover.Image = Image.FromFile(open.FileName);
                textBoxCoverPath.Text = fileName;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJudul.Text == "") { throw new Exception("Judul"); }
                else if (textBoxSinopsis.Text == "") { throw new Exception("Sinopsis"); }
                else if (textBoxTahun.Text == "") { throw new Exception("Tahun"); }
                else if (textBoxDurasi.Text == "") { throw new Exception("Durasi"); }
                else if (comboBoxKelompok.SelectedIndex == -1) { throw new Exception("Kelompok"); }
                else if (comboBoxBahasa.SelectedIndex == -1) { throw new Exception("Bahasa"); }
                else if (textBoxCoverPath.Text == "-") { throw new Exception("Cover"); }
                else if (dataGridViewGenre.Rows.Count == 0) { throw new Exception("Genre"); }
                else if (dataGridViewAktor.Rows.Count == 0) { throw new Exception("Aktor"); }
                else
                {
                    Film f = new Film(textBoxJudul.Text, 
                                    textBoxSinopsis.Text.Replace("'", "\\'"),
                                    int.Parse(textBoxTahun.Text),
                                    int.Parse(textBoxDurasi.Text),
                                    (Kelompok)comboBoxKelompok.SelectedItem, 
                                    comboBoxBahasa.SelectedItem.ToString(),
                                    radioButtonYes.Checked ? "iya" : "tidak", 
                                    textBoxCoverPath.Text,
                                    double.Parse(textBoxDiskon.Text));
                    foreach (DataGridViewRow row in dataGridViewAktor.Rows)
                    {
                        f.AddAktor(new Aktor(int.Parse(row.Cells["ColumnAktorId"].Value.ToString()),
                                                        row.Cells["ColumnAktorNama"].Value.ToString(),
                                                        DateTime.Parse(row.Cells["ColumnAktorTglLahir"].Value.ToString()),
                                                        row.Cells["ColumnAktorGender"].Value.ToString(),
                                                        row.Cells["ColumnAktorNegaraAsal"].Value.ToString()),
                                                    row.Cells["ColumnPeran"].Value.ToString());
                    }
                    foreach (DataGridViewRow row in dataGridViewGenre.Rows)
                    {
                        Genre_Film gf = new Genre_Film(new Genre(int.Parse(row.Cells["ColumnGenreId"].Value.ToString()),
                                   row.Cells["ColumnGenreNama"].Value.ToString(),
                                   row.Cells["ColumnGenreDeskripsi"].Value.ToString()));
                        f.AddGenre(gf);
                    }
                    if (!IsDuplicateFilm(f))
                    {
                        listFilm.Add(f);
                        dataGridViewFilm.Rows.Add(f.Judul, f.Sinopsis, f.Tahun, f.Durasi, f.Kelompok, f.Bahasa,
                            f.IsSubIndo, f.CoverPath, f.Diskon);

                        LoadDataGridFilm();
                    }
                    else
                    {
                        MessageBox.Show("Film sudah ada.\nJudul, Sinopsis, dan Cover harap diganti");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data " + ex.Message + " belum diisi");
            }
        }

        private void dataGridViewFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewFilm.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewFilm.Columns["buttonHapus"].Index)
            {
                listFilm.Remove(listFilm[i]);
                dataGridViewFilm.Rows.RemoveAt(i);
                LoadDataGridFilm();
            }
            else if (e.ColumnIndex == dataGridViewFilm.Columns["buttonAktorGenre"].Index)
            {
                FormTambahFilmAktorGenre aktorGenre = new FormTambahFilmAktorGenre();
                aktorGenre.Owner = this;
                aktorGenre.film = listFilm[i];
                aktorGenre.aktors.AddRange(listFilm[i].ListAktor);
                aktorGenre.genres.AddRange(listFilm[i].ListGenre);
                aktorGenre.ShowDialog();
            }
        }

        private void LoadDataGridFilm()
        {
            if (dataGridViewFilm.Rows.Count >= 1 && dataGridViewFilm.Columns.Count == 9)
            {
                DataGridViewButtonColumn bcolAktorGenre = new DataGridViewButtonColumn();
                bcolAktorGenre.HeaderText = "Genre & Aktor"; 
                bcolAktorGenre.Text = "Detail";
                bcolAktorGenre.Name = "buttonAktorGenre";
                bcolAktorGenre.FlatStyle = FlatStyle.Flat;
                bcolAktorGenre.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                bcolAktorGenre.DefaultCellStyle.BackColor = Color.FromArgb(54, 78, 104);
                bcolAktorGenre.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                bcolAktorGenre.UseColumnTextForButtonValue = true;
                dataGridViewFilm.Columns.Add(bcolAktorGenre);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                bcolHapus.HeaderText = "Hapus Data";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "buttonHapus";
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(240, 84, 84);
                bcolHapus.DefaultCellStyle.ForeColor = Color.FromArgb(18, 18, 18);
                bcolHapus.UseColumnTextForButtonValue = true;
                dataGridViewFilm.Columns.Add(bcolHapus);
            }
        }

        public bool IsDuplicateFilm(Film f)
        {
            foreach (DataGridViewRow row in dataGridViewFilm.Rows)
            { 
                string dJudul = row.Cells["ColumnJudul"].Value.ToString();
                string dSinopsis = row.Cells["ColumnSinopsis"].Value.ToString();
                string dCoverPath = row.Cells["ColumnCoverImage"].Value.ToString();
                if (f.Judul == dJudul || f.Sinopsis == dSinopsis || f.CoverPath == dCoverPath)
                {
                    return true; 
                }
            }
            return false;
        }

        private void buttonTambahAktor_Click(object sender, EventArgs e)
        {
            Aktor a = (Aktor)comboBoxActor.SelectedItem;
            if (!IsDuplicateAktor(a))
            {
                dataGridViewAktor.Rows.Add(a.Id, a.Nama, a.TglLahir, a.Gender, a.NegaraAsal);
                DataGridViewComboBoxCell comboBoxCell = dataGridViewAktor.Rows[dataGridViewAktor.Rows.Count - 1].Cells["ColumnPeran"]
                    as DataGridViewComboBoxCell;
                comboBoxCell.Value = "UTAMA";
                LoadDataGridAktor();
            }
            else
            {
                MessageBox.Show("Aktor sudah ada");
            }

        }

        private void LoadDataGridAktor()
        {
            if (dataGridViewAktor.Rows.Count >= 1 && dataGridViewAktor.Columns.Count == 6)
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
                dataGridViewAktor.Columns.Add(bcolHapus);
            }
        }
        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewAktor.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewAktor.Columns["buttonHapus"].Index)
            {
                dataGridViewAktor.Rows.RemoveAt(i);
                LoadDataGridAktor();
            }
        }

        private bool IsDuplicateAktor(Aktor a)
        {
            foreach (DataGridViewRow row in dataGridViewAktor.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == a.Nama)
                {
                    return true; 
                }
            }
            return false;
        }

        private void buttonTambahGenre_Click(object sender, EventArgs e)
        {
            Genre g = (Genre)comboBoxGenre.SelectedItem;
            if (!IsDuplicateGenre(g))
            {
                dataGridViewGenre.Rows.Add(g.Id, g.NamaGenre, g.Deskripsi);
                LoadDataGridGenre();
            }
            else
            {
                MessageBox.Show("Genre sudah ada");
            }
        }

        private void LoadDataGridGenre()
        {
            if (dataGridViewGenre.Rows.Count >= 1 && dataGridViewGenre.Columns.Count == 3)
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
                dataGridViewGenre.Columns.Add(bcolHapus);
            }
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewGenre.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewGenre.Columns["buttonHapus"].Index)
            {
                dataGridViewGenre.Rows.RemoveAt(i);
                LoadDataGridGenre();
            }
        }
        private bool IsDuplicateGenre(Genre g)
        {
            foreach (DataGridViewRow row in dataGridViewGenre.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == g.NamaGenre)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
