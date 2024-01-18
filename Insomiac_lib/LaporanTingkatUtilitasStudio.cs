using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class LaporanTingkatUtilitasStudio
    {
        private Studio studio;
        private Cinema cinema;
        private int jumlahKursiKosong;
        private string bulan;
        public Studio Studio { get => studio; set => studio = value; }
        public int JumlahKursiKosong { get => jumlahKursiKosong; set => jumlahKursiKosong = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public string Bulan { get => bulan; set => bulan = value; }

        public static List<LaporanTingkatUtilitasStudio> BacaData(string bulan = "", string order = "")
        {
            List<LaporanTingkatUtilitasStudio> listLaporan = new List<LaporanTingkatUtilitasStudio>();
            if(order == "Terendah")
            {
                order = "ASC";
            } 
            else
            {
                order = "DESC";
            }

            string perintah = "select c.nama_cabang, s.nama, (sum(s.kapasitas) - Count(t.nomor_kursi)) as KursiKosong, MONTHNAME(i.tanggal) as Bulan " +
                "from cinemas c inner join studios s on c.id = s.cinemas_id left join tikets t on t.studios_id = s.id " +
                "left join invoices i on i.id = t.invoices_id where monthname(i.tanggal) = 'January'" +
                "group by c.nama_cabang, s.nama, Bulan order by KursiKosong " +  order + " LIMIT 3;";

            if (bulan != "")
            {
                perintah = "select c.nama_cabang, s.nama, (sum(s.kapasitas) - Count(t.nomor_kursi)) as KursiKosong, MONTHNAME(i.tanggal) as Bulan " +
                "from cinemas c inner join studios s on c.id = s.cinemas_id left join tikets t on t.studios_id = s.id " +
                "left join invoices i on i.id = t.invoices_id where monthname(i.tanggal) = '" + bulan + "'" +
                "group by c.nama_cabang, s.nama, Bulan order by KursiKosong " + order + " LIMIT 3;";
            }
           
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanTingkatUtilitasStudio laporan = new LaporanTingkatUtilitasStudio();
                laporan.Studio = Studio.BacaData("nama", msdr.GetString(1))[0];
                laporan.Cinema = Cinema.BacaData("nama_cabang", msdr.GetString(0))[0];
                laporan.JumlahKursiKosong = msdr.GetInt32(2);
                laporan.Bulan = msdr.GetString(3);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }

        public static void CetakLaporan(List<LaporanTingkatUtilitasStudio> lst)
        {
            string nama = "LAPORAN TINGKAT UTILITAS STUDIO_" + DateTime.Now.ToString("yyyy-MM-dd");
            StreamWriter sw = new StreamWriter(nama);
            sw.WriteLine("LAPORAN TINGKAT UTILITAS STUDIO_" + DateTime.Now.ToString("yyyy-MM-dd"));
            sw.WriteLine("======================================================================");
            sw.WriteLine("");
            sw.WriteLine("JUMLAH KURSI KOSONG DI STUDIO :");
            sw.WriteLine("");
            sw.WriteLine("no \t cinema \t studio \t jumlah kursi kosong \t bulan");
            for (int i = 1; i <= lst.Count; i++)
            {
                sw.WriteLine(i + ". \t " + lst[i - 1].Cinema.Nama_cabang + " \t " + lst[i - 1].Studio.Nama + " \t " + lst[i - 1].JumlahKursiKosong + " \t " + lst[i-1].Bulan);
            }
            sw.Close();
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.kirimPrinter();
        }
    }
}
