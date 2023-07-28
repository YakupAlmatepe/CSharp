using System.Net.WebSockets;

namespace ıffdemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Başla
            2.ad soyad alınır
            3.yaş alınır
            4.eğitim durumu alınır ( i:ilkokul veya altı , o : ortaokul l: lise , ü: üniversit veya üstü)
            5.eğer yaş 18 den büyük eşitse
            6.eğer eğitim lise veya üstü ise 
            7.ad soyad yazdır v ehliyet alabilirsiniz yazdır
            8.eğer yaş 18 den küçükse
            9.ad soyad yazdır v ehliyet alamazsınız
            10.eğer eğitim lis altı ise
            11.ad soyad yazdır ve ehliyt alamazsınız yazdır
            12.bitiş
            */

            Console.WriteLine("*** Yaş ve eğitim durumuna göre ehliyt alabilme ***");
            Console.Write("Adınız soyadınız:");
            string adSoyad = Console.ReadLine();

            if (adSoyad == "")
            {
                Console.WriteLine("Ad soyad girilmelidir!");
            }
            else
            {
                Console.WriteLine("Yaşınız");
                string yas = Console.ReadLine();
                byte yasSayiDeğeri = Convert.ToByte(yas);
                if (yasSayiDeğeri < 0 || yasSayiDeğeri > 120) ;
                
                        
            }

           





        }
    }
}