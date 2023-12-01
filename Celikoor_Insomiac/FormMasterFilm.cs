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
    public partial class FormMasterFilm : Form
    {
        List<Film> listFilm = new List<Film>();
        public FormMasterFilm()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahFilm"];
            if (form == null)
            {
                FormTambahFilm tambah = new FormTambahFilm();
                tambah.Owner = this;
                tambah.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterFilm_Load(sender, e);
        }

        private void FormMasterFilm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listFilm = Film.BacaData();
            dataGridViewHasil.DataSource = listFilm;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 10) //baru muncul kalau ada 1 data
            {
                DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();
                bcolUbah.HeaderText = "Ganti Data";
                bcolUbah.Text = "Ubah";
                bcolUbah.Name = "buttonCollumnUbah";
                bcolUbah.FlatStyle = FlatStyle.Flat;
                bcolUbah.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                bcolUbah.DefaultCellStyle.BackColor = Color.FromArgb(54, 78, 104);
                bcolUbah.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                bcolUbah.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                bcolHapus.HeaderText = "Hapus Data";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "buttonCollumnHapus";
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(240, 84, 84);
                bcolHapus.DefaultCellStyle.ForeColor = Color.FromArgb(18, 18, 18);
                bcolHapus.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcolHapus);
            }
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace("Kelompok", "kelompoks_id").Replace("Sub Indo", "is_sub_indo").Replace("Cover", "cover_image").Replace("Diskon", "diskon_nominal").Replace(" ", "_").Replace("Tanggal", "tgl");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace("Kelompok", "kelompoks_id").Replace("Cover", "cover_image").Replace("Diskon", "diskon_nominal").Replace(" ", "_").Replace("Tanggal", "tgl");
            listFilm = Film.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listFilm;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            listFilm = Film.BacaData(comboBoxCari.Text, textBoxCari.Text);
            dataGridViewHasil.DataSource = listFilm;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCari_SelectedIndexChanged(sender, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
