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
        FormUtama utama;
        public FormTambahFilm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Cover Image";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.InitialDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxCover.Image = new Bitmap(open.FileName);
                labelCoverPath.Text = open.FileName;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            foreach (Film f in listFilm) 
            {
                Film.TambahData(f);
            }
            MessageBox.Show("Data berhasil ditambahkan");

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                else if (labelCoverPath.Text == "-") { throw new Exception("Cover"); }
                else
                {
                    Film f = new Film(textBoxJudul.Text, textBoxSinopsis.Text,
                        int.Parse(textBoxTahun.Text), int.Parse(textBoxDurasi.Text),
                        (Kelompok)comboBoxKelompok.SelectedItem, comboBoxBahasa.SelectedItem.ToString(),
                        radioButtonYes.Checked ? "iya" : "tidak", labelCoverPath.Text,
                        double.Parse(textBoxDiskon.Text));
                    listFilm.Add(f);
                    loadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data " + ex.Message + " belum diisi");
            }
        }

        private void buttonAddAktor_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {

        }

        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.Owner.MdiParent;

            List<Aktor> listAktor= Aktor.BacaData();
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

        private void dataGridViewFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewFilm.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewFilm.Columns["buttonHapus"].Index)
            {
                dataGridViewFilm.Rows.RemoveAt(i);
                loadDataGrid();
            }
        }

        private void loadDataGrid()
        {
            dataGridViewFilm.Rows.Clear();
            foreach (Film f in listFilm)
            {
                dataGridViewFilm.Rows.Add(f.Id, f.Judul, f.Sinopsis, f.Tahun, f.Durasi, f.Kelompok.Nama, f.Bahasa, f.IsSubIndo, f.CoverPath, f.Diskon);
            }
            if (dataGridViewFilm.Rows.Count >= 1 && dataGridViewFilm.Columns.Count == 10)
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
                dataGridViewFilm.Columns.Add(bcolHapus);
            }
        }
    }
}
