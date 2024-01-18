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
        private int totalPenjualan;

        public LaporanPenjualanTiketCabang()
        {
            this.Cabang = cabang;
            this.TotalPenjualan = 0;
        }
        public LaporanPenjualanTiketCabang(Cinema cabang, int nominalPenjualan)
        {
            this.Cabang = cabang;
            this.TotalPenjualan = nominalPenjualan;
        }

        public Cinema Cabang { get => cabang; set => cabang = value; }
        public int TotalPenjualan { get => totalPenjualan; set => totalPenjualan = value; }

        public static List<LaporanPenjualanTiketCabang> BacaData(string kriteria = "", string nilai = "", string order = "")
        {
            List<LaporanPenjualanTiketCabang> listLaporan = new List<LaporanPenjualanTiketCabang>();
            if(order == "Tertinggi")
            {
                order = "DESC";
            }
            else
            {
                order = "ASC";
            }

            string perintah = "";
            if(kriteria == "")
            {
                perintah = "select c.nama_cabang, Sum(i.grand_total) as TotalPenjualan " +
                    "from cinemas c left join studios s on c.id = s.cinemas_id " +
                    "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id " +
                    " group by c.nama_cabang having TotalPenjualan is not null order by TotalPenjualan Limit 3";
            }
            else if (kriteria == "TotalPenjualan")
            {
                perintah = "select c.nama_cabang, Sum(i.grand_total) as TotalPenjualan " +
                   "from cinemas c left join studios s on c.id = s.cinemas_id " +
                   "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id " +
                   "group by c.nama_cabang having TotalPenjualan is not null and " + kriteria + " LIKE '%" + nilai + 
                   "%' order by TotalPenjualan " + order + " Limit 3";
            }
            else
            {
                perintah = "select c.nama_cabang, Sum(i.grand_total) as TotalPenjualan " +
                    "from cinemas c left join studios s on c.id = s.cinemas_id " +
                    "left join tikets t on t.studios_id = s.id left join invoices i on i.id = t.invoices_id " +
                    "where " + kriteria + " LIKE '%" + nilai +
                    "%' group by c.nama_cabang having TotalPenjualan is not null order by TotalPenjualan " + order + " Limit 3";
            }            
                  
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                LaporanPenjualanTiketCabang laporan = new LaporanPenjualanTiketCabang();
                laporan.Cabang = Cinema.BacaData("nama_cabang", msdr.GetString(0))[0];
                laporan.TotalPenjualan = msdr.GetInt32(1);
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
                sw.WriteLine(i + ". \t " + lst[i - 1].Cabang.Nama_cabang + " \t " + lst[i - 1].TotalPenjualan);
            }
            sw.Close();
            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.kirimPrinter();
        }
    }
}
