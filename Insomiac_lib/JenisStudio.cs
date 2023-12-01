using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class JenisStudio
    {
        private int id;
        private string nama;
        private string deskripsi;

        public JenisStudio(string nama, string deskripsi)
        {
            Nama = nama;
            Deskripsi = deskripsi;
        }

        public JenisStudio()
        {
            Nama = "";
            Deskripsi = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public static List<JenisStudio> BacaData()
        {
            List<JenisStudio> lst = new List<JenisStudio>();
            string perintah = "SELECT * FROM jenis_studios;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                JenisStudio js = new JenisStudio();
                js.Id = int.Parse(msdr.GetValue(0).ToString());
                js.Nama = msdr.GetValue(1).ToString();
                js.Deskripsi = msdr.GetValue(2).ToString();
                lst.Add(js);
            }
            return lst;
        }
        public static List<JenisStudio> BacaData(string kriteria, string nilai)
        {
            List<JenisStudio> lst = new List<JenisStudio>();
            string perintah = "SELECT * FROM jenis_studios WHERE '" + kriteria + "' LIKE '%" + nilai + "'%;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                JenisStudio js = new JenisStudio();
                js.Id = int.Parse(msdr.GetValue(0).ToString());
                js.Nama = msdr.GetValue(1).ToString();
                js.Deskripsi = msdr.GetValue(2).ToString();
                lst.Add(js);
            }
            return lst;
        }
        public static JenisStudio BacaData(string id)
        {
            string perintah = "SELECT * FROM jenis_studios WHERE id ='" + id + "';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                JenisStudio js = new JenisStudio();
                js.Id = int.Parse(msdr.GetValue(0).ToString());
                js.Nama = msdr.GetValue(1).ToString();
                js.Deskripsi = msdr.GetValue(2).ToString();
                return js;
            }
            return null;
        }
        public static void TambahData(JenisStudio js)
        {
            string perintah = "INSERT INTO jenis_studios (nama, deskripsi) " +
                "VALUES ('" + js.Nama + "', '" + js.Deskripsi + "');";
            Koneksi.JalankanPerintah(perintah);
        }
        public static void HapusData(JenisStudio js)
        {
            string perintah = "DELETE FROM jenis_studios WHERE id=" + js.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }
        public override string ToString()
        {
            return Nama;
        }
    }
}
