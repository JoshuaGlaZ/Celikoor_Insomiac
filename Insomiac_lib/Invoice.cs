using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class Invoice
    {
        private string id;
        DateTime tanggal;
        int grand_total;
        int diskon_nominal;
        Konsumen pelanggan;
        Pegawai kasir;
        string status;
/*        List <Tiket>
Tunggu Class Tiket*/
        public Invoice()
        {
            Id = "";
            Tanggal = DateTime.Now;
            Grand_total = 0;
            Diskon_nominal = 0;
            Pelanggan = new Konsumen();
            Kasir = new Pegawai();
            Status = "";
        }

        public Invoice(string id, DateTime tanggal, int grand_total, int diskon_nominal, Konsumen pelanggan, Pegawai kasir, string status)
        {
            Id = id;
            Tanggal = tanggal;
            Grand_total = grand_total;
            Diskon_nominal = diskon_nominal;
            Pelanggan = pelanggan;
            Kasir = kasir;
            Status = status;
        }

        public string Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int Grand_total { get => grand_total; set => grand_total = value; }
        public int Diskon_nominal { get => diskon_nominal; set => diskon_nominal = value; }
        public Konsumen Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }

        public static void CreateInvoice(Invoice newInv)
        {
            string perintah = "INSERT INTO `invoices` (`tanggal`, `grand_total`, `diskon_nominal`, `konsumens_id`, `kasir_id`, `status`)" +
                "VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + newInv.Grand_total + "', '" + newInv.Diskon_nominal + "', '" + newInv.Pelanggan.Id.ToString() + "', '" + newInv.Kasir.Id.ToString() + "', 'PENDING');";
            Koneksi.JalankanPerintah(perintah); 
        }
        public static Invoice DisplayInvoice(string id)
        {
            Invoice newInv = new Invoice();
            string perintah = "SELECT * from invoices WHERE id = '" + id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah); 
            if(hasil.Read() == true)
            {
                newInv.Id = id;
                newInv.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                newInv.Grand_total = hasil.GetInt32(2);
                newInv.Diskon_nominal = hasil.GetInt32(3);
                Konsumen konsumen = Konsumen.BacaData(hasil.GetInt32(4));
                Pegawai kasir = Pegawai.BacaData(hasil.GetInt32(5));
                newInv.Status = hasil.GetString(6);
                return newInv; 
            }
            else
            {
                return null; 
            }
        }
        public static void UpdateStatus(int id)
        {
            string perintahUpdate = ""; 
            Invoice newInv = new Invoice();
            string perintah = "SELECT * from invoices WHERE id = '" + id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                newInv.Status = hasil.GetString(6);
            }
            if(newInv.Status == "PENDING")
            {
                perintahUpdate = "UPDATE `invoices` SET `status` = 'VALIDASI' WHERE `id` = '"+id+"';"; 
            }
            else if (newInv.Status == "VALIDASI")
            {
                perintahUpdate = "UPDATE `invoices` SET `status` = 'TERBAYAR' WHERE `id` = '" + id + "';";
            }
            Koneksi.JalankanPerintah(perintahUpdate); 
        }
    } 
}
