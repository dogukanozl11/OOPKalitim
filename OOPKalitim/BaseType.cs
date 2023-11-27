using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    public class BaseType
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string Soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayıtTarih { get; set; }
        public int kayıtKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public BaseType()
        {
            Console.WriteLine("BaseType Yapıcı Metot");
        }

    }
}
