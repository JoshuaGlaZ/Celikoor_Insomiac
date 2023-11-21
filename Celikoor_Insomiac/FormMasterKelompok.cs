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
            dataGridView1.DataSource = kelompoks;
            if (dataGridView1.Rows.Count >= 1 && dataGridView1.Columns.Count == 2)
            {
                DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                bcol.HeaderText = "Ubah";
                bcol.Text = "Ubah";
                bcol.Name = "buttonCollumn";
                bcol.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(bcol);

                DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                bcol2.HeaderText = "Hapus";
                bcol2.Text = "Hapus";
                bcol2.Name = "buttonCollumn2";
                bcol2.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(bcol2);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idKelompok = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
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
    }
}
