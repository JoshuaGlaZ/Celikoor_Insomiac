using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class Ticket
    {
        string nomor_kursi;
        int status;
        double harga;
        JadwalFilm jadwalFilm;
        Studio studio;
        Film film;
        Pegawai op;  

        public Ticket(string nomor_kursi, double harga, JadwalFilm jadwalFilm, Studio studio, Film film)
        {
            Nomor_kursi = nomor_kursi;
            Status = 0;
            Harga = harga;
            JadwalFilm = jadwalFilm;
            Studio = studio;
            Film = film;
        }
        public Ticket()
        {
            Nomor_kursi = "";
            Status = 0;
            Harga = 0;
            JadwalFilm = new JadwalFilm();
            Studio = new Studio();
            Film = new Film();
            op = new Pegawai(); 
        }

        public string Nomor_kursi { get => nomor_kursi; set => nomor_kursi = value; }
        public int Status { get => status; set => status = value; }
        public double Harga { get => harga; set => harga = value; }
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        public Pegawai Op { get => op; set => op = value; }

        public static void CekHadir(string invoice, string noKursi, Pegawai p)
        {
            string perintah = "Update tikets set status_hadir = 1, operator_id = '" + p.Id + "' where invoices_id ='" + invoice + "' and nomor_kursi='" + noKursi + "';";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
