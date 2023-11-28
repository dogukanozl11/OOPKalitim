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
            IDAtamaISlemi();
        }
        private void IDAtamaISlemi()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 9000);
        }
        public void TemelTipMetot1()
        {
            Console.WriteLine("Temel Tip => Metot 1");
            //TemelTipMetot2(); protected olduğu için class içerisinde private gibi davranır.
        }
        protected void TemelTipMetot2() 
        { 
            Console.WriteLine("Protected Metot"); 
        }
    }
}
