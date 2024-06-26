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
    public partial class FormMasterInvoice : Form
    {
        List<Invoice> listInvoice = new List<Invoice>();
        public Pegawai p;
        public FormMasterInvoice()
        {
            InitializeComponent();
        }

        private void FormMasterInvoice_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            comboBoxCari.SelectedIndex = 0; comboBoxUrut.SelectedIndex = 0;
            if (p.Roles == "ADMIN") {
                listInvoice = Invoice.DisplayInvoice();
            }
            else { 
                listInvoice = Invoice.DisplayInvoiceKasir();
                if (dataGridViewHasil.Columns.Count==7) {
                    DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                    btnUbah.Name = "UPDATE";
                    btnUbah.HeaderText = "UPDATE";
                    btnUbah.Text = "UPDATE";
                    btnUbah.FlatStyle = FlatStyle.Flat;
                    btnUbah.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    btnUbah.DefaultCellStyle.BackColor = Color.FromArgb(54, 78, 104);
                    btnUbah.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    btnUbah.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(btnUbah);
                }
            }
            dataGridViewHasil.DataSource = listInvoice;
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(p.Roles == "KASIR" && dataGridViewHasil.CurrentCell.OwningColumn.Name == "UPDATE")
            {
                string id = dataGridViewHasil.CurrentRow.Cells["id"].Value.ToString();
                Invoice.UpdateStatus(int.Parse(id), p);
                MessageBox.Show("INVOICE berhasil tervalidasi");
                FormMasterInvoice_Load(this, e);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace(" ", "_").Replace("Konsumen", "konsumens_id").Replace("Kasir", "kasir_id");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace(" ", "_").Replace("Konsumen", "konsumens_id").Replace("Kasir", "kasir_id");
            if (p.Roles == "ADMIN") { listInvoice = Invoice.DisplayInvoice(kriteria, nilai, order); }
            else { listInvoice = Invoice.DisplayInvoiceKasir(kriteria, nilai, order); }
            dataGridViewHasil.DataSource = listInvoice;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari_TextChanged(sender, e);
        }
    }
}
