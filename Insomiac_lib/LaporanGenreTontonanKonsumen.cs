using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class LaporanGenreTontonanKonsumen
    {
        private Konsumen konsumen;
        private int jumlahMenonton;

        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public int JumlahMenonton { get => jumlahMenonton; set => jumlahMenonton = value; }

        public LaporanGenreTontonanKonsumen()
        {
            this.Konsumen = konsumen;
            this.JumlahMenonton = 0;
        }
        public LaporanGenreTontonanKonsumen(Konsumen kosnumen, int jumlahMenonton)
        {
            this.Konsumen = kosnumen;
            this.JumlahMenonton = 0;
        }

        public static List<LaporanGenreTontonanKonsumen> BacaData(string nilai = "", string urut = "")
        {
            List<LaporanGenreTontonanKonsumen> listLaporan = new List<LaporanGenreTontonanKonsumen>();
            string perintah = "Select k.nama, Count(i.id) as TotalTonton from konsumens k inner join invoices i on k.id = i.konsumens_id " +
                "inner join tikets t on t.invoices_id" + " = i.id inner join genre_film gf on gf.films_id = t.films_id " +
                "inner join genres g on gf.genres_id = g.nama and g.nama = 'Komedi' group by k.nama ORDER BY TotalTonton DESC LIMIT 10;";

            if (urut == "Terbanyak")
            {
                perintah = "Select k.nama, Count(i.id) as TotalTonton from konsumens k inner join invoices i on k.id = i.konsumens_id " +
                "inner join tikets t on t.invoices_id" + " = i.id inner join genre_film gf on gf.films_id = t.films_id " +
                "inner join genres g on gf.genres_id = g.nama and g.nama = '" + nilai + "' group by k.nama ORDER BY TotalTonton DESC LIMIT 10;";
            }
            else if (urut == "Tersedikit")
            {
                perintah = "Select k.nama, Count(i.id) as TotalTonton from konsumens k inner join invoices i on k.id = i.konsumens_id " +
                 "inner join tikets t on t.invoices_id" + " = i.id inner join genre_film gf on gf.films_id = t.films_id " +
                 "inner join genres g on gf.genres_id = g.nama and g.nama = '" + nilai + "' group by k.nama ORDER BY TotalTonton ASC LIMIT 10;";
            }
            else
            {
                perintah = "Select k.nama, Count(i.id) as TotalTonton from konsumens k inner join invoices i on k.id = i.konsumens_id " +
                "inner join tikets t on t.invoices_id" + " = i.id inner join genre_film gf on gf.films_id = t.films_id " +
                "inner join genres g on gf.genres_id = g.nama and g.nama = 'Komedi' group by k.nama ORDER BY TotalTonton DESC LIMIT 10;";
            }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanGenreTontonanKonsumen laporan = new LaporanGenreTontonanKonsumen();
                laporan.Konsumen = Konsumen.BacaData("nama", msdr.GetString(0),"")[0];
                laporan.JumlahMenonton = msdr.GetInt32(1);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }
        public static void CetakLaporan(List<LaporanGenreTontonanKonsumen> lst)
        {
            string nama = "LAPORAN GENRE TONTONAN KONSUMEN_" + DateTime.Now.ToString("yyyy-MM-dd");
            StreamWriter sw = new StreamWriter(nama);
            sw.WriteLine("LAPORAN GENRE TONTONAN KONSUMEN_" + DateTime.Now.ToString("yyyy-MM-dd"));
            sw.WriteLine("======================================================================");
            sw.WriteLine("");
            sw.WriteLine("LAPORAN GENRE TONTONAN KONSUMEN :");
            sw.WriteLine("");
            sw.WriteLine("no \t konsumen \t jumlah nonton");
            for (int i = 1; i <= lst.Count; i++)
            {
                sw.WriteLine(i + ". \t " + lst[i - 1].Konsumen.Nama + " \t " + lst[i - 1].JumlahMenonton);
            }
            sw.Close();
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.kirimPrinter();
        }
    }
}
