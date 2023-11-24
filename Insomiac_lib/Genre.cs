using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Genre
    {
        private int id;
        private string namaGenre;
        private string deskripsi;

        public int Id { get => id; set => id = value; }
        public string NamaGenre { get => namaGenre; set => namaGenre = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public Genre(int id, string namaGenre, string deskripsi)
        {
            this.Id = id;
            this.NamaGenre = namaGenre;
            this.Deskripsi = deskripsi;
        }
        public Genre()
        {
            Id = 0;
            NamaGenre = "";
            Deskripsi = ""; 
        }

        public static List<Genre> BacaData()
        {
            List<Genre> lst = new List<Genre>();
            string perintah = "SELECT * FROM genres;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Genre c = new Genre();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.NamaGenre  = msdr.GetValue(1).ToString();
                c.Deskripsi = msdr.GetValue(2).ToString();
                lst.Add(c);
            }
            return lst;
        }

        public static List<Genre> BacaData(string kriteria, string nilai)
        {
            List<Genre> lst = new List<Genre>();
            string perintah = "SELECT * FROM genres WHERE " + kriteria + " LIKE \'%" + nilai + "%\';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Genre c = new Genre();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.NamaGenre = msdr.GetValue(1).ToString();
                c.Deskripsi = msdr.GetValue(2).ToString();
                lst.Add(c);
            }
            return lst;
        }

        public static Genre BacaData(int id)
        {
            string perintah = "SELECT * FROM genres WHERE id='" + id + "';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Genre c = new Genre();
                c.Id = int.Parse(msdr.GetValue(0).ToString());
                c.NamaGenre = msdr.GetValue(1).ToString();
                c.Deskripsi = msdr.GetValue(2).ToString();
                return c;
            }
            else { return null; }
        }

        public static void TambahData(Genre c)
        {
            string perintah = "INSERT INTO genres (nama, deskripsi) " +
                "VALUES ('" + c.NamaGenre + "', '" + c.Deskripsi + "');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Genre c)
        {
            string perintah = "DELETE FROM genres WHERE id=" + c.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
