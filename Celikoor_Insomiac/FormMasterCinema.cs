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
    public partial class FormMasterCinema : Form
    {
        List<Cinema> listCinema = new List<Cinema>();
        public FormMasterCinema()
        {
            InitializeComponent();
        }

        private void FormMasterCinema_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            listCinema = Cinema.BacaData();
            dataGridViewHasil.DataSource = listCinema;
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
            string cId = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();;
            Form frm = Application.OpenForms["FormUbahCinema"];
            Cinema c = Cinema.BacaData(int.Parse(cId));
            if (frm == null && e.ColumnIndex == 0)
            {
                if (c != null)
                {
                    FormUbahCinema formUP = new FormUbahCinema();
                    formUP.cinemaUbah = c;
                    formUP.Owner = this;
                    formUP.ShowDialog();
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
                FormMasterCinema_Load(sender, e);
            }
            else if (e.ColumnIndex == 1)
            {
                if (c != null)
                {
                    DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus cinema " + c.Nama_cabang + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (ans == DialogResult.Yes)
                    {
                        Cinema.HapusData(c);
                        FormMasterCinema_Load(sender, e);
                    }
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahCinema"];
            if (form == null)
            {
                FormTambahCinema tambah = new FormTambahCinema();
                tambah.Owner = this;
                tambah.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterCinema_Load(sender, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
