using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Cinema
    {
        private int id;
        private string nama_cabang;
        private string alamat;
        private DateTime tgl_buka;
        private string kota;

        public Cinema(string nama_cabang, string alamat, DateTime tgl_buka, string kota)
        {
            Nama_cabang = nama_cabang;
            Alamat = alamat;
            Tgl_buka = tgl_buka;
            Kota = kota;
        }
        public Cinema()
        {
            Nama_cabang = "";
            Alamat = "";
            Tgl_buka = DateTime.Now;
            Kota = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tgl_buka { get => tgl_buka; set => tgl_buka = value; }
        public string Kota { get => kota; set => kota = value; }

        public static List<Cinema> BacaData()
        {
            List<Cinema> lst = new List<Cinema>();
            string perintah = "SELECT * FROM cinemas;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Cinema c = new Cinema();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama_cabang = msdr.GetValue(1).ToString();
                c.Alamat = msdr.GetValue(2).ToString();
                c.Tgl_buka = DateTime.Parse(msdr.GetValue(3).ToString());
                c.Kota = msdr.GetValue(4).ToString();
                lst.Add(c);
            }
            return lst;
        }

        public static List<Cinema> BacaData(string kriteria, string nilai)
        {
            List<Cinema> lst = new List<Cinema>();
            string perintah = "SELECT * FROM cinemas WHERE " + kriteria + " LIKE \'%" + nilai + "%\';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Cinema c = new Cinema();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama_cabang = msdr.GetValue(1).ToString();
                c.Alamat = msdr.GetValue(2).ToString();
                c.Tgl_buka = DateTime.Parse(msdr.GetValue(3).ToString());
                c.Kota = msdr.GetValue(4).ToString();
                lst.Add(c);
            }
            return lst;
        }

        public static Cinema BacaData(int id)
        {
            string perintah = "SELECT * FROM cinemas WHERE id='" + id + "';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Cinema c = new Cinema();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama_cabang = msdr.GetValue(1).ToString();
                c.Alamat = msdr.GetValue(2).ToString();
                c.Tgl_buka = DateTime.Parse(msdr.GetValue(3).ToString());
                c.Kota = msdr.GetValue(4).ToString();
                return c;
            }
            else { return null; }
        }

        public static void TambahData(Cinema c)
        {
            string perintah = "INSERT INTO cinemas (nama_cabang, alamat, tgl_dibuka, kota) " +
                "VALUES ('" + c.Nama_cabang + "', '" + c.Alamat + "', '" + c.Tgl_buka.ToString("yyyy-MM-dd") + "', '" + c.Kota + "');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void UbahData(Cinema c)
        {
            string perintah = "UPDATE cinemas SET " +
                "nama_cabang='" + c.Nama_cabang + "', " +
                "alamat='" + c.Alamat + "', " +
                "tgl_dibuka='" + c.Tgl_buka.ToString("yyyy-MM-dd") + "', " +
                "kota='" + c.Kota + "' " +
                "WHERE id='" + c.Id + "';";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Cinema c)
        {
            string perintah = "DELETE FROM cinemas WHERE id=" + c.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
