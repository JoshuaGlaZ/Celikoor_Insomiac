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
        Pegawai ope;
        public FormScanBarcode()
        {
            InitializeComponent();
        }

        private void FormScanBarcode_Load(object sender, EventArgs e)
        {
            FormUtama frmUtama = (FormUtama)this.MdiParent;
            ope = frmUtama.pegawaiLogin;
        }

        private void buttonHadir_Click(object sender, EventArgs e)
        {
            try
            {
                string invoice = textBoxBarcode.Text.Substring(0, 3);
                int checkzero = int.Parse(invoice);
                invoice = checkzero.ToString();

                string rowKursi = textBoxBarcode.Text.Substring(3,1);
                int checkKursi = int.Parse(textBoxBarcode.Text.Substring(4, 2));
                string noKursi = rowKursi + checkKursi.ToString();

                Ticket.CekHadir(invoice, noKursi, ope);
                MessageBox.Show("Tiket telah diupdate");
                textBoxBarcode.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
        }
    }
}
