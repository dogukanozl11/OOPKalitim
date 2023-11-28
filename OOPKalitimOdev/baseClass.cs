using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdev
{
    public class baseClass
    {
        public static int sayac = 1; //İlk oluştuğu zaman 1 değerini alsın.
        public baseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }
        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                //bir sayaç içerisindeki değerden faydalanmak istiyoruz.
                //_id = sayac;
                //sayac = sayac + 1;
                //Nedeni basit set alanı private olarak işaretli
            }
        }  //*
        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                bool kontrolIslemi = sanalDataBase.dbBarkodKontrol(value);
                if (!kontrolIslemi) //Değeri sanal DataBase içinde bulamadım.
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        } //*
        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime gücellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }
    }
}
