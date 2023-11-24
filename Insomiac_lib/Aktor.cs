using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Aktor  
    {
        private int id;
        private string nama;
        private DateTime tglLahir;
        private string gender;
        private string negaraAsal;

        public Aktor()
        {
            Nama = "";
            TglLahir = DateTime.Now;
            Gender = "";
            NegaraAsal = "";
        }

        public Aktor(int id, string nama, DateTime tglLahir, string gender, string negaraAsal)
        {
            Id = id;
            Nama = nama;
            TglLahir = tglLahir;
            Gender = gender;
            NegaraAsal = negaraAsal;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }

        public static List<Aktor> BacaData()
        {
            List<Aktor> lst = new List<Aktor>();
            string perintah = "SELECT * FROM aktors;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Aktor c = new Aktor();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama = msdr.GetValue(1).ToString();
                c.TglLahir = DateTime.Parse(msdr.GetValue(2).ToString());
                c.Gender = msdr.GetValue(3).ToString();
                c.NegaraAsal = msdr.GetValue(4).ToString();
                lst.Add(c);
            }
            return lst;
        }

        public static List<Aktor> BacaData(string kriteria, string nilai)
        {
            List<Aktor> lst = new List<Aktor>();
            string perintah = "SELECT * FROM aktors WHERE " + kriteria + " LIKE \'%" + nilai + "%\';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Aktor c = new Aktor();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama = msdr.GetValue(1).ToString();
                c.TglLahir = DateTime.Parse(msdr.GetValue(2).ToString());
                c.Gender = msdr.GetValue(3).ToString();
                c.NegaraAsal = msdr.GetValue(4).ToString();
                lst.Add(c);
            }
            return lst;
        }
        public static List<Aktor> BacaData(string kolom, string cari, string urut)
        {
            string perintah = "SELECT * FROM aktors WHERE " + kolom + " LIKE '%" + cari + "%' ORDER BY " + urut + ";";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Aktor> data = new List<Aktor>();
            while (msdr.Read())
            {
                Aktor c = new Aktor();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama = msdr.GetValue(1).ToString();
                c.TglLahir = DateTime.Parse(msdr.GetValue(2).ToString());
                c.Gender = msdr.GetValue(3).ToString();
                c.NegaraAsal = msdr.GetValue(4).ToString();
                data.Add(c);
            }
            return data;
        }


        public static Aktor BacaData(int id)
        {
            string perintah = "SELECT * FROM aktors WHERE id='" + id + "';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Aktor c = new Aktor();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.Nama = msdr.GetValue(1).ToString();
                c.TglLahir = DateTime.Parse(msdr.GetValue(2).ToString());
                c.Gender = msdr.GetValue(3).ToString();
                c.NegaraAsal = msdr.GetValue(4).ToString();
                return c; 
            }
            else { return null; }
        }

        public static void TambahData(Aktor c)
        {
            string perintah = "INSERT INTO aktors (nama, tgl_lahir, gender, negara_asal) " +
                "VALUES ('" + c.Nama + "', '" + c.TglLahir.ToString("yyyy-MM-dd") + "', '" + c.Gender + "', '" + c.NegaraAsal + "');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void UbahData(Aktor c)
        {
            string perintah = "UPDATE aktors SET " +
                "nama='" + c.Nama + "', " +
                "tgl_lahir='" + c.TglLahir.ToString("yyyy-MM-dd") + "', " +
                "gender='" + c.Gender + "', " +
                "negara_asal='" + c.NegaraAsal + "' " +
                "WHERE id='" + c.Id + "';";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Aktor c)
        {
            string perintah = "DELETE FROM aktors WHERE id=" + c.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }
        public static int CheckUmur(DateTime lahir)
        {
            return (int)((DateTime.Now - lahir).TotalDays / 365);
        }
    }
}
