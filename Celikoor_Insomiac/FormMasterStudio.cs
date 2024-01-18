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
    public partial class FormMasterStudio : Form
    {
        List<Studio> listStudio = new List<Studio>();
        public FormMasterStudio()
        {
            InitializeComponent();
        }

        private void FormMasterStudio_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listStudio = Studio.BacaData("", "");
            dataGridViewHasil.DataSource = listStudio;
            if (dataGridViewHasil.Columns.Count == 7)
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahStudio"];
            if (form == null)
            {
                FormTambahStudio tambah = new FormTambahStudio();
                tambah.Owner = this;
                tambah.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterStudio_Load(sender, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            Form frm = Application.OpenForms["FormUbahStudio"];
            Studio s = Studio.BacaData("id",pId)[0];
            if (frm == null && e.ColumnIndex == dataGridViewHasil.Columns["buttonCollumnUbah"].Index)
            {
                if (s != null)
                {
                    FormUbahStudio formUP = new FormUbahStudio();
                    formUP.studioUbah = s;
                    formUP.Owner = this;
                    formUP.ShowDialog();
                }
                else { MessageBox.Show("Ada kesalahan pada data"); }
                FormMasterStudio_Load(sender, e);
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonCollumnHapus"].Index)
            {
                if (s != null)
                {
                    DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus studio " + s.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (ans == DialogResult.Yes)
                    {
                        try
                        {
                            Studio.HapusData(s);
                            MessageBox.Show("Data berhasil dihapus");
                            FormMasterStudio_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else { MessageBox.Show("Ada kesalahan pada data"); }
            }
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace("ID", "s.id").Replace("Nama", "s.nama").Replace("Jenis Studio", "js.Nama").Replace("Cinema", "c.Nama_cabang").Replace(" ", "_");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace("ID", "s.id").Replace("Nama", "s.nama").Replace("Jenis Studio", "js.Nama").Replace("Cinema", "c.Nama_cabang").Replace(" ", "_");
            listStudio = Studio.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listStudio;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
