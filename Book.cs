using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA24120203WM
{
    internal class Book
    {
        Random rnd = new Random();
        public long ISBN { get; set; }
        //public List<Author> Szerzok = [];
        public string Szerzok { get; set; }
        public string Cim { get; set; }
        public int Kiadas_eve { get; set; }
        public string Nyelv { get; set; }
        public int Keszlet { get; set; }
        public int Ar { get; set; }

        public override string ToString() =>
        $"\nISBN azonosító: {ISBN}\n" +
            $"Szerző(k) lista: {Szerzok}\n" +
            $"Cím: {Cim}\n" +
            $"Kiadás éve: {Kiadas_eve}\n" +
            $"Nyelv: {Nyelv}\n" +
            $"Készlet: {Keszlet} db\n" +
            $"Ár: {Ar} Ft";

        /// <summary>
        /// Adjon meg minden adatot
        /// </summary>
        /// <param name="iSBN">10 számjegyű számsor</param>
        /// <param name="szerzok">[1-3] elemű Author osztály példányait tartalmazó lista</param>
        /// <param name="cim">minimum 3, maximum 64 karakter hosszú karakterlánc</param>
        /// <param name="kiadas_eve">2007 és a jelen év közti egész szám</param>
        /// <param name="nyelv">csak az angol, német és magyar az elfogadott érték</param>
        /// <param name="keszlet">egész szám, minimum 0</param>
        /// <param name="ar">1000 és 10000 közötti, kerek 100as szám</param>
        public Book(long iSBN,string szerzok, string cim, int kiadas_eve, string nyelv, int keszlet, int ar)
        {
            ISBN = iSBN;
            Szerzok = szerzok;
            //if (szerzok.Count() < 4 && szerzok.Count() > 0)
            //{
            //       Szerzok = szerzok;
            //}
            //else
            //{
            //    throw new Exception("Csak 1-3 szerzőt adhat meg!");
            //}
            if (cim.Length > 2 && cim.Length < 65)
            {
                Cim = cim;
            }
            else
            {
                throw new Exception("minimum 3, maximum 64 karakter hosszú karakterlánc LEHET");
            }
            if (kiadas_eve > 2006 && kiadas_eve < 2025)
            {
                Kiadas_eve = kiadas_eve;
            }
            else
            {
                throw new Exception("2007 és a jelen év közti egész szám LEHET");
            }
            if (nyelv.ToUpper() == "MAGYAR" || nyelv.ToUpper() == "NÉMET" || nyelv.ToUpper() == "ANGOL")
            {
                Nyelv = nyelv;
            }
            else
            {
                throw new Exception("csak az angol, német és magyar az elfogadott érték");
            }
            if (keszlet >= 0)
            {
                Keszlet = keszlet;
            }
            else
            {
                throw new Exception("minimum 0");
            }
            if (ar >= 1000 && ar <= 10000 && ar % 100 == 0)
            {
                Ar = ar;
            }
            else
            {
                throw new Exception("1000 és 10000 közötti, kerek 100as szám");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="szerzok">1 szerző neve</param>
        /// <param name="cim">minimum 3, maximum 64 karakter hosszú karakterlánc</param>
        public Book(string szerzok, string cim)
        {
            ISBN = rnd.Next(100000000,999999999);
            Szerzok = szerzok;
            //if (szerzok.Count() == 1)
            //{
            //    Szerzok = szerzok;
            //}
            //else
            //{
            //    throw new Exception("Csak 1 szerzőt adhat meg!");
            //}
            if (cim.Length > 2 && cim.Length < 65)
            {
                Cim = cim;
            }
            else
            {
                throw new Exception("minimum 3, maximum 64 karakter hosszú karakterlánc ADHATÓ MEG!");
            }
            Kiadas_eve = 2024;
            Nyelv = "Magyar";
            Keszlet = 0;
            Ar = 4500;
        }
    }
}
