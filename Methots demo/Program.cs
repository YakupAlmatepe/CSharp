namespace Methots_demo  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();

            Yazdir("Bugün günlerden Çarşamba.");
            string mesaj = "Bugün 19 Temmuz 2023";
            Yazdir(mesaj);
            //double piSayisi = Getpi();
            // Console.WriteLine("PI sayısı:" + piSayisi);
            Console.WriteLine("PI Sayısı :" + Getpi());

            int radius = 2;
            double area = DaireAlaniHesapla(radius);
            Console.WriteLine($"dairenin alanı {area}");

            string ad = "Gizem";
            string soyad = "Yakup";
            string kurum = "Apple";
            ad = "Leo";
            string sonuc = KurumaGorePersonelGetir(ad, soyad, kurum="Microsoft");// default parametre denir buna 
            Console.WriteLine(sonuc); 

            Console.WriteLine(KurumaGorePersonelGetir(ad,soyad));

            DepertmanaGoreCalışanGetir("Bill", "Gates",  "Microsoft", "CEO");
            DepertmanaGoreCalışanGetir("Zeynep", "Kaya");




            
         






        }

         static string KurumaGorePersonelGetir(string ad, string soyad)
        {
            return ad + " " + soyad;
        }

        static void BaslikYaz()
        {
            Console.WriteLine("Methodlar Demo");
        }

        static void Yazdir(string mesaj)
        {
            mesaj = "Mesaj:" + mesaj;
            Console.WriteLine(mesaj);

        }

        static double Getpi() // pi satısını getir dmk 
        {
            /* double pi ;  1. yöntem 
            pi=3.14
            return pi;*/

            return 3.14;
        }
        static double DaireAlaniHesapla(int yaricap)
        {

            //      double alan;
            //      double pi = GetPi();
            //     alan = pi * yaricap * yaricap;
            //   return alan;

            return Getpi() * yaricap * yaricap;




        }

        static string KurumaGorePersonelGetir(string ad, string soyad,string kurum)
        {
            return "personel:" + ad + "" + soyad + "kurum:" + kurum;

        }
        static void DepertmanaGoreCalışanGetir(string ad, string soyad, string kurum = "migros", string departman = "satış")

        {
            //string sonuc = ad + "" + soyad + "(" + kurum + "-" + departman + ")";

            string sonuc = $"{ad}{soyad} ({kurum}-{departman})";

            Console.WriteLine(sonuc);
        }
    }
}


