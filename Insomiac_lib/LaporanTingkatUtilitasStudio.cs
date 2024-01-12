using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class LaporanTingkatUtilitasStudio
    {
        private Studio studio;
        private int jumlahKursiKosong;
        public Studio Studio { get => studio; set => studio = value; }
        public int JumlahKursiKosong { get => jumlahKursiKosong; set => jumlahKursiKosong = value; }

        public static List<LaporanFilmKetidakhadiranPenonton> BacaData()
        {
            List<LaporanFilmKetidakhadiranPenonton> listLaporan = new List<LaporanFilmKetidakhadiranPenonton>();
            string perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Ketidakhadiran Penonton' FROM films f " +
                    "INNER JOIN tikets t ON f.id = t.films_id WHERE t.status_hadir = 0 GROUP BY f.Judul LIMIT 3;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanFilmKetidakhadiranPenonton laporan = new LaporanFilmKetidakhadiranPenonton();
                laporan.Film = Film.BacaData("judul", msdr.GetString(0))[0];
                laporan.Jumlah_ketidakhadiran_penonton = msdr.GetInt32(1);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }
        public static List<LaporanFilmKetidakhadiranPenonton> BacaData(string kriteria, string nilai, string urut)
        {
            List<LaporanFilmKetidakhadiranPenonton> listLaporan = new List<LaporanFilmKetidakhadiranPenonton>();
            string perintah;
            if (kriteria != "COUNT(t.films_id)")
            {
                perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Ketidakhadiran Penonton' FROM films f " +
                    "INNER JOIN tikets t ON f.id = t.films_id WHERE t.status_hadir = 0 AND " + kriteria + " LIKE '%" + nilai + "%' GROUP BY f.Judul " +
                    "ORDER BY " + urut + " LIMIT 3;";
            }
            else if (string.IsNullOrEmpty(nilai))
            {
                perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Ketidakhadiran Penonton' FROM films f " +
                    "INNER JOIN tikets t ON f.id = t.films_id WHERE t.status_hadir = 0 GROUP BY f.Judul " +
                    "ORDER BY " + urut + " LIMIT 3;";
            }
            else
            {
                perintah = "SELECT f.Judul, COUNT(t.films_id) as 'Jumlah Ketidakhadiran Penonton' FROM films f " +
                    "INNER JOIN tikets t ON f.id = t.films_id WHERE t.status_hadir = 0 GROUP BY f.Judul HAVING " +
                    kriteria + " = '" + nilai + "' ORDER BY " + urut + " LIMIT 3;";
            }

            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanFilmKetidakhadiranPenonton laporan = new LaporanFilmKetidakhadiranPenonton();
                laporan.Film = Film.BacaData("judul", msdr.GetString(0))[0];
                laporan.Jumlah_ketidakhadiran_penonton = msdr.GetInt32(1);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }
    }
}
