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
        List<Ticket> listTiket; 
        public Invoice()
        {
            Id = "";
            Tanggal = DateTime.Now;
            Grand_total = 0;
            Diskon_nominal = 0;
            Pelanggan = new Konsumen();
            Kasir = new Pegawai();
            Status = "";
            ListTiket = new List<Ticket>();
        }

        public Invoice(string id, DateTime tanggal, int grand_total, int diskon_nominal, Konsumen pelanggan, Pegawai kasir)
        {
            Id = id;
            Tanggal = tanggal;
            Grand_total = grand_total;
            Diskon_nominal = diskon_nominal;
            Pelanggan = pelanggan;
            Kasir = kasir;
        }

        public string Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int Grand_total { get => grand_total; set => grand_total = value; }
        public int Diskon_nominal { get => diskon_nominal; set => diskon_nominal = value; }
        public Konsumen Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }
        public List<Ticket> ListTiket { get => listTiket; private set => listTiket = value; }

        public static void CreateInvoice(Invoice newInv)
        {
            string perintah = "INSERT INTO `invoices` (`tanggal`, `grand_total`, `diskon_nominal`, `konsumens_id`, `kasir_id`, `status`)" +
                "VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + newInv.Grand_total + "', '" + newInv.Diskon_nominal + "', '" + newInv.Pelanggan.Id.ToString() + "', '" + newInv.Kasir.Id.ToString() + "', 'PENDING');";
            Koneksi.JalankanPerintah(perintah); 
            
            foreach(Ticket tiket in newInv.ListTiket)
            {
                perintah = "INSERT INTO `tikets` (`invoices_id`,`nomor_kursi`, `status_hadir`, `operator_id`, `harga`, `jadwal_film_id`, `studios_id`, `films_id`)" +
                    "VALUES ('"+ newInv.Id +"','"+tiket.Nomor_kursi+"', '"+tiket.Status+"', '"+0+"', '"+tiket.Harga+"', '"+tiket.JadwalFilm+"', '"+tiket.Studio+"', '"+tiket.JadwalFilm+"')";
                Koneksi.JalankanPerintah(perintah);
            }
        }
        public void AddTicket(string nomor_kursi, double harga, JadwalFilm jadwalFilm, Studio studio, Film film, Pegawai tOp)
        {
            Ticket tiket = new Ticket(nomor_kursi, harga, jadwalFilm, studio, film, tOp);
            ListTiket.Add(tiket); 
        }
        public static void UpdateTicket(string barcode)
        {
            string invID = barcode.Substring(0, 3);
            string nomorKursi = barcode.Substring(3);

            string perintah = "UPDATE tikets SET status_hadir = 1 WHERE SUBSTRING(invoices_id,0,3) = '" + invID + "'AND nomor_kursi = '" + nomorKursi + "';";
            Koneksi.JalankanPerintah(perintah);
        }
        public static List<string> BacaKursi(JadwalFilm jadwalFilm, Film film, Studio studio)
        {
            string perintah = "SELECT tikets.nomor_kursi FROM tikets" +
                " WHERE jadwal_film_id = '"+ jadwalFilm.Id.ToString()+"' AND studios_id = '"+studio.Id.ToString()+"' AND films_id = '"+film.Id.ToString()+"';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<string> listKursi = new List<string>();
            while(hasil.Read())
            {
                string nomorKursi = hasil.GetString(0);
                listKursi.Add(nomorKursi);
            }
            return listKursi; 
        }
        public static List<Invoice> DisplayInvoice()
        {
            string perintah = "SELECT * from invoices";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Invoice> lst = new List<Invoice>();
            while (hasil.Read() == true)
            {
                Invoice newInv = new Invoice();
                newInv.Id = hasil.GetString(0);
                newInv.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                newInv.Grand_total = hasil.GetInt32(2);
                newInv.Diskon_nominal = hasil.GetInt32(3);
                Konsumen konsumen = Konsumen.BacaData(hasil.GetInt32(4));
                Pegawai kasir = Pegawai.BacaData(hasil.GetInt32(5));
                newInv.Status = hasil.GetString(6);
                lst.Add(newInv);
            }
            return lst;
        }
        public static List<Invoice> DisplayInvoice(string kriteria, string nilai)
        {
            string perintah = "SELECT * from invoices WHERE '" + kriteria + "' LIKE '%" + nilai + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Invoice> lst = new List<Invoice>();
            while (hasil.Read() == true)
            {
                Invoice newInv = new Invoice();
                newInv.Id = hasil.GetString(0);
                newInv.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                newInv.Grand_total = hasil.GetInt32(2);
                newInv.Diskon_nominal = hasil.GetInt32(3);
                Konsumen konsumen = Konsumen.BacaData(hasil.GetInt32(4));
                Pegawai kasir = Pegawai.BacaData(hasil.GetInt32(5));
                newInv.Status = hasil.GetString(6);
                lst.Add(newInv);
            }
            return lst;
        }
        public static List<Invoice> DisplayInvoice(string kriteria, string nilai, string order)
        {
            string perintah = "SELECT * from invoices WHERE '" + kriteria + "' LIKE '%" + nilai + "%' ORDER BY '" + order + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Invoice> lst = new List<Invoice>();
            while (hasil.Read() == true)
            {
                Invoice newInv = new Invoice();
                newInv.Id = hasil.GetString(0);
                newInv.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                newInv.Grand_total = hasil.GetInt32(2);
                newInv.Diskon_nominal = hasil.GetInt32(3);
                Konsumen konsumen = Konsumen.BacaData(hasil.GetInt32(4));
                Pegawai kasir = Pegawai.BacaData(hasil.GetInt32(5));
                newInv.Status = hasil.GetString(6);
                lst.Add(newInv);
            }
            return lst;
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
