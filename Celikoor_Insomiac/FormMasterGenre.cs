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
    public partial class FormMasterGenre : Form
    {
        List<Genre> listGenre = new List<Genre>();
        public FormMasterGenre()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahGenre"];
            if (form == null) 
            {
                FormTambahGenre tambah = new FormTambahGenre();
                tambah.Owner = this;
                tambah.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterGenre_Load(sender, e);

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterGenre_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0;
            listGenre = Genre.BacaData();
            dataGridViewHasil.DataSource = listGenre;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 3)                             
            {
                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                bcolHapus.HeaderText = "Hapus Data";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "buttonCollumnHapus";
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(240, 84, 84);
                bcolHapus.DefaultCellStyle.ForeColor = Color.FromArgb(18, 18, 18);
                bcolHapus.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcolHapus);
            }
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            Genre g = Genre.BacaData(int.Parse(pId));
            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonCollumnHapus"].Index)
            {
                if (g != null)
                {
                    try
                    {
                        DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus genre " + g.NamaGenre + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                        if (ans == DialogResult.Yes)
                        {
                            Genre.HapusData(g);
                            FormMasterGenre_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message =="Cannot delete or update a parent row: a foreign key constraint fails (`insomniac`.`genre_film`, CONSTRAINT `fk_films_has_genres_genres1` FOREIGN KEY (`genres_id`) REFERENCES `genres` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION)")
                        {
                            MessageBox.Show("Genre masih dipakai pada film");
                        }
                    }
                }
                else { MessageBox.Show("Ada kesalahan pada data"); }
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace(" (L/P)", "").Replace(" ", "_").Replace("Tanggal", "tgl");
            string nilai = textBoxCari.Text;
            listGenre = Genre.BacaData(kriteria, nilai);
            dataGridViewHasil.DataSource = listGenre;
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
