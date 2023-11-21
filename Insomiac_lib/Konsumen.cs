using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Insomiac_lib
{
    public class Konsumen
    {
        private int id;
        private string nama;
        private string email;
        private string no_hp;
        private string gender;
        private DateTime tgl_lahir;
        private double saldo;
        private string username;
        private string password;

        public Konsumen(int id, string nama, string email, string no_hp, string gender, DateTime tgl_lahir, double saldo, string username, string password)
        {
            Id = id;
            Nama = nama;
            Email = email;
            No_hp = no_hp;
            Gender = gender;
            Tgl_lahir = tgl_lahir;
            Saldo = saldo;
            Username = username;
            Password = password;
        }

        public Konsumen()
        {
            Nama = "";
            Email = "";
            No_hp = "";
            Gender = "";
            Tgl_lahir = DateTime.Now;
            Saldo = 0.0;
            Username = "";
            Password = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Tgl_lahir { get => tgl_lahir; set => tgl_lahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        //buat ambil semua
        public static List<Konsumen> BacaData()
        {
            string perintah = "SELECT * FROM konsumens;";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Konsumen> data = new List<Konsumen>();
            while (msdr.Read())
            {
                Konsumen k = new Konsumen();
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Nama = (string)msdr.GetValue(1);
                k.Email = (string)msdr.GetValue(2);
                k.No_hp = (string)msdr.GetValue(3);
                k.Tgl_lahir = (DateTime)msdr.GetValue(4);
                k.Saldo = Double.Parse(msdr.GetValue(5).ToString());
                k.Username = (string)msdr.GetValue(6);
                k.Password = (string)msdr.GetValue(7);
                data.Add(k);
            }
            return data;
        }

        //buat filter
        public static List<Konsumen> BacaData(string kolom, string cari)
        {
            string perintah = "SELECT * FROM Konsumens WHERE " + kolom + " LIKE \'%" + cari + "%\';";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            List<Konsumen> data = new List<Konsumen>();
            while (msdr.Read())
            {
                Konsumen k = new Konsumen();
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Nama = (string)msdr.GetValue(1);
                k.Email = (string)msdr.GetValue(2);
                k.No_hp = (string)msdr.GetValue(3);
                k.Tgl_lahir = (DateTime)msdr.GetValue(4);
                k.Saldo = Double.Parse(msdr.GetValue(5).ToString());
                k.Username = (string)msdr.GetValue(6);
                k.Password = (string)msdr.GetValue(7);
                data.Add(k);
            }
            return data;
        }

        //buat ambil 1 spesifik
        public static Konsumen BacaData(string idKonsumen)
        {
            string perintah = "SELECT * FROM konsumens WHERE id=\"" + idKonsumen + "\";";
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Konsumen k = new Konsumen();
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Nama = (string)msdr.GetValue(1);
                k.Email = (string)msdr.GetValue(2);
                k.No_hp = (string)msdr.GetValue(3);
                k.Tgl_lahir = (DateTime)msdr.GetValue(4);
                k.Saldo = Double.Parse(msdr.GetValue(5).ToString());
                k.Username = (string)msdr.GetValue(6);
                k.Password = (string)msdr.GetValue(7);
                return k;
            }
            else { return null; }
        }

        public static void TambahData(Konsumen k)
        {
            string perintah =
                "INSERT INTO konsumens (id, nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " +
                "VALUES (" + k.Id + ", '" + k.Nama + "', '" + k.Email + "', '" + k.No_hp + "', '" + k.Gender + "', '" +
                k.Tgl_lahir.ToString("yyyy-MM-dd") + "', '" + k.Saldo.ToString() + "', '" +
                k.Username + "', SHA2('" + k.Password + "',512));";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void UbahData(Konsumen k)
        {
            string perintah =
                "UPDATE konsumens SET " +
                "nama=\"" + k.Nama + "\"," +
                "email=\"" + k.Email + "\"," +
                "no_hp=\"" + k.No_hp + "\"," +
                "gender=\"" + k.Gender + "\"," +
                "tgl_lahir=\"" + k.Tgl_lahir.ToString("yyyy-MM-dd") + "\"," +
                "saldo=" + k.Saldo.ToString() + "," +
                "username=\"" + k.Username + "\"," +
                "gender=\"" + k.Gender + "\"," +
                "WHERE id=" + k.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }

        public static void HapusData(Konsumen k)
        {
            string perintah = "DELETE FROM konsumens WHERE id=" + k.Id + ";";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
