using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Insomiac_lib
{
    public class Film
    {
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompok;
        private string bahasa;
        private string isSubIndo;
        private string coverPath;
        private double diskon;
        
        //private List<Genre> listGenre;
        //private List<Aktor> listAktor;
        private List<Studio> listStudio;

        public Film()
        {
            Judul = "";
            Sinopsis = "";
            Tahun = 0;
            Durasi = 0;
            Kelompok = new Kelompok();
            Bahasa = "";
            IsSubIndo = "";
            CoverPath = "";
            Diskon = 0.0;
        }

        public Film(string judul, string sinopsis, int tahun, int durasi, Kelompok kelompok, string bahasa, string isSubIndo, string coverPath, double diskon)
        {
            Judul = judul;
            Sinopsis = sinopsis;
            Tahun = tahun;
            Durasi = durasi;
            Kelompok = kelompok;
            Bahasa = bahasa;
            IsSubIndo = isSubIndo;
            CoverPath = coverPath;
            Diskon = diskon;
        }

        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok Kelompok { get => kelompok; set => kelompok = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public string IsSubIndo { get => isSubIndo; set => isSubIndo = value; }
        public string CoverPath { get => coverPath; set => coverPath = value; }
        public double Diskon { get => diskon; set => diskon = value; }
        //public List<Genre> ListGenre { get => listGenre; set => listGenre = value; }
        //public List<Aktor> ListAktor { get => listAktor; set => listAktor = value; }
        public List<Studio> ListStudio { get => listStudio; set => listStudio = value; }

        public static List<Film> BacaData()
        {
            string perintah = "SELECT * FROM films;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Film> lst = new List<Film>();
            while (msdr.Read())
            {
                Film f = new Film();
                f.Id = int.Parse(msdr.GetValue(0).ToString());
                f.Judul = msdr.GetValue(1).ToString();
                f.Sinopsis = msdr.GetValue(2).ToString();
                f.Tahun = int.Parse(msdr.GetValue(3).ToString());
                f.Durasi = int.Parse(msdr.GetValue(4).ToString());
                Kelompok k = new Kelompok();
                k.Id = int.Parse(msdr.GetValue(5).ToString());
                f.Kelompok = k;
                f.Bahasa = msdr.GetValue(6).ToString();
                f.IsSubIndo = int.Parse(msdr.GetValue(7).ToString()) == 0 ? "iya" : "tidak";
                f.CoverPath = msdr.GetValue(8).ToString();
                f.Diskon = double.Parse(msdr.GetValue(9).ToString());
                lst.Add(f);
            }
            return lst;
        }

        public static List<Film> BacaData(string kriteria, string nilai)
        {
            string perintah = "SELECT * FROM films WHERE '" + kriteria + "' LIKE '%" + nilai + "%';";
            if (kriteria == "id") { perintah = "SELECT * FROM films WHERE id="+nilai+";"; }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Film> lst = new List<Film>();
            while (msdr.Read())
            {
                Film f = new Film();
                f.Id = int.Parse(msdr.GetValue(0).ToString());
                f.Judul = msdr.GetValue(1).ToString();
                f.Sinopsis = msdr.GetValue(2).ToString();
                f.Tahun = int.Parse(msdr.GetValue(3).ToString());
                f.Durasi = int.Parse(msdr.GetValue(4).ToString());
                Kelompok k = new Kelompok();
                k.Id = int.Parse(msdr.GetValue(5).ToString());
                f.Kelompok = k;
                f.Bahasa = msdr.GetValue(6).ToString();
                f.IsSubIndo = int.Parse(msdr.GetValue(7).ToString()) == 0 ? "iya" : "tidak";
                f.CoverPath = msdr.GetValue(8).ToString();
                f.Diskon = double.Parse(msdr.GetValue(9).ToString());
                lst.Add(f);
            }
            return lst;
        }

        public static List<Film> BacaData(string kriteria, string nilai, string urut)
        {
            string perintah = "SELECT * FROM films WHERE '" + kriteria + "' LIKE '&" + nilai + "&' ORDER BY '" + urut + "';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Film> lst = new List<Film>();
            while (msdr.Read())
            {
                Film f = new Film();
                f.Id = int.Parse(msdr.GetValue(0).ToString());
                f.Judul = msdr.GetValue(1).ToString();
                f.Sinopsis = msdr.GetValue(2).ToString();
                f.Tahun = int.Parse(msdr.GetValue(3).ToString());
                f.Durasi = int.Parse(msdr.GetValue(4).ToString());
                Kelompok k = new Kelompok();
                k.Id = int.Parse(msdr.GetValue(5).ToString());
                f.Kelompok = k;
                f.Bahasa = msdr.GetValue(6).ToString();
                f.IsSubIndo = int.Parse(msdr.GetValue(7).ToString()) == 0 ? "iya" : "tidak" ;
                f.CoverPath = msdr.GetValue(8).ToString();
                f.Diskon = double.Parse(msdr.GetValue(9).ToString());
                lst.Add(f);
            }
            return lst;
        }

        public static void TambahData(Film f)
        {
            string perintah = "INSERT INTO films (judul, sinopsis, tahun, durasi, kelompoks_id, bahasa," +
                "is_sub_indo, cover_image, diskon_nominal) VALUES ('" + f.Judul + "', '" + f.Sinopsis +
                "', '" + f.Tahun + "', '" + f.Durasi + "', '" + f.Kelompok.Id + "', '" + f.Bahasa + "', '" +
                f.isSubIndo + "', '" + f.CoverPath + "', '" + f.Diskon + "');";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
