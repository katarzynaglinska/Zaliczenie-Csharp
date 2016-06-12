using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Sklep
    {
        public string Nazwa { get; set; }
        public List <Produkt> Produkty { get; set; }
        public Osoba Wlasciciel { get; set; }

        public Sklep()
        {
           
            Produkty = new List<Produkt>();
        }
    }
}
