using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Transactions;
using System.Diagnostics;

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

        private List<Genre_Film> listGenre;
        private List<Aktor_Film> listAktor;
        //private List<Studio> listStudio;

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
            ListGenre = new List<Genre_Film>();
            ListAktor = new List<Aktor_Film>();
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
            ListGenre = new List<Genre_Film>();
            ListAktor = new List<Aktor_Film>();
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
        public List<Genre_Film> ListGenre { get => listGenre; private set => listGenre = value; }
        public List<Aktor_Film> ListAktor { get => listAktor; private set => listAktor = value; }
        //public List<Studio> ListStudio { get => listStudio; private set => listStudio = value; }

        public string tampilkanAktor()
        {
            string data = "";
            int count = 0;
            List<Aktor_Film> listAktor = BacaDataAktor("", Id.ToString(), "UTAMA");
            foreach (Aktor_Film af in listAktor)
            {
                data += af.Atr.Nama;
                count++;
                if (count < 2 && listAktor.Count != 1) { data += ", "; }
                else if (count == 2 && listAktor.Count == 2) { break; }
                else if (count == 2 && listAktor.Count > 2) { data += ",..."; break; }
            }
            return data;
        }

        public string tampilkanGenre()
        {
            string data = "";
            int count =0;
            List<Genre_Film> listGenre = BacaDataGenre(Id.ToString());
            foreach (Genre_Film gr in listGenre)
            {
                data += gr.Gnr.NamaGenre;
                count++;
                if(count!= listGenre.Count) { data += ", "; }
            }
            return data;
        }

        public static List<Film> BacaData()
        {
            string perintah = "SELECT * FROM films;";
            List<Film> lst = new List<Film>();

            using (MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah))
            {
                while (msdr.Read())
                {
                    Film f = BacaFilm(msdr);
                    lst.Add(f);
                }
            }
            return lst; 
        }

        public static List<Film> BacaData(string kriteria, string nilai)
        {
            string perintah = "SELECT * FROM films WHERE " + kriteria + " LIKE '%" + nilai + "%';";
            if (kriteria == "id") { perintah = "SELECT * FROM films WHERE id="+nilai+";"; }
            List<Film> lst = new List<Film>();

            using (MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah))
            {
                while (msdr.Read())
                {
                    Film f = BacaFilm(msdr);
                    lst.Add(f);
                }
            }
            return lst;
        }

        public static List<Film> BacaData(string kriteria, string nilai, string urut)
        {
            string perintah = "SELECT * FROM films WHERE " + kriteria + " LIKE '%" + nilai + "%' ORDER BY " + urut + ";";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Film> lst = new List<Film>();
            while (msdr.Read())
            {
                Film f = BacaFilm(msdr);
                lst.Add(f);
            }
            return lst;
        }

        public static Film BacaData(string id)
        {
            string perintah = "SELECT * FROM films WHERE id='" + id + "';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Film f = BacaFilm(msdr);
                f.ListAktor = f.BacaDataAktor(idFilm: f.Id.ToString());
                f.ListGenre = f.BacaDataGenre(idFilm: f.Id.ToString());
                return f;
            }
            return null;
        }

        private static Film BacaFilm(MySqlDataReader msdr)
        {
            Film f = new Film();
            f.Id = int.Parse(msdr.GetValue(0).ToString());
            f.Judul = msdr.GetValue(1).ToString();
            f.Sinopsis = msdr.GetValue(2).ToString();
            f.Tahun = int.Parse(msdr.GetValue(3).ToString());
            f.Durasi = int.Parse(msdr.GetValue(4).ToString());
            f.Kelompok = Kelompok.BacaData(msdr.GetInt32(5));
            f.Bahasa = msdr.GetValue(6).ToString();
            f.IsSubIndo = int.Parse(msdr.GetValue(7).ToString()) == 1 ? "iya" : "tidak";
            f.CoverPath = msdr.GetValue(8).ToString();
            f.Diskon = double.Parse(msdr.GetValue(9).ToString());
            return f;
        }

        public List<Aktor_Film> BacaDataAktor(string idAktor="", string idFilm="", string peran="")
        {
            List<Aktor_Film> lst = new List<Aktor_Film>();
            string perintah = "SELECT * FROM aktor_film";
            if (idAktor != "" && idFilm != "" && peran!="")
            {
                perintah += " WHERE aktors_id=" + idAktor + " AND films_id=" + idFilm + " AND peran='" + peran+ "';";
            }
            else if (idAktor != "")
            {
                perintah += " WHERE aktors_id=" + idAktor + ";";
            }
            else if (idFilm != "" && peran != "")
            {
                perintah += " WHERE films_id=" + idFilm +" AND peran='" + peran + "';";
            }
            else if (idFilm != "")
            {
                perintah += " WHERE films_id=" + idFilm + ";";
            }
            else if (peran != "")
            {
                perintah += " WHERE peran='" + peran + "';";
            }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Aktor_Film af = new Aktor_Film();
                af.Atr = Aktor.BacaData(msdr.GetInt32(0));
                af.Peran = msdr.GetString(2);
                lst.Add(af);
            }
            return lst;
        }

        public List<Genre_Film> BacaDataGenre(string idFilm="", string idGenre="")
        {
            List<Genre_Film> lst = new List<Genre_Film>();
            string perintah = "SELECT * FROM genre_film";
            if (idFilm != "" && idGenre != "")
            {
                perintah += " WHERE films_id=" + idFilm + " AND genres_id=" + idGenre + ";";
            }
            else if (idFilm != "")
            {
                perintah += " WHERE films_id=" + idFilm + ";";
            }
            else if (idGenre != "")
            {
                perintah += " WHERE genres_id=" + idGenre + ";";
            }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Genre_Film gf = new Genre_Film();
                gf.Gnr = Genre.BacaData(msdr.GetInt32(1));
                lst.Add(gf);
            }
            return lst;
        }

        public void AddAktor(Aktor a, string peran)
        {
            Aktor_Film af = new Aktor_Film(a, peran);
            ListAktor.Add(af);
        }
        public void AddGenre(Genre_Film gf)
        {
            ListGenre.Add(gf);
        }

        public string ToStringAktorGenre()
        {
            string data = ".\nAktor = ";
            string aktorData = string.Join(", ", listAktor.Select(af => $"{af.Atr.Nama}/{af.Peran}"));
            data += aktorData + ".\nGenre = ";
            string genreData = string.Join(", ", listGenre.Select(gf => gf.Gnr.NamaGenre));
            data += genreData + ".";
            return data;
        }

        public static void TambahData(Film f)
        {
            MySqlDataReader msdrId = Koneksi.JalankanPerintahId("SHOW TABLE STATUS LIKE 'films';");
            if (msdrId.Read())
            {
                f.Id = Convert.ToInt32(msdrId["Auto_increment"]);
                using (TransactionScope ts = new TransactionScope())
                {
                    try
                    {
                        Koneksi k = new Koneksi();
                        string perintah = "INSERT INTO films (judul, sinopsis, tahun, durasi, kelompoks_id, bahasa," +
                        "is_sub_indo, cover_image, diskon_nominal) VALUES ('" + f.Judul + "', '" + f.Sinopsis +
                            "', '" + f.Tahun + "', '" + f.Durasi + "', '" + f.Kelompok.Id + "', '" + f.Bahasa + "', '" +
                            (f.IsSubIndo == "iya" ? "1" : "0") + "', '" + f.CoverPath + "', '" + f.Diskon + "');";
                        Koneksi.JalankanPerintah(perintah, k);
                        TambahDataAktor(f, k);
                        TambahDataGenre(f, k);
                        ts.Complete();
                    }
                    catch (Exception ex)
                    {
                        ts.Dispose();
                        throw new Exception(ex.Message);
                    }
                }
            } 
        }


        private static void TambahDataGenre(Film f, Koneksi k)
        {
            try
            {
                foreach (Genre_Film gf in f.ListGenre)
                {
                    string perintah = "INSERT INTO genre_film (films_id, genres_id) " +
                        "VALUES ('" + f.Id + "', '" + gf.Gnr.Id + "');";
                    Koneksi.JalankanPerintah(perintah, k);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambah genre. Error = " +  ex.Message);
            }
        }

        private static void TambahDataAktor(Film f, Koneksi k)
        {
            try
            {
                foreach (Aktor_Film af in f.ListAktor)
                {
                    string perintah = "INSERT INTO aktor_film (aktors_id, films_id, peran) " +
                    "VALUES ('" + af.Atr.Id + "', '" + f.Id + "', '" + af.Peran + "');";
                    Koneksi.JalankanPerintah(perintah, k);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambah aktor. Error = " + ex.Message);
            }
        }

        public static void HapusData(Film f)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    Koneksi k = new Koneksi();
                    HapusDataAktor(f, k);
                    HapusDataGenre(f, k);
                    string perintah = "DELETE FROM films WHERE id=" + f.Id + ";";
                    Koneksi.JalankanPerintah(perintah, k);
                    ts.Complete();
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }

        private static void HapusDataGenre(Film f, Koneksi k)
        {
            string perintah = "DELETE FROM genre_film WHERE films_id='" + f.Id + "';";
            Koneksi.JalankanPerintah(perintah, k);
        }

        private static void HapusDataAktor(Film f, Koneksi k)
        {
            string perintah = "DELETE FROM aktor_film WHERE films_id='" + f.Id + "';";
            Koneksi.JalankanPerintah(perintah, k);
        }

        public static void UbahData(Film f)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    Koneksi k = new Koneksi();
                    string perintah = "UPDATE films SET judul='" + f.Judul + "', sinopsis='" + f.Sinopsis +
                        "', tahun='" +f.Tahun + "', durasi='" +  f.Durasi + "', kelompoks_id='" + f.Kelompok.Id +
                        "', bahasa='" + f.Bahasa + "', is_sub_indo='" + (f.isSubIndo == "iya" ? "1" : "0")  + 
                        "', cover_image='" + f.CoverPath + "', diskon_nominal='"+ f.Diskon + "' WHERE id='" + f.Id + "';";
                    Koneksi.JalankanPerintah(perintah, k);
                    HapusDataAktor(f, k);
                    HapusDataGenre(f, k);
                    TambahDataAktor(f, k);
                    TambahDataGenre(f, k);
                    ts.Complete();
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }
        public override string ToString()
        {
            return Judul; 
        }
    }
}
