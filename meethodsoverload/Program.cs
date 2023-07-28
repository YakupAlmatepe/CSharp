namespace meethodsoverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(1, 2);
            Console.WriteLine("Toplam:" + toplam);
            double sum =Topla(1.1, 2.2);
            Console.WriteLine(sum); // 3.3 olarak konsola yazdırır

            sum = Topla(-1, -2, -3, -4);
            Console.WriteLine(SumAll(1, 2));


            
            
        }

        static int Topla(int sayi1,int sayi2)
            {
            int toplam;
            toplam  = sayi1 + sayi2;
            return toplam;
            

        }

        static double Topla(double sayi1, double sayi2)// method oveerload 

        {
            return sayi1 + sayi2;
        }


            static double Topla(double sayi1, double sayi2,double sayi3, double sayi4=4)// method oveerload 

            {
            return sayi1 + sayi2 + sayi3 + sayi4  ;


            }

        //params anahtar kelimesi meetotlarda //

        static decimal SumAll(params decimal[]numbers)
        {
          return  numbers.Sum();





        }
    }
}