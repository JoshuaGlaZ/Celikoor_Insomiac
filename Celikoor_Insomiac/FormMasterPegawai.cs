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
    public partial class FormMasterPegawai : Form
    {
        List<Pegawai> pegawais = new List<Pegawai>();
        public FormMasterPegawai()
        {
            InitializeComponent();
        }

        private void FormMasterPegawai_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            pegawais = Pegawai.BacaData();
            dataGridViewHasil.DataSource = pegawais;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 6) //baru muncul kalau ada 1 data
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahPegawai"];
            if (form == null)
            {
                FormTambahPegawai formTP = new FormTambahPegawai();
                formTP.Owner = this;
                formTP.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterPegawai_Load(sender, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            Form frm = Application.OpenForms["FormUbahPegawai"];
            Pegawai p = Pegawai.BacaData(int.Parse(pKodeKategori));
            if (frm == null && e.ColumnIndex == 0)
            {
                if (p != null)
                {
                    FormUbahPegawai formUP = new FormUbahPegawai();
                    formUP.current_pegawai = p;
                    formUP.Owner = this;
                    formUP.ShowDialog();
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
                FormMasterPegawai_Load(sender, e);
            }
            else if (e.ColumnIndex == 1)
            {
                if (p != null)
                {
                    try
                    {
                        DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus karyawan " + p.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                        if (ans == DialogResult.Yes)
                        {
                            Pegawai.HapusData(p);
                            FormMasterPegawai_Load(sender, e);
                        }
                    }
                    catch(Exception ex)
                    {
                        if (ex.Message == "Cannot delete or update a parent row: a foreign key constraint fails (`insomniac`.`tikets`, CONSTRAINT `fk_film_studio_has_invoices_pegawais1` FOREIGN KEY (`operator_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION)")
                        {
                            MessageBox.Show("Pegawai tercatat di tiket sehingga tidak bisa dihapus");
                        }
                        else if (ex.Message == "Cannot delete or update a parent row: a foreign key constraint fails (`insomniac`.`invoices`, CONSTRAINT `fk_invoices_pegawais1` FOREIGN KEY (`kasir_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION)")
                        {
                            MessageBox.Show("Pegawai tercatat di invoices sehingga tidak bisa dihapus");
                        }
                    }
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
            }
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            pegawais = Pegawai.BacaData(comboBoxCari.Text,textBoxCari.Text);
            dataGridViewHasil.DataSource = pegawais;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace(" (L/P)", "").Replace(" ", "_").Replace("Tanggal", "tgl");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace(" ", "_").Replace("Tanggal", "tgl");
            pegawais = Pegawai.BacaData(kriteria, nilai, order);
            dataGridViewHasil.DataSource = pegawais;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);
        }
    }
}
