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
    public partial class FormMasterJenisStudio : Form
    {
        List<JenisStudio> listJenisStudio = new List<JenisStudio>();
        public FormMasterJenisStudio()
        {
            InitializeComponent();
        }

        private void FormMasterJenisStudio_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            listJenisStudio = JenisStudio.BacaData();
            dataGridViewHasil.DataSource = listJenisStudio;
            if (dataGridViewHasil.Rows.Count >= 1 && dataGridViewHasil.Columns.Count == 3)
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
                dataGridViewHasil.Columns.Add(bcolHapus);
            }
        }


        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTambahJenisStudio"];
            if (form == null)
            {
                FormTambahJenisStudio jenis = new FormTambahJenisStudio();
                jenis.Owner = this;
                jenis.ShowDialog();
            }
            else
            {
                form.BringToFront();
                form.Show();
            }
            FormMasterJenisStudio_Load(sender, e);
        }

        private void dataGridViewHasil_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString());
            JenisStudio js = JenisStudio.BacaData(id.ToString());
            if (e.ColumnIndex == 0)
            {
                if (js != null)
                {
                    DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus jenis studio " + js.Nama + " ?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (ans == DialogResult.Yes)
                    {
                        JenisStudio.HapusData(js);
                        FormMasterJenisStudio_Load(sender, e);
                    }
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
            }
        }
    }
}
