using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Kelompok
    {
        private int id;
        private string nama;

        public Kelompok(string nama)
        {
            Nama = nama;
        }

        public Kelompok()
        {
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public static List<Kelompok> BacaData()
        {
            List<Kelompok> lst = new List<Kelompok>();
            string perintah = "SELECT * FROM kelompoks;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Kelompok p = new Kelompok();
                p.Id = int.Parse(msdr.GetValue(0).ToString());
                p.Nama = msdr.GetValue(1).ToString();
                lst.Add(p);
            }
            return lst;
        }

        public static List<Kelompok> BacaData(string kolom, string cari)
        {
            List<Kelompok> lst = new List<Kelompok>();
            string perintah = "SELECT * FROM Kelompoks WHERE " + kolom + " LIKE \'%" + cari + "%\';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Kelompok p = new Kelompok();
                p.Id = int.Parse(msdr.GetValue(0).ToString());
                p.Nama = msdr.GetValue(1).ToString();
                lst.Add(p);
            }
            return lst;
        }

        public static Kelompok BacaData(int id)
        {
            string perintah = "SELECT * FROM Kelompoks WHERE id=" + id + ";";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Kelompok p = new Kelompok();
                p.Id = int.Parse(msdr.GetValue(0).ToString());
                p.Nama = msdr.GetValue(1).ToString();
                return p;
            }
            else { return null; }
        }

        public static void TambahData(Kelompok k)
        {
            string perintah = "INSERT INTO Kelompoks (nama) " +
                "VALUES ('" + k.Nama + "');";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void UbahData(Kelompok k) //ada yang salah
        {
            string perintah = "UPDATE kelompoks SET nama='"+k.Nama+"' WHERE id='"+k.Id+"';";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Kelompok k)
        {
            string perintah = "DELETE FROM Kelompoks WHERE id=" + k.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
