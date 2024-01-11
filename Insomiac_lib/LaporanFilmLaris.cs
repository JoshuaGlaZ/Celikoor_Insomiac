using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class LaporanFilmLaris
    {
        private Film film;
        private int jumlah_penonton;
        private string bulan;

        public LaporanFilmLaris()
        {
            Film = new Film();
            Jumlah_penonton = 0;
            Bulan = "";
        }

        public LaporanFilmLaris(Film film, int jumlah_penonton, string bulan)
        {
            Film = film;
            Jumlah_penonton = jumlah_penonton;
            Bulan = bulan;
        }

        public Film Film { get => film; set => film = value; }
        public int Jumlah_penonton { get => jumlah_penonton; set => jumlah_penonton = value; }
        public string Bulan { get => bulan; set => bulan = value; }

        public static List<LaporanFilmLaris> BacaData()
        {
            List<LaporanFilmLaris> listLaporan = new List<LaporanFilmLaris>();
            string perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Penonton', MONTHNAME(jf.tanggal) as Bulan FROM films f " +
                "INNER JOIN tikets t ON f.id = t.films_id INNER JOIN jadwal_films jf ON t.jadwal_film_id = jf.id " +
                "WHERE YEAR(jf.tanggal) = 2023 AND t.status_hadir = 1 GROUP BY f.Judul, Bulan ORDER BY COUNT(t.films_id) DESC, CASE WHEN MONTH(jf.tanggal) = 0 THEN 99 ELSE MONTH(jf.tanggal) END;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanFilmLaris laporan = new LaporanFilmLaris();
                laporan.Film = Film.BacaData("judul", msdr.GetString(0))[0];
                laporan.Jumlah_penonton = msdr.GetInt32(1); 
                laporan.Bulan = msdr.GetString(2);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }
        public static List<LaporanFilmLaris> BacaData(string kriteria, string nilai, string urut)
        {
            List<LaporanFilmLaris> listLaporan = new List<LaporanFilmLaris>();
            string perintah;
            string order;
            if (urut == "MONTHNAME(jf.tanggal)")
            {
                order = "ORDER BY CASE WHEN MONTH(jf.tanggal) = 0 THEN 99 ELSE MONTH(jf.tanggal) END";
            }
            else
            {
                order = "ORDER BY " + urut + ", CASE WHEN MONTH(jf.tanggal) = 0 THEN 99 ELSE MONTH(jf.tanggal) END";
            }
            if(kriteria != "COUNT(t.films_id)")
            {
                perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Penonton', MONTHNAME(jf.tanggal) as Bulan FROM films f " +
                   "INNER JOIN tikets t ON f.id = t.films_id INNER JOIN jadwal_films jf ON t.jadwal_film_id = jf.id " +
                   "WHERE YEAR(jf.tanggal) = 2023 AND t.status_hadir = 1 AND " + kriteria + " LIKE '%" + nilai + "%' GROUP BY f.Judul, Bulan  " +
                   order + ";";
            }
            else if (string.IsNullOrEmpty(nilai))
            {
                perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Penonton', MONTHNAME(jf.tanggal) as Bulan FROM films f " +
                    "INNER JOIN tikets t ON f.id = t.films_id INNER JOIN jadwal_films jf ON t.jadwal_film_id = jf.id " +
                    "WHERE YEAR(jf.tanggal) = 2023 AND t.status_hadir = 1 GROUP BY f.Judul, Bulan " + order + ";";
            }
            else
            {
                perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Penonton', MONTHNAME(jf.tanggal) as Bulan FROM films f " +
                     "INNER JOIN tikets t ON f.id = t.films_id INNER JOIN jadwal_films jf ON t.jadwal_film_id = jf.id " +
                     "WHERE YEAR(jf.tanggal) = 2023 AND t.status_hadir = 1 GROUP BY f.Judul, Bulan HAVING " + kriteria + " = '" +
                    nilai + "' " + order + ";";
            }              
                
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanFilmLaris laporan = new LaporanFilmLaris();
                laporan.Film = Film.BacaData("judul", msdr.GetString(0))[0];
                laporan.Jumlah_penonton = msdr.GetInt32(1);
                laporan.Bulan = msdr.GetString(2);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }
    }
}
