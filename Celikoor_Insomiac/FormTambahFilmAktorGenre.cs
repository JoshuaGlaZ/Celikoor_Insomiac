using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insomiac_lib;

namespace Celikoor_Insomiac
{
    public partial class FormTambahFilmAktorGenre : Form
    {
        public Film film = new Film();
        public List<Aktor_Film> aktors = new List<Aktor_Film>(); 
        public List<Genre_Film> genres = new List<Genre_Film>();

        public FormTambahFilmAktorGenre()
        {
            InitializeComponent();
        }

        private void FormTambahFilmAktorGenre_Load(object sender, EventArgs e)
        {
            labelFilm.Text = string.Join(" ", film.Judul.Select(c => c.ToString().ToUpper()));
            foreach (Genre_Film gf in genres)
            {
                dataGridViewGenreFilm.Rows.Add(gf.Gnr.Id, gf.Gnr.NamaGenre, gf.Gnr.Deskripsi);
            }

            foreach (Aktor_Film af in aktors)
            {
                dataGridViewAktorFilm.Rows.Add(af.Atr.Id, af.Atr.Nama, af.Atr.TglLahir,
                                        af.Atr.Gender, af.Atr.NegaraAsal, af.Peran);
            }

        }
    }
}
