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
    public partial class FormMasterKelompok : Form
    {
        List<Kelompok> kelompoks = new List<Kelompok>();
        public FormMasterKelompok()
        {
            InitializeComponent();
        }

        private void FormMasterKelompok_Load(object sender, EventArgs e)
        {
            kelompoks = Kelompok.BacaData();
            dataGridViewHasil.DataSource = kelompoks;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 2)
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
            Form form = Application.OpenForms["FormTambahKelompok"];
            if (form == null)
            {
                FormTambahKelompok kelompok = new FormTambahKelompok();
                kelompok.Owner = this;
                kelompok.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterKelompok_Load(sender, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idKelompok = int.Parse(dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString());
            Kelompok k = Kelompok.BacaData(idKelompok);
            FormUbahKelompok frm = new FormUbahKelompok();
            if (e.ColumnIndex == 0)
            {
                if (k != null)
                {
                    FormUbahKelompok formUK = new FormUbahKelompok();
                    formUK.current_kelompok = k;
                    formUK.Owner = this;
                    formUK.ShowDialog();
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
                FormMasterKelompok_Load(sender, e);
            }
            else if (e.ColumnIndex == 1)
            {
                if (k != null)
                {
                    DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus kelompok " + k.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (ans == DialogResult.Yes)
                    {
                        Kelompok.HapusData(k);
                        FormMasterKelompok_Load(sender, e);
                    }
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
            }
        }
    }
}
