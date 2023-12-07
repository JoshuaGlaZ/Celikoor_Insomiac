using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Sesi_Film
    {
        private Film_Studio fs;
        private JadwalFilm jf;

        public Sesi_Film()
        {
            fs = new Film_Studio();
            jf = new JadwalFilm();
        }

        public Film_Studio Fs { get => fs; set => fs = value; }
        public JadwalFilm Jf { get => jf; set => jf = value; }

        public static List<Sesi_Film> bacaData(string kodeStudio, string kodeFilm)
        {
            List<Sesi_Film> lst = new List<Sesi_Film>();
            string perintah = "SELECT * FROM sesi_films;";
            if (kodeStudio != "" && kodeFilm != "") { perintah = "SELECT * FROM film_studio WHERE studios_id=" + kodeStudio + " AND films_id=" + kodeFilm + ";"; }
            else if (kodeStudio != "") { perintah = "SELECT * FROM film_studio WHERE studios_id=" + kodeStudio + ";"; }
            else if (kodeFilm != "") { perintah = "SELECT * FROM film_studio WHERE films_id=" + kodeFilm + ";"; }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Sesi_Film sf = new Sesi_Film();
                sf.Jf = JadwalFilm.BacaData(msdr.GetValue(0).ToString())[0];
                sf.Fs = Film_Studio.BacaData(msdr.GetValue(1).ToString(), msdr.GetValue(2).ToString())[0];
                lst.Add(sf);
            }
            return lst;
        }

        public static void MasukanData(Sesi_Film sf)
        {
            sf.Jf = JadwalFilm.BacaData(sf.Jf.TanggalPutar.ToString("yyyy-MM-dd"), sf.Jf.JamPemutaran);
            sf.Fs.Std = Studio.BacaData("nama",sf.Fs.Std.Nama)[0];
            sf.Fs.Flm = Film.BacaData("judul",sf.Fs.Flm.Judul)[0];
            string perintah = "INSERT INTO sesi_films (jadwal_film_id, studios_id, films_id) " +
                "VALUES ('" + sf.Jf.Id + "', '" + sf.Fs.Std.Id + "', '"+sf.Fs.Flm.Id+"');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Sesi_Film sf)
        {
            string perintah = "DELETE FROM `sesi_films` " +
                "WHERE `jadwal_film_id`='"+sf.Jf.Id+"' and`studios_id`='"+sf.Fs.Std.Id+"' and`films_id`='"+sf.Fs.Flm.Id+"';";
            Koneksi.JalankanPerintah(perintah);
        }

        public void UbahData(Sesi_Film sf)
        {
            string perintah = "UPDATE `sesi_films` SET " +
                "`jadwal_film_id`='"+sf.Jf.Id+"', " +
                "`studios_id`='"+sf.Fs.Std.Id+"', " +
                "`films_id`='"+sf.Fs.Flm.Id+"'  WHERE " +
                "`jadwal_film_id`='" + this.Jf.Id + "' and" +
                "`studios_id`='" + this.Fs.Std.Id + "' and" +
                "`films_id`='" + this.Fs.Flm.Id + "';";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
