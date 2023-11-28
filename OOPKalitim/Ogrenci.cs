using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    public sealed class Ogrenci:BaseType
    {
        public String bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Öğrenci Nesnesi Yapıcı Metot");

            //TemelTipMetot2(); Protected olarak işaretlendiği için ve bu nesne kendisini temeltip
            //nesnelerinden kalıtıldığı için protected seviyesinde olan field veya metotlara erişebilir.



        }
    }
}
