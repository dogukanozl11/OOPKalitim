using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            BaseType Bt = new BaseType();
            Bt.TemelTipMetot1();

           Egitmen E1 = new Egitmen();
            Console.WriteLine("Eğitmen nesnesi ");

            E1.TemelTipMetot1();

            //ÖZel tiplerde Boxing ve Unboxing

            //Bizim Object nesnemiz nedir ?
            // CVP - Temel Tİp = BaseType
            BaseType T2;
            //Hangi Nesnelerde temeltip object gerevi görür...
            //Personel Eğitmen Öğrenci
            //TemelTip Nesnesinden türedikeri için temeltip nesnesi bu nesnelerde object gibi davranır.

            T2 = E1; //Eğitmen nesnesini TemelTip nesnesine atadık.
            E1 = (Egitmen)T2; //Unboxing

            Personel P1 = new Personel();
            T2 = P1;  //Personel nesnesini TemelTip nesnesine atadık.
            P1 = (Personel)T2;//Unboxing

            Ogrenci O1 = new Ogrenci();
            T2 = O1; //Ogrenci nesnesini TemelTip nesnesine atadık.
            O1 = (Ogrenci)T2;//Unboxing

           // object o3 = T2;

            //Boxing -- Unboxing

            object O = E1;  //Boxing
            E1 = (Egitmen)O; //Unboxing
            */
         /*
            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object Obj = O1;
            //O1 = (Ogrenci)Obj;

            //Obj = P1;
            //P1 = (Personel)Obj;

            //Ben istiyorum ki türemiş olan tiplerim türeyemesin
            //Object => TemelTip => Personel => 
            //                   => Öğrenci => X
            //                   => Eğitmen => X
            //156.video
            //Test T1 = new Test();
            //T1.

            //Hangi nesnemizin kalıtılmasını istemiyoruzu.
            //Eğitmen sealed

            Egitmen E1 = new Egitmen();
            //Eğitmen => Personel => BaseType => Object
            //Object => BaseType => Personel => Eğitmen

            //Public : uygulamamızı içerisinde veya dışarısında ulaşılabilir anlamını taşır
            //Private : Sadece tanımlandığı class içerisinde erişilebilir olur.
            //Protected : Normal kullanımda private olarak davranır. Kalıtım yolu ile başka bir class içerisinde public olarak kullanılır.
            BaseType T1 = new BaseType();
            
            Ogrenci o1 = new Ogrenci();
            o1.TemelTipMetot1();
         */
        }
    }
}
