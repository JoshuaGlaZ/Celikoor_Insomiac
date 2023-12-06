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
        public FormMasterStudio()
        {
            InitializeComponent();
        }

        private void FormMasterStudio_Load(object sender, EventArgs e)
        {
            dataGridViewHasil.DataSource = Studio.BacaData("", "");
            if (dataGridViewHasil.Columns.Count == 7)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "AKSI";
                btnHapus.Name = "hapus";
                btnHapus.Text = "HAPUS";
                btnHapus.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnHapus);
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
            Studio s = Studio.BacaData("id",pId)[0];
            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus"].Index)
            {
                if (s != null)
                {
                    DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus studio " + s.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (ans == DialogResult.Yes)
                    {
                        Studio.HapusData(s);
                        MessageBox.Show("data berhasil dihapus");
                        FormMasterStudio_Load(sender, e);
                    }
                }
                else { MessageBox.Show("Ada kesalahan pada data"); }
            }
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
