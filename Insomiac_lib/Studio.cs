using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Studio
    {
        private int id;
        private string nama;
        private int kapasitas;
        private JenisStudio jenis;
        private Cinema bioskop;
        private int harga_weekday;
        private int harga_weekend;

        public Studio()
        {
            Nama = "";
            Kapasitas = 0;
            Jenis = new JenisStudio();
            Bioskop = new Cinema();
            Harga_weekday = 0;
            Harga_weekend = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public JenisStudio Jenis { get => jenis; set => jenis = value; }
        public Cinema Bioskop { get => bioskop; set => bioskop = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }

        public static List<Studio> BacaData(string kriteria, string kode)
        {
            List<Studio> lst = new List<Studio>();
            string perintah = "SELECT * FROM studios;";
            if (kriteria == "id") { perintah = "SELECT * FROM studios WHERE id="+kode+";"; }
            else if (kriteria != "" && kode != "") { perintah = "SELECT * FROM studios WHERE " + kriteria + " LIKE '%" + kode + "%';"; }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Studio s = new Studio();
                s.Id = int.Parse(msdr.GetValue(0).ToString());
                s.Nama = msdr.GetValue(1).ToString();
                s.Kapasitas = int.Parse(msdr.GetValue(2).ToString());
                s.Jenis = JenisStudio.BacaData("id", msdr.GetValue(3).ToString())[0];
                s.Bioskop = Cinema.BacaData("id", msdr.GetValue(4).ToString())[0];
                s.Harga_weekday = int.Parse(msdr.GetValue(5).ToString());
                s.Harga_weekend = int.Parse(msdr.GetValue(6).ToString());
                lst.Add(s);
            }
            return lst;
        }

        public static void MasukanData(Studio s)
        {
            string perintah = "INSERT INTO studios (nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) " +
                "VALUES ('"+s.Nama+"', "+s.Kapasitas+", "+s.Jenis.Id+", "+s.Bioskop.Id+", '"+s.Harga_weekday+"', '"+s.Harga_weekend+"');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Studio s)
        {
            string perintah = "DELETE FROM studios WHERE id="+s.Id+";";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void UbahData(Studio s)
        {
            string perintah = "UPDATE `studios` SET " +
                "`nama`='"+s.Nama+"', " +
                "`kapasitas`='"+s.Kapasitas+"', " +
                "`jenis_studios_id`='"+s.Jenis.Id+"', " +
                "`cinemas_id`='"+s.Bioskop.Id+"', " +
                "`harga_weekday`='"+s.Harga_weekday+"', " +
                "`harga_weekend`='"+s.Harga_weekend+"' " +
                "WHERE `id`='"+s.Id+"';";
            Koneksi.JalankanPerintah(perintah);
        }

        public override string ToString()
        {
            return Nama;
        }
    }
}
