﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Pegawai
    {
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string roles;

        public Pegawai(string nama, string email, string username, string password, string roles)
        {
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Roles = roles;
        }

        public Pegawai()
        {
            Nama = "";
            Email = "";
            Username = "";
            Password = "";
            Roles = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles { get => roles; set => roles = value; }

        public static List<Pegawai> bacaData()
        {
            List<Pegawai> lst = new List<Pegawai>();
            string perintah = "SELECT * FROM pegawais;";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Pegawai p = new Pegawai();
                p.Id = int.Parse(msdr.GetValue(0).ToString());
                p.Nama = msdr.GetValue(1).ToString();
                p.Email = msdr.GetValue(2).ToString();
                p.Username = msdr.GetValue(3).ToString();
                p.Password = msdr.GetValue(4).ToString();
                p.Roles = msdr.GetValue(5).ToString();
                lst.Add(p);
            }
            return lst;
        }

        public static List<Pegawai> bacaData(string kolom, string cari)
        {
            List<Pegawai> lst = new List<Pegawai>();
            string perintah = "SELECT * FROM pegawais WHERE " + kolom + " LIKE \'%" + cari + "%\';";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Pegawai p = new Pegawai();
                p.Id = int.Parse(msdr.GetValue(0).ToString());
                p.Nama = msdr.GetValue(1).ToString();
                p.Email = msdr.GetValue(2).ToString();
                p.Username = msdr.GetValue(3).ToString();
                p.Password = msdr.GetValue(4).ToString();
                p.Roles = msdr.GetValue(5).ToString();
                lst.Add(p);
            }
            return lst;
        }

        public static Pegawai bacaData(int id)
        {
            string perintah = "SELECT * FROM pegawais WHERE id="+id+";";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                Pegawai p = new Pegawai();
                p.Id = int.Parse(msdr.GetValue(0).ToString());
                p.Nama = msdr.GetValue(1).ToString();
                p.Email = msdr.GetValue(2).ToString();
                p.Username = msdr.GetValue(3).ToString();
                p.Password = msdr.GetValue(4).ToString();
                p.Roles = msdr.GetValue(5).ToString();
                return p;
            }
            else { return null; }
        }

        public static void TambahData(Pegawai p)
        {
            string perintah = "INSERT INTO pegawais (nama, email, username, password, roles) " +
                "VALUES ('"+p.Nama+"', '"+p.Email+"', '"+p.Username+ "', SHA2('" + p.Password + "',512), '" + p.Roles+"');";
            Koneksi.jalankanPerintah(perintah);
        }

        public static void UbahData(Pegawai p)
        {
            string perintah = "UPDATE pegawais SET " +
                "nama='"+p.Nama+"', " +
                "email='"+p.Email+"', " +
                "username='"+p.Username+"', " +
                "roles='"+p.Roles+"' " +
                "WHERE id='"+p.Id+"';";
            Koneksi.jalankanPerintah(perintah);
        }

        public static void HapusData(Pegawai p)
        {
            string perintah = "DELETE FROM pegawais WHERE id="+p.Id+";";
            Koneksi.jalankanPerintah(perintah);
        }
    }
}
