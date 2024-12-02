using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA24120203WM
{
    internal class Author
    {
        public string Veznev { get; set; }
        public string Kernev { get; set; }
        public string Nev { get; set; }
        public Guid Guid { get; set; }

        public override string ToString() =>
        $"\nNév: {Nev}\nAz Egyedi azonosítója: ({Guid})";
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="veznev">Adja meg a vezetéknevet</param>
        /// <param name="kernev">Adja meg a keresztnevet</param>
        public Author(string veznev, string kernev){
            if (veznev.Length > 2 && veznev.Length < 33 && kernev.Length > 2 && kernev.Length < 33)
            {
                Nev = veznev + " " + kernev;
            }
            else
            {
                throw new Exception("a név részei egyenként minimum 3, maximum 32 karakter hosszúak LEHETNEK");
            }
            Guid = Guid.NewGuid();
        }
    }
}
