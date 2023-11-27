using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    public class Egitmen:BaseType
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }
        public DateTime IsBaslangıcTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzınGunSayisi { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin Yapıcı Metotu");
        }
    }
}
