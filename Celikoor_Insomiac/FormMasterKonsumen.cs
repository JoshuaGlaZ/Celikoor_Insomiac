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
    public partial class FormMasterKonsumen : Form
    {
        List<Konsumen> listKonsumen = new List<Konsumen>();
        public FormMasterKonsumen()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahKonsumen"];
            if (form == null) 
            {
                FormTambahKonsumen tambah = new FormTambahKonsumen();
                tambah.Owner = this;
                tambah.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterKonsumen_Load(sender, e);

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterKonsumen_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            listKonsumen = Konsumen.BacaData();
            dataGridViewHasil.DataSource = listKonsumen;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 9) //baru muncul kalau ada 1 data
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
            Form frm = Application.OpenForms["FormUbahKonsumen"];
            Konsumen k = Konsumen.BacaData(int.Parse(pId));
            if (frm == null && e.ColumnIndex == 0)
            {
                if (k != null)
                {
                    FormUbahKonsumen formUP = new FormUbahKonsumen();
                    formUP.konsumenUbah = k;
                    formUP.Owner = this;
                    formUP.ShowDialog();
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
                FormMasterKonsumen_Load(sender, e);
            }
            else if (e.ColumnIndex == 1)
            {
                if (k != null)
                {
                    try
                    {
                        DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus konsumen " + k.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                        if (ans == DialogResult.Yes)
                        {
                            Konsumen.HapusData(k);
                            FormMasterKonsumen_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {

                        if (ex.Message == "Cannot delete or update a parent row: a foreign key constraint fails (`insomniac`.`invoices`, CONSTRAINT `fk_invoices_konsumens1` FOREIGN KEY (`konsumens_id`) REFERENCES `konsumens` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION)")
                        {
                            MessageBox.Show("Konsumen tercatat di invoice sehingga tidak bisa dihapus");
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
            listKonsumen = Konsumen.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listKonsumen;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);
        }
    }
}
