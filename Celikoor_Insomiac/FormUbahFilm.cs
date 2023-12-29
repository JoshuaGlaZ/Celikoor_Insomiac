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
    public partial class FormUbahFilm : Form
    {
        public Film currentFilm;

        public FormUbahFilm()
        {
            InitializeComponent();
        }

        private void FormUbahFilm_Load(object sender, EventArgs e)
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

            textBoxJudul.Text = currentFilm.Judul;
            textBoxSinopsis.Text = currentFilm.Sinopsis;
            textBoxTahun.Text = currentFilm.Tahun.ToString();
            textBoxDurasi.Text = currentFilm.Durasi.ToString();
            comboBoxKelompok.SelectedItem = listKelompok.FirstOrDefault(k => k.Id == currentFilm.Kelompok.Id);
            comboBoxBahasa.SelectedItem = currentFilm.Bahasa;
            radioButtonYes.Checked = currentFilm.IsSubIndo == "iya";
            radioButtonNo.Checked = currentFilm.IsSubIndo == "tidak";
            textBoxDiskon.Text = currentFilm.Diskon.ToString();
            foreach (Aktor_Film af in currentFilm.ListAktor)
            {
                dataGridViewAktor.Rows.Add(af.Atr.Id, af.Atr.Nama, af.Atr.TglLahir, af.Atr.Gender, af.Atr.NegaraAsal, af.Peran);
            }
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
            
            foreach (Genre_Film gf in currentFilm.ListGenre)
            {
                dataGridViewGenre.Rows.Add(gf.Gnr.Id, gf.Gnr.NamaGenre, gf.Gnr.Deskripsi);
            }
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
            textBoxCoverPath.Text = currentFilm.CoverPath;
            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists(Directory.GetCurrentDirectory().Replace(@"\Celikoor_Insomiac\bin\Debug", @"\Assets\" + textBoxCoverPath.Text)))
            {
                pictureBoxCover.Image = Image.FromFile(Directory.GetCurrentDirectory().Replace(@"\Celikoor_Insomiac\bin\Debug", @"\Assets\" + textBoxCoverPath.Text));
            }
            else
            {
                MessageBox.Show(currentFilm.CoverPath + " tidak ditemukan");
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
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
                    Film filmUbah = new Film(textBoxJudul.Text,
                                textBoxSinopsis.Text,
                                int.Parse(textBoxTahun.Text),
                                int.Parse(textBoxDurasi.Text),
                                (Kelompok)comboBoxKelompok.SelectedItem,
                                comboBoxBahasa.SelectedItem.ToString(),
                                radioButtonYes.Checked ? "iya" : "tidak",
                                textBoxCoverPath.Text,
                                double.Parse(textBoxDiskon.Text));
                    filmUbah.Id = currentFilm.Id;
                    foreach (DataGridViewRow row in dataGridViewAktor.Rows)
                    {
                        filmUbah.AddAktor(new Aktor(int.Parse(row.Cells["ColumnAktorId"].Value.ToString()),
                                                        row.Cells["ColumnAktorNama"].Value.ToString(),
                                                        DateTime.Parse(row.Cells["ColumnAktorTglLahir"].Value.ToString()),
                                                        row.Cells["ColumnAktorGender"].Value.ToString(),
                                                        row.Cells["ColumnAktorNegaraAsal"].Value.ToString()),
                                            row.Cells["ColumnPeran"].Value.ToString());
                    }
                    foreach (DataGridViewRow row in dataGridViewGenre.Rows)
                    {
                        filmUbah.AddGenre(new Genre_Film(new Genre(int.Parse(row.Cells["ColumnGenreId"].Value.ToString()),
                                    row.Cells["ColumnGenreNama"].Value.ToString(),
                                    row.Cells["ColumnGenreDeskripsi"].Value.ToString())));
                    }
                    Film.UbahData(filmUbah);
                    string filmSucceed = "Film = " + filmUbah.Judul + filmUbah.ToStringAktorGenre() + "\n";
                    MessageBox.Show("Data film berhasil diubah\n" + filmSucceed);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            Genre g = (Genre)comboBoxGenre.SelectedItem;
            if (!IsDuplicateGenre(g))
            {
                dataGridViewGenre.Rows.Add(g.Id, g.NamaGenre, g.Deskripsi);
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
            else
            {
                MessageBox.Show("Genre sudah ada");
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
    
        private void buttonAddAktor_Click(object sender, EventArgs e)
        {
            Aktor a = (Aktor)comboBoxActor.SelectedItem;
            if (!IsDuplicateAktor(a))
            {
                dataGridViewAktor.Rows.Add(a.Id, a.Nama, a.TglLahir, a.Gender, a.NegaraAsal);
                DataGridViewComboBoxCell comboBoxCell = dataGridViewAktor.Rows[dataGridViewAktor.Rows.Count - 1].Cells["ColumnPeran"]
                    as DataGridViewComboBoxCell;
                comboBoxCell.Value = "UTAMA";
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
            else
            {
                MessageBox.Show("Aktor sudah ada");
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
        private void buttonCari_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Cover Image";
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            open.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\Celikoor_Insomiac\bin\Debug", @"\Assets\");
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxCover.Image = new Bitmap(open.FileName);
                textBoxCoverPath.Text = Path.GetFileName(open.FileName); 
            }
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewGenre.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewGenre.Columns["buttonHapus"].Index)
            {
                dataGridViewGenre.Rows.RemoveAt(i);
            }
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewAktor.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewAktor.Columns["buttonHapus"].Index)
            {
                dataGridViewAktor.Rows.RemoveAt(i);
            }
        }
    }
}
