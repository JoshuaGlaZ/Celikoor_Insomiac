﻿using System;
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
    public partial class FormTambahStudio : Form
    {
        public FormTambahStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "") { throw new Exception("Nama"); }
                else if (numericUpDownKapasitas.Value % 4 != 0) { MessageBox.Show("Kapasitas harus berjumlah kelipatan 4"); }
                else if (numericUpDownKapasitas.Value > 84 || numericUpDownKapasitas.Value < 4) { MessageBox.Show("Kapasitas harus berjumlah di rentang 4 - 84"); }
                else if (comboBoxJenisStudio.SelectedIndex == -1) { throw new Exception("Jenis Studio"); }
                else if (comboBoxCinema.SelectedIndex == -1) { throw new Exception("Cinema"); }
                else if (textBoxHargaWeekday.Text == "") { throw new Exception("Harga weekday"); }
                else if (textBoxHargaWeekend.Text == "") { throw new Exception("Harga weekend"); }
                else
                {
                    Studio s = new Studio();
                    s.Nama = textBoxNama.Text;
                    s.Kapasitas = (int)numericUpDownKapasitas.Value;
                    s.Jenis = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                    s.Bioskop = (Cinema)comboBoxCinema.SelectedItem;
                    s.Harga_weekday = int.Parse(textBoxHargaWeekday.Text);
                    s.Harga_weekend = int.Parse(textBoxHargaWeekend.Text);

                    Studio.MasukanData(s);
                    MessageBox.Show("Data berhasil ditambah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data " + ex.Message + " belum diisi");
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {
            comboBoxCinema.DataSource = Cinema.BacaData();
            comboBoxCinema.DisplayMember = "nama_cabang";

            comboBoxJenisStudio.DataSource = JenisStudio.BacaData();
            comboBoxJenisStudio.DisplayMember = "nama";
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            numericUpDownKapasitas.Value = 4;
            comboBoxJenisStudio.SelectedItem = null;
            comboBoxCinema.SelectedItem = null;
            textBoxHargaWeekday.Clear();
            textBoxHargaWeekend.Clear();
        }
    }
}
