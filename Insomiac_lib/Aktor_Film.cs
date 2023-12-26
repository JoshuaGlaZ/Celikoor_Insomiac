using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Insomiac_lib
{
    public class Aktor_Film
    {
        private Aktor atr;
        private string peran;

        public Aktor_Film()
        {
            Atr = new Aktor();
            Peran = "";
        }

        public Aktor_Film(Aktor atr, string peran)
        {
            Atr = atr;
            Peran = peran;
        }

        public Aktor Atr { get => atr; set => atr = value; }
        public string Peran { get => peran; set => peran = value; }
    }
}
