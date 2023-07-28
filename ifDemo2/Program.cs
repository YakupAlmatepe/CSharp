namespace ifDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Algoritma 
             * 1-başla
             * 2-vize1 gir
             * 3-vize2 gir
             * 4-final gir
             * 5-ortalama=(vize1+vize2)*0.2+final*0.6
             * 6-eger ortalama<60 kaldi
             * 7-eger ortalama>=60 geçti
             * 8-bitir
             */

            string ogrenciAdi;
     double  vize1, vize2, final, ortalama;
     const  double vize1carpan = 30.0 / 100.0; // 0.3 verir 
     const      double viz2carpan = 0.3;
     const      double finalCarpan = 0.4;

            
             

           Console.Write("Öğrenci adı:");
            ogrenciAdi = Console.ReadLine();

            Console.Write("Vize 1:");
            vize1 = int.Parse(Console.ReadLine());

            Console.Write("Vize 2:");
            vize2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final:");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = vize1 * vize1carpan + vize2 * viz2carpan + final * finalCarpan;

            if (ortalama >= 60)
                Console.WriteLine($"Geçti (Not :  {ortalama})");

            else // ortalama <60 
                Console.WriteLine("Kaldı (Not:" + ortalama + ")");








        }
    }
}