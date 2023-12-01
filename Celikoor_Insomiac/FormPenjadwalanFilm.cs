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
    public partial class FormPenjadwalanFilm : Form
    {
        List<JadwalFilm> ListJF = new List<JadwalFilm>();
        public FormPenjadwalanFilm()
        {
            InitializeComponent();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dataGridViewInput.CurrentRow.Index;
            ListJF.Remove(ListJF[id]);
            loadDataGrid();
        }

        private void FormPenjadwalanFilm_Load(object sender, EventArgs e)
        {
            comboBoxCinema.DataSource = Cinema.BacaData();
            comboBoxCinema.DisplayMember = "Nama_cabang";

            comboBoxFilm.DataSource = Film.BacaData();
            comboBoxFilm.DisplayMember = "Judul";

            //comboBoxStudio.DataSource = StudioCol.BacaData();
            comboBoxStudio.DisplayMember = "Judul";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (checkBoxI.Checked)
            {
                JadwalFilm jf = new JadwalFilm();
                jf.TanggalPutar = dateTimePickerTanggal.Value;
                jf.JamPemutaran = "I";
                MessageBox.Show(jf.JamPemutaran);
                PengecekanDouble(jf);
            }
            if (checkBoxII.Checked)
            {
                JadwalFilm jf = new JadwalFilm();
                jf.TanggalPutar = dateTimePickerTanggal.Value;
                jf.JamPemutaran = "II";
                MessageBox.Show(jf.JamPemutaran);
                PengecekanDouble(jf);
            }
            if (checkBoxIII.Checked)
            {
                JadwalFilm jf = new JadwalFilm();
                jf.TanggalPutar = dateTimePickerTanggal.Value;
                jf.JamPemutaran = "III";
                MessageBox.Show(jf.JamPemutaran);
                PengecekanDouble(jf);
            }
            if (checkBoxIV.Checked)
            {
                JadwalFilm jf = new JadwalFilm();
                jf.TanggalPutar = dateTimePickerTanggal.Value;
                jf.JamPemutaran = "IV";
                MessageBox.Show(jf.JamPemutaran);
                PengecekanDouble(jf);
            }
        }

        private void PengecekanDouble(JadwalFilm jf) //kalau ada data yang double dia nggak masuk
        {
            bool check = true;
            foreach(JadwalFilm x in ListJF)
            {
                if(jf.TanggalPutar==x.TanggalPutar && jf.JamPemutaran == x.JamPemutaran) { check = false; break; }
            }
            //masih harus dicek cinema dan studionya
            if (check)
            {
                ListJF.Add(jf);
                loadDataGrid();
            }
        }

        private void loadDataGrid()
        {
            dataGridViewInput.Rows.Clear();
            foreach (JadwalFilm jf in ListJF)
            {
                dataGridViewInput.Rows.Add(comboBoxFilm.Text, comboBoxCinema.Text, comboBoxStudio.Text, jf.TanggalPutar.ToString("yyyy-MM-dd"), jf.JamPemutaran);
            }
            if (dataGridViewInput.Rows.Count >= 1 && dataGridViewInput.Columns.Count == 5)
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
                dataGridViewInput.Columns.Add(bcolHapus);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film f = (Film)comboBoxFilm.SelectedItem;
            labelSinopsis.Text = f.Sinopsis.ToString();
            labelDurasi.Text = f.Durasi.ToString();
        }
    }
}
