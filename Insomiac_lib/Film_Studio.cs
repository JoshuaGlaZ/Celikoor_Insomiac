using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Film_Studio
    {
        private Studio std;
        private Film flm;

        public Film_Studio()
        {
            std = new Studio();
            flm = new Film();
        }

        public Studio Std { get => std; set => std = value; }
        public Film Flm { get => flm; set => flm = value; }

        public static List<Film_Studio> BacaData(string kodeStudio, string kodeFilm)
        {
            List<Film_Studio> lst = new List<Film_Studio>();
            string perintah = "SELECT * FROM film_studio;";
            if (kodeStudio != "" && kodeFilm!="") { perintah = "SELECT * FROM film_studio WHERE studios_id="+kodeStudio+" AND films_id="+kodeFilm+";"; }
            else if (kodeStudio != "") { perintah = "SELECT * FROM film_studio WHERE studios_id=" + kodeStudio + ";"; }
            else if (kodeFilm != "") { perintah = "SELECT * FROM film_studio WHERE films_id=" + kodeFilm + ";"; }
            MySqlDataReader msdr = Koneksi.JalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Film_Studio fs = new Film_Studio();
                fs.Std = Studio.BacaData("id",msdr.GetValue(0).ToString())[0];
/*                fs.Flm = Film.BacaData("id",msdr.GetValue(1).ToString())[0];
*/                lst.Add(fs);
            }
            return lst;
        }

        public static void MasukanData(Film_Studio fs)
        {
            string perintah = "INSERT INTO film_studio (studios_id, films_id) " +
                "VALUES ('" + fs.Std.Id + "', '" + fs.Flm.Id + "');";
            Koneksi.JalankanPerintah(perintah);
        }
    }
}
