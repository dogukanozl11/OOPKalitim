using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    public class Personel:BaseType
    {
        public DateTime IsBaslangıcTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzınGunSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel Nesnesi Yapıcı Metot");
        }

    }
}
