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
            if (p.Roles == "ADMIN") { listInvoice = Invoice.DisplayInvoice(); }
            else { listInvoice = Invoice.DisplayInvoiceKasir(); }
            dataGridViewHasil.DataSource = listInvoice;
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kriteria = comboBoxCari.Text.Replace(" ", "_").Replace("Tanggal", "tgl");
            string nilai = textBoxCari.Text;
            string order = comboBoxUrut.Text.Replace(" ", "_").Replace("Tanggal", "tgl");
            listInvoice = Invoice.DisplayInvoice(kriteria, nilai, order);
            dataGridViewHasil.DataSource = listInvoice;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            listInvoice = Invoice.DisplayInvoice(comboBoxCari.Text, textBoxCari.Text);
            dataGridViewHasil.DataSource = listInvoice;
        }

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCari_SelectedIndexChanged(sender, e);
        }
    }
}
