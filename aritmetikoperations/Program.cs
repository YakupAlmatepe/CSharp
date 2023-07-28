using System.Threading.Channels;

namespace aritmetikoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplam1 = 1 + 2;
            Console.WriteLine("1 +2 = " + toplam1); //1+2 =3 yazdıracak konsola 

            int toplam2 = 1 + 2 + 3 + 4;
            Console.WriteLine($"1+2+3+4={toplam2}");// konsola 10 sonucunu yazdıracak 

            int n1, n2;
            int n3;
            int n4;


            int no1 = 11, no2 = 22, no3 = 33;
            int no4 = 44;
           

            int toplam3 = no1 + no2 + no3 + no4;
            Console.WriteLine("Toplam3="+toplam3); // 110

            long sayi1 = -111;
            sayi1 = sayi1 + 11;
            Console.WriteLine("Sayı1:"+sayi1);//-100

            //sayi1 = sayi1 + 50;
            sayi1 += 50; // aynı şey ileride kullanılır
            Console.WriteLine("Sayı 1:"+sayi1);

            short sayi2 = 32766;

            //int sayi3=sayi2+1;

            ++sayi2; //  sayi2++; // sayi2+= 1; // sayi= sayi2+1 

            Console.WriteLine(sayi2);

            byte yas1 = 10;
            byte yas2 = 20;
            byte yas3 = 100;

            int toplamYas = yas1 + yas2 + yas3;

            long sayi3 = 3;
            Console.WriteLine("S3:"+sayi3++); // 3 yazdırır konsola 
            Console.WriteLine("S3:"+sayi3);//4

            sayi3 = 3;
            Console.WriteLine("S3:"+ ++sayi3); // 4 yazdırır 
            Console.WriteLine("S3:" + sayi3);

            int s1 = 22;
            int s2 = 11;
            Console.WriteLine("Fark:" + (s1 - s2));

            double s3 = 8.9;
            s3 -= 0.9;
            Console.WriteLine(s3);//

            double s4 = 9;
            --s4;// değeri 8 oluyor 
            Console.WriteLine(s4);

            int sayi11 = 11;
            int sayi12 = 22;
            int carpim = sayi11 * sayi12;
            Console.WriteLine($"{sayi11} * {sayi12} * ={carpim}");

            long l1 = 14;
            long l2 = 5;
            long bolum1= 11 / 12;//2.8 
            Console.WriteLine("Bölüm1:"+ bolum1);

            double bolum2 = (double)l1;//14.0/5.0=2.8
            Console.WriteLine("Bölüm 2:" + bolum2);

            double l11 = 14;
            double l22 = 5;
            double bolum22 = l11 / l22;
            Console.WriteLine("Bölüm 22:" + bolum22);

            //dikkat edelim !
            double test2 = 2.0;
            int test1 = (int)test2;

            decimal dcml1 = 15.5m;
                dcml1 /= 5;//dcml1=dcml1/5
            Console.WriteLine(dcml1);

            int numara1 = 21, numara2 = 2;
            int kalan = numara1 % numara2;// kalan 1
            Console.WriteLine("Kalan:" + kalan);

            int numara3 = 23;
            numara3 %= 3; // numara 3 %3
            Console.WriteLine("Kalan:{0}", numara3);




























        }
       
        
    }
}