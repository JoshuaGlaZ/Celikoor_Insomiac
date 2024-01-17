using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class JadwalFilm
    {
        private int id;
        private DateTime tanggalPutar;
        private string jamPemutaran;
        private List<Film_Studio> listFS;

        public JadwalFilm()
        {
            TanggalPutar = DateTime.Now;
            JamPemutaran = "";
            ListFS = new List<Film_Studio>();
        }

        public int Id { get => id; set => id = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }
        public DateTime TanggalPutar { get => tanggalPutar; set => tanggalPutar = value; }
        public List<Film_Studio> ListFS { get => listFS; set => listFS = value; }

        public static void masukanData(JadwalFilm jf)
        {
            string perintah = "INSERT INTO jadwal_films (tanggal, jam_pemutaran) " +
                "VALUES ('" + jf.TanggalPutar.ToString("yyyy-MM-dd") + "', '" + jf.JamPemutaran + "');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static List<JadwalFilm> BacaData()
        {
            List<JadwalFilm> lst = new List<JadwalFilm>();
            string perintah = "SELECT * FROM jadwal_films;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                JadwalFilm jf = new JadwalFilm();
                jf.Id = int.Parse(msdr.GetValue(0).ToString());
                jf.TanggalPutar = DateTime.Parse(msdr.GetValue(1).ToString());
                jf.JamPemutaran = msdr.GetValue(2).ToString();
                jf.ListFS = jf.DaftarFilmStudio();
                lst.Add(jf);
            }
            return lst;
        }

        public static List<JadwalFilm> BacaData(string kode)
        {
            List<JadwalFilm> lst = new List<JadwalFilm>();
            string perintah = "SELECT * FROM jadwal_films WHERE id = " + kode;
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                JadwalFilm jf = new JadwalFilm();
                jf.Id = int.Parse(msdr.GetValue(0).ToString());
                jf.TanggalPutar = DateTime.Parse(msdr.GetValue(1).ToString());
                jf.JamPemutaran = msdr.GetValue(2).ToString();
                jf.ListFS = jf.DaftarFilmStudio();
                lst.Add(jf);
            }
            return lst;
        }
        public static JadwalFilm BacaData(string tanggal, string jam)
        {
            string perintah = "SELECT * FROM jadwal_films;";
            if (tanggal != "" && jam != "") { perintah = "SELECT * FROM jadwal_films WHERE tanggal='" + tanggal + "' AND jam_pemutaran='" + jam + "';"; }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                JadwalFilm jf = new JadwalFilm();
                jf.Id = int.Parse(msdr.GetValue(0).ToString());
                jf.TanggalPutar = DateTime.Parse(msdr.GetValue(1).ToString());
                jf.JamPemutaran = msdr.GetValue(2).ToString();
                return jf;
            }
            else { return null; }
        }

        public static List<JadwalFilm> BacaData(Film tFilm)
        {
            List<JadwalFilm> lst = new List<JadwalFilm>();
            string perintah = "SELECT jf.id, jf.tanggal, jf.jam_pemutaran " +
               "FROM  jadwal_films jf " +
               "inner join sesi_films sf on jf.id = sf.jadwal_film_id " +
               "inner join film_studio fs on sf.studios_id = fs.studios_id AND sf.films_id = fs.films_id " +
               "WHERE fs.films_id = '" + tFilm.Id + "' GROUP BY jf.id;";

            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                JadwalFilm jf = new JadwalFilm();
                jf.Id = msdr.GetInt32(0);
                jf.TanggalPutar = DateTime.Parse(msdr.GetValue(1).ToString());
                jf.JamPemutaran = msdr.GetString(2);
                jf.ListFS = jf.DaftarFilmStudio(tFilm);
                lst.Add(jf);
            }
            return lst;
        }

        public List<Film_Studio> DaftarFilmStudio()
        {
            List<Film_Studio> lst = new List<Film_Studio>();
            string perintah = "SELECT fs.studios_id,fs.films_id FROM jadwal_films jf " +
                "inner join sesi_films sf on jf.id = sf.jadwal_film_id " +
                "inner join film_studio fs on sf.studios_id = fs.studios_id AND sf.films_id = fs.films_id " +
                "WHERE jf.id = "+Id+";";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Film_Studio fs = new Film_Studio();
                fs.Std = Studio.BacaData("id", msdr.GetValue(0).ToString())[0];
                fs.Flm = Film.BacaData(msdr.GetValue(1).ToString());
                lst.Add(fs);
            }
            return lst;
        }
        public List<Film_Studio> DaftarFilmStudio(Film tFilm)
        {
            List<Film_Studio> lst = new List<Film_Studio>();
            string perintah = "SELECT fs.studios_id,fs.films_id FROM jadwal_films jf " +
                "inner join sesi_films sf on jf.id = sf.jadwal_film_id " +
                "inner join film_studio fs on sf.studios_id = fs.studios_id AND sf.films_id = fs.films_id " +
                "WHERE fs.films_id = " + tFilm.Id + " AND jf.id = " + Id + " AND jf.id = " + Id + ";";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Film_Studio fs = new Film_Studio();
                fs.Std = Studio.BacaData("id",msdr.GetValue(0).ToString())[0];
                fs.Flm = Film.BacaData(msdr.GetValue(1).ToString());
                lst.Add(fs);
            }
            return lst;
        }


        public void TambahDataFilmStudio()
        {
            foreach (Film_Studio fs in this.ListFS)
            {
                if (Film_Studio.BacaData(fs.Std.Id.ToString(), fs.Flm.Id.ToString()).Count==0)
                {
                    string perintah = "INSERT INTO `insomniac`.`film_studio` (`studios_id`, `films_id`) VALUES ('"+fs.Std.Id+"', '"+fs.Flm.Id+"');";
                    Koneksi.JalankanPerintah(perintah);
                }
                string perintah2 = "SELECT * FROM insomniac.sesi_films WHERE jadwal_film_id = " + this.Id + " AND studios_id = " + fs.Std.Id + " AND films_id = " + fs.Flm.Id + ";";
                MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah2);
                if (!msdr.Read())
                {
                    string perintah3 = "INSERT INTO `insomniac`.`sesi_films` " +
                        "(`jadwal_film_id`, `studios_id`, `films_id`) " +
                        "VALUES ('" + this.Id + "', '" + fs.Std.Id + "', '" + fs.Flm.Id + "');";
                    Koneksi.JalankanPerintah(perintah3);
                }
            }
        }


        public void TambahDataFilmStudio(Film_Studio fs)
        {
            if (Film_Studio.BacaData(fs.Std.Id.ToString(), fs.Flm.Id.ToString()).Count == 0)
            {
                string perintah = "INSERT INTO `insomniac`.`film_studio` (`studios_id`, `films_id`) VALUES ('" + fs.Std.Id + "', '" + fs.Flm.Id + "');";
                Koneksi.JalankanPerintah(perintah);
            }
                string perintah2 = "SELECT * FROM insomniac.sesi_films WHERE jadwal_film_id = " + this.Id + " AND studios_id = " + fs.Std.Id + " AND films_id = " + fs.Flm.Id + ";";
                MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah2);
                if (!msdr.Read())
                {
                    string perintah3 = "INSERT INTO `insomniac`.`sesi_films` " +
                        "(`jadwal_film_id`, `studios_id`, `films_id`) " +
                        "VALUES ('" + this.Id + "', '" + fs.Std.Id + "', '" + fs.Flm.Id + "');";
                    Koneksi.JalankanPerintah(perintah3);
                }
            Koneksi.JalankanPerintah(perintah2);
        }

        public void HapusJadwalFilm()
        {
            string perintah = "DELETE FROM `insomniac`.`sesi_films` WHERE `jadwal_film_id`='"+this.Id+"';";
            Koneksi.JalankanPerintah(perintah);
            string perintah2 = "DELETE FROM `insomniac`.`jadwal_films` WHERE `id`='"+this.Id+"';";
            Koneksi.JalankanPerintah(perintah2);
        }

        public void UbahJadwalFilm(DateTime tgl, string jamPutar)
        {
            string perintah = "UPDATE `insomniac`.`jadwal_films` SET `tanggal`='"+tgl.ToString("yyyy-MM-dd")+"', `jam_pemutaran`='"+jamPutar+"' WHERE `id`='"+this.Id+"';";
            Koneksi.JalankanPerintah(perintah);
        }
        public override string ToString()
        {   
            return TanggalPutar.ToShortDateString() + " / " + JamPemutaran;
        }
    }
}
