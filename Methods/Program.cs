namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adSoyad; //camel case deniyor // değişkenlerde camel case 

            DisplayHello(); // metodun çağrılması invoke demek 

            string sonuc = MerhabaGetir();
            Console.WriteLine(sonuc + "!"); // mrhaba yazdırdık sonuna ünlem ekledik bunun anlamı o 

            İkiSayiTopla(5, 7);

            int sayi1 = -10;
            int sayi2 = 20;
            İkiSayiTopla(sayi1, sayi2);

            double result = İkiSayiCarp(1.23f, -5.5);  // aynı sınırda sonuç yazılı olduğu için onun yerine result yazdık 
            Console.WriteLine(result);

        }
        static void DisplayHello()// pascal case,implementasyon (oluşturulmasında bir problem yok )
        {
            Console.WriteLine("Hello!");
            // void bir metod geriy çıktı dönmyecekse void (yani burada sadece konsoldan hello yazıdrmasını istiyoruz 

        }
        static string MerhabaGetir()
        {
            string sonuc;
            sonuc = "Merhaba";

            return sonuc; // geri dönme anahtar kelimesi 



        }

        static void İkiSayiTopla(int sayi1, int sayi2)
        {

        int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);

        }

        static double İkiSayiCarp(float f1,double d2)
        {
            return f1 * d2;
            
        }
    }
}