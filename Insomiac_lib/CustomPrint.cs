using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace Insomiac_lib
{
    public class CustomPrint
    {
        private Font tipeFont;
        private StreamReader fileCetak;
        private float mAtas, mBawah, mKanan, mKiri;

        public CustomPrint(Font tipeFont, string file)
        {
            TipeFont = tipeFont;
            FileCetak = new StreamReader(file);
            MAtas = 10;
            MBawah = 10;
            MKanan = 10;
            MKiri = 10;
        }

        public Font TipeFont { get => tipeFont; set => tipeFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MAtas { get => mAtas; set => mAtas = value; }
        public float MBawah { get => mBawah; set => mBawah = value; }
        public float MKanan { get => mKanan; set => mKanan = value; }
        public float MKiri { get => mKiri; set => mKiri = value; }

        private void Cetak(object sender, PrintPageEventArgs e)
        {
            int maxRow = (int)((e.MarginBounds.Height - MAtas - MBawah) / TipeFont.GetHeight(e.Graphics)); //menghitung berapa baris yang bisa ditulisi
            float y;
            float x = MKiri;

            int rowSekarang = 0;
            string textCetak = FileCetak.ReadLine();
            while (rowSekarang < maxRow && textCetak != null)
            {
                y = MAtas + (rowSekarang * TipeFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(textCetak, TipeFont, Brushes.DarkBlue, x, y); //menulis ke memory
                rowSekarang++;
                textCetak = FileCetak.ReadLine();
            }
            if (textCetak != null)
            {
                e.HasMorePages = true; //lanjut halaman selanjutnya
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void kirimPrinter()
        {
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();
            FileCetak.Close();
        }
    }
}
