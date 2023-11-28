using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            //B1.id = 1;  // Girmek istemiyorum , uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyoorum...
            B1.marka = "Lenovo";
            B1.model = "z50";
            B1.işlemci = "İ7";
            B1.alısFiyat = 1000;
            B1.satisFiyat = 1750;
            B1.kampanyaFiyat = 100;
            B1.barkod = "1234567890"; // =>

            sanalDataBase.yeniUrunEkle(B1);



            bilgisayar B2 = new bilgisayar();
            //B1.id = 1;  // Girmek istemiyorum , uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyoorum...
            B2.marka = "Lenovo";
            B2.model = "z50";
            B2.işlemci = "İ7";
            B2.alısFiyat = 1000;
            B2.satisFiyat = 1750;
            B2.kampanyaFiyat = 100;
            B2.barkod = "1234567890"; // =>

            sanalDataBase.yeniUrunEkle(B2);
        }
    }
}
