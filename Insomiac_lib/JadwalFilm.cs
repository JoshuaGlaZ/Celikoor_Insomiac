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

        public JadwalFilm()
        {
            TanggalPutar = DateTime.Now;
            JamPemutaran = "";
        }

        public int Id { get => id; set => id = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }
        public DateTime TanggalPutar { get => tanggalPutar; set => tanggalPutar = value; }

        public static void masukanData(JadwalFilm jf)
        {
            string perintah = "INSERT INTO jadwal_films (tanggal, jam_pemutaran) " +
                "VALUES ('"+jf.TanggalPutar.ToString("yyyy-MM-dd")+"', '"+jf.JamPemutaran+"');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static List<JadwalFilm> BacaData(string kode)
        {
            List<JadwalFilm> lst = new List<JadwalFilm>();
            string perintah = "SELECT * FROM jadwal_films;";
            if (kode != "") { perintah = "SELECT * FROM jadwal_films WHERE id='"+kode+"';"; }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                JadwalFilm jf = new JadwalFilm();
                jf.Id = int.Parse(msdr.GetValue(0).ToString());
                jf.TanggalPutar = DateTime.Parse(msdr.GetValue(1).ToString());
                jf.JamPemutaran = msdr.GetValue(2).ToString();
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
    }
}
