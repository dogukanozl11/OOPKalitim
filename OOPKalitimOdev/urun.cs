using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdev
{
    public class urun : baseClass
    {
        public string marka { get; set; } // * belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin.
        public string model { get; set; }




        private decimal _alısFiyat;
        public decimal alısFiyat
        {
            get { return _alısFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alıs fiyatı 0 dan küçük veya eşit olamaz ....");
                }
                else
                {
                    _alısFiyat = value;
                }
            }
        } // 0 dan küçük olmamalı


        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get { return _satisFiyat; }
            set
            {
                if (value < _alısFiyat)
                {
                    Console.WriteLine("Ürünün satis fiyatı alış fiyatından küçük olamaz ....");
                }
                else
                {
                    _satisFiyat = value;
                }
            }
        } //alis fiyatından küçük olamaz


        private decimal _kampanyafiyat;
        public decimal kampanyaFiyat 
        { get  { return _kampanyafiyat; }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük veya eşit olamaz ....");
                }
            } 
        } // kampanya fiyat değeri 0 dan küçük olamaz
    }
}
