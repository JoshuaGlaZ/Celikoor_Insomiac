using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insomiac_lib
{
    public class Genre_Film
    {
        private Genre gnr;

        public Genre_Film()
        {
            Gnr = new Genre();
        }

        public Genre_Film(Genre gnr)
        {
            Gnr = gnr;
        }

        public Genre Gnr { get => gnr; set => gnr = value; }
    }
}
