using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class LaporanTingkatUtilitasStudio
    {
        private Studio studio;
        private Cinema cinema;
        private int jumlahKursiKosong;
        public Studio Studio { get => studio; set => studio = value; }
        public int JumlahKursiKosong { get => jumlahKursiKosong; set => jumlahKursiKosong = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }

        public static List<LaporanTingkatUtilitasStudio> BacaData(string bulan = "", string order = "Terendah")
        {
            List<LaporanTingkatUtilitasStudio> listLaporan = new List<LaporanTingkatUtilitasStudio>();
            if(order == "Terendah")
            {
                order = "DESC";
            } 
            else
            {
                order = "ASC";
            }
            string perintah = "select c.nama_cabang, s.nama, (s.kapasitas - Count(t.nomor_kursi)) as KursiKosong from cinemas c left join studios s on c.id = s.cinemas_id " +
                   "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id And monthname(i.tanggal) = 'january' " +
                   "group by c.nama_cabang, s.nama order by KursiKosong "+ order +" LIMIT 3;";
            if (bulan != "")
            {
                perintah = "select c.nama_cabang, s.nama, (s.kapasitas - Count(t.nomor_kursi)) as KursiKosong from cinemas c left join studios s on c.id = s.cinemas_id " +
                   "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id And monthname(i.tanggal) = '" + bulan + "'" +
                   "group by c.nama_cabang, s.nama order by KursiKosong " + order + " LIMIT 3;";
            }
           
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanTingkatUtilitasStudio laporan = new LaporanTingkatUtilitasStudio();
                laporan.Studio = Studio.BacaData("judul", msdr.GetString(0))[0];
                laporan.JumlahKursiKosong = msdr.GetInt32(1);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }
        
    }
}
