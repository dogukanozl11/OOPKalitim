using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    public sealed class Egitmen:Personel
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }

       

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin Yapıcı Metotu");
        }
    }
}
