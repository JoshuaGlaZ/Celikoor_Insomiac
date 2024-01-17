using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class LaporanPenjualanTiketCabang
    {
        private Cinema cabang;
        private int nominalPenjualan;

        public LaporanPenjualanTiketCabang()
        {
            this.Cabang = cabang;
            this.NominalPenjualan = 0;
        }
        public LaporanPenjualanTiketCabang(Cinema cabang, int nominalPenjualan)
        {
            this.Cabang = cabang;
            this.NominalPenjualan = nominalPenjualan;
        }

        public Cinema Cabang { get => cabang; set => cabang = value; }
        public int NominalPenjualan { get => nominalPenjualan; set => nominalPenjualan = value; }

        public static List<LaporanPenjualanTiketCabang> BacaData(string order = "")
        {
            List<LaporanPenjualanTiketCabang> listLaporan = new List<LaporanPenjualanTiketCabang>();
            string perintah = "";
            if (order == "Terendah")
            {
                perintah = "select c.nama_cabang, IFNULL(Sum(i.grand_total),0) as TotalPenjualan from cinemas c left join studios s on c.id = s.cinemas_id " +
                    "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id group by c.nama_cabang order by TotalPenjualan ASC Limit 3";
            }
            else
            {
                perintah = "select c.nama_cabang, IFNULL(Sum(i.grand_total),0) as TotalPenjualan from cinemas c left join studios s on c.id = s.cinemas_id " +
                    "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id group by c.nama_cabang order by TotalPenjualan DESC Limit 3";
            }
                  
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanPenjualanTiketCabang laporan = new LaporanPenjualanTiketCabang();
                laporan.Cabang = Cinema.BacaData("nama_cabang", msdr.GetString(0))[0];
                laporan.NominalPenjualan = msdr.GetInt32(1);
                listLaporan.Add(laporan);
            }
            return listLaporan;
        }

        public static void CetakLaporan(List<LaporanPenjualanTiketCabang> lst)
        {
            string nama = "LAPORAN PENDAPATAN CABANG_" + DateTime.Now.ToString("yyyy-MM-dd");
            StreamWriter sw = new StreamWriter(nama);
            sw.WriteLine("LAPORAN PENDAPATAN CABANG_" + DateTime.Now.ToString("yyyy-MM-dd"));
            sw.WriteLine("======================================================================");
            sw.WriteLine("");
            sw.WriteLine("LAPORAN PENDAPATAN PER CABANG :");
            sw.WriteLine("");
            sw.WriteLine("no \t nama cabang \t pendapatan");
            for (int i = 1; i <= lst.Count; i++)
            {
                sw.WriteLine(i + ". \t " + lst[i - 1].Cabang.Nama_cabang + " \t " + lst[i - 1].NominalPenjualan);
            }
            sw.Close();
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.kirimPrinter();
        }
    }
}
