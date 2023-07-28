using System.Net.WebSockets;

namespace DataTypesAndVariables
{
    internal class Program

    {

        static void Main(string[] args)
        {
            #region
            //bu bir yorum mutlaka yorum yazılmalı 

            /*

                Yorum satırı 1
                Yorum satırı 2 
            */
            #endregion

            Console.WriteLine("Hello,World");

            #region Value Types (değer tipler)

            int sayi1;// declare (tanımlama) 32 bit tam sayı veri tipi -2 2 milyar küsür arasında 

            sayi1 = 20;//assignment (atama)

            Console.WriteLine("Sayı:" + sayi1 + " sayısıdır");    //concatenation  
            Console.WriteLine("Sayı:{0}", sayi1);
            Console.WriteLine($"Sayı:{sayi1}");

            Console.WriteLine("int max:" + int.MaxValue + "int min:" + int.MinValue);

            int sayi1eski = sayi1;

            sayi1 = 200;
            Console.WriteLine("Sayı:" + sayi1 + ",eski sayı:" + sayi1eski);

            uint sayi2;//unsigned ,pozitif tam sayı tutabiliriz 0 dahil 0.4 milyar arasında veri tutabiliriz 
            sayi2 = 3000000000;
            Console.WriteLine(sayi2);

            long sayi3 = 3000000000;// 64 bit 9 kentilyon aralığında her veriyi tutar 
            Console.WriteLine("Sayı3:" + sayi3 + "'tür.");

            ulong sayi4 = 0; // 0 ile 18 kentilyon arasında veri tutar 
            Console.WriteLine(sayi4);

            short sayi5 = 26;//-32000 +32000 aralığında veri tutabiliyor 16 bit 
            Console.WriteLine("Sayı:" + sayi5 + ",short min:" + short.MinValue + "short.max:" + short.MaxValue);

            ushort sayi6 = 126; // 0.... 64000
            Console.WriteLine(sayi6);

            byte sayi7 = 255;// 8 bitlik 0 ile 255
            Console.WriteLine(sayi7);

            sbyte sayi8 = -100; // -128 127 arasında veri tutulabiliyor

            bool durum = true;// veya false true karşılığı 1 false karşılığı 0 
            Console.WriteLine("Durum:" + durum);

            durum = false;
            Console.WriteLine("Yeni durum:" + durum);

            char karakter = 'A';// BİRDEN ÇOK KARAKTER OLMAZ 
            Console.WriteLine("Karakter:" + karakter + ",ASCII:" + (int)karakter);

            int sayi9 = 9;
            long sayi10 = (long)sayi9;
            Console.WriteLine(sayi10);

            //daha geniş veri tipinden daha dar veri tipine cast edilirken  dikkat edilmeli
            //long sayi11 = 3000000000000;
            //int  sayi12 = (int)sayi10;
            //Console.WriteLine(sayi12);

            //ondalık sayı tipleri 

            double sayi13 = 1.7;// 64 bitlik veri tipi 
            Double sayi14 = -2.8;// ikiside aynı 
            Console.WriteLine(sayi13 + "," + sayi14);

            float sayi15 = 22.897f;//32 bit veri tipi sayının sonuna büyük veya küçük f 
            Console.WriteLine(sayi15);

            decimal sayi16 = -123.456789m; //sonuna büyük yada küçük m 192 bit 
            Console.WriteLine(sayi16);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.WriteLine("Gün:" + Gunler.Salı +",değeri:"+(int)Gunler.Salı);
            Console.WriteLine("Gün:{0},değeri:{1}",Gunler.Salı,(int)Gunler.Salı);
            Console.WriteLine($"Gün:{Gunler.Salı},değeri:{(int)Gunler.Salı}");
            Console.WriteLine("Kişinin cinsiyeti"+Cinsiyet.Kadın+"'dır.");
            Console.WriteLine("Kişinin cinsiyet değeri"+(int)Cinsiyet.Kadın+"'dur.");
            #endregion

            #region Referans Types (referans tipler)

            string characters = "Ankara"; // 2 milyar byte 
            Console.WriteLine(characters+","+characters+".güzel"+ characters);// Ankara Ankara güzel ankara

            string ad1; // declaration

            ad1 = "Gizem"; // assigment

            var ad2="Leo";

            

            Console.WriteLine(ad2);// leo

           


            #endregion




        }
    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,

        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar

    }

    enum Cinsiyet
    {
        Kadın,
        Erkek


    }
}

