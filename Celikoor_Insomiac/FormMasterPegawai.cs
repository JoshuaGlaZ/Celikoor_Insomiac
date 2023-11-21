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
            pegawais = Pegawai.BacaData();
            dataGridView1.DataSource = pegawais;
            if (dataGridView1.Rows.Count >= 1 && dataGridView1.Columns.Count == 6) //baru muncul kalau ada 1 data
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
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
                    DialogResult ans = MessageBox.Show("Apakah Anda yakin ingin menghapus karyawan "+p.Nama+" ?","Hapus Data",MessageBoxButtons.YesNo);
                    if(ans == DialogResult.Yes)
                    {
                        Pegawai.HapusData(p);
                        FormMasterPegawai_Load(sender, e);
                    }
                }
                else { MessageBox.Show("ada kesalahan pada data"); }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
