using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Produkt
    {
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public bool Sprzedane { get; set; }
       

        public string Pokaz
        {
            get
            {
                return string.Format("{0} - ${1}", Tytul, Cena);
            }
        }

    }
}
