using Insomiac_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Insomiac
{
    public partial class FormScanBarcode : Form
    {
        public FormScanBarcode()
        {
            InitializeComponent();
        }

        private void FormScanBarcode_Load(object sender, EventArgs e)
        {
            FormUtama frmUtama = (FormUtama)this.MdiParent;
            Pegawai op = frmUtama.pegawaiLogin;
        }

        private void buttonHadir_Click(object sender, EventArgs e)
        {
            try
            {
                string invoice = textBoxBarcode.Text.Substring(0, 3);
                string noKursi = textBoxBarcode.Text.Substring(3);
                Ticket.CekHadir(invoice, noKursi);
                textBoxBarcode.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Masukkan Barcode");
            }

            
        }
    }
}
