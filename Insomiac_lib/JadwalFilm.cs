﻿using System;
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

        public static List<JadwalFilm> bacaData(string tanggal) //bisa cari berdasarkan tanggal pakai yyyy-MM-dd
        {
            List<JadwalFilm> lst = new List<JadwalFilm>();
            string perintah = "SELECT * FROM jadwal_films;";
            if (tanggal != "") { perintah = "SELECT * FROM jadwal_films WHERE tanggal='"+tanggal+"';"; }
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
    }
}