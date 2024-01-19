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
    public partial class FormMasterAktor : Form
    {
        List<Aktor> listAktor = new List<Aktor>();
        public FormMasterAktor()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahAktor"];
            if (form == null) 
            {
                FormTambahAktor tambah = new FormTambahAktor();
                tambah.Owner = this;
                tambah.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterAktor_Load(sender, e);

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterAktor_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listAktor = Aktor.BacaData();
            dataGridViewHasil.DataSource = listAktor;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 5) //baru muncul kalau ada 1 data
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
            Form frm = Application.OpenForms["FormUbahAktor"];
            Aktor k = Aktor.BacaData(int.Parse(pId));
            if (frm == null && e.ColumnIndex == dataGridViewHasil.Columns["buttonCollumnUbah"].Index)
            {
                if (k != null)
                {
                    FormUbahAktor formUP = new FormUbahAktor();
                    formUP.aktorUbah = k;
                    formUP.Owner = this;
                    formUP.ShowDialog();
                }
                else { MessageBox.Show("Ada kesalahan pada data"); }
                FormMasterAktor_Load(sender, e);
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonCollumnHapus"].Index)
            {
                if (k != null)
                {
                    try
                    {
                        DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus Aktor " + k.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                        if (ans == DialogResult.Yes)
                        {
                            Aktor.HapusData(k);
                            FormMasterAktor_Load(sender, e);
                        }
                    }
                    
                    catch(Exception ex)
                    {
                        if (ex.Message == "Cannot delete or update a parent row: a foreign key constraint fails (`insomniac`.`aktor_film`, CONSTRAINT `fk_aktors_has_films_aktors1` FOREIGN KEY (`aktors_id`) REFERENCES `aktors` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION)")
                        {
                            MessageBox.Show("Aktor masih berperan di film");
                        }
                    }
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace(" (L/P)", "").Replace(" ", "_").Replace("Tanggal", "tgl");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace(" ", "_").Replace("Tanggal", "tgl");
            listAktor = Aktor.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listAktor;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);
        }
    }
}
