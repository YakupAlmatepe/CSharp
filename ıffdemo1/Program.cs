namespace ıffdemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             * 1.başla
             * 2.kullanıya 0 ile 100 arasında not sorulur 
             * 3.kullanıcıdan not alınır
             * 4.eğer kullanıcının notu 0 dan küçük veya 100 de büyükse ekrana geçrsiz not yazdırılır 
             * 5.eğer kullanıcının notu 0 ise ekrana kaldı yazdırılır,
             * 6.eğer kullanıcının notu 6 ile 100 arasında ise ekrana geçti yazdır 
             * 7.bitiş,
             * */

            Console.Write("Not Giriniz");
            int not = Convert.ToInt32(Console.ReadLine());


            ////if (not < 0 || not > 100)
            ////{
            ////    Console.WriteLine("Geçersiz not");
            ////}
            ////else //!( not < 0 || not > 100 ) = && <=100 
            ////{

            ////    if (not >= 0 && not < 60) //sadce not < 60 da yazılabir
            ////    {
            ////        Console.WriteLine("Kaldı");
            ////    }
            ////    else// ! (not >=0 && not <= 60) = ( not < 0 || not >=60 ) && <=100  -> not >= 60 

            ////        Console.WriteLine("Geçti");

            //    }
            {




                if (not >= 0 && not < 60)
                    Console.WriteLine("Kaldı");
                else if (not >= 60 && not <= 100)
                    Console.WriteLine("Geçti");
                else
                    Console.WriteLine("Geçersiz Not");


        }


        }

        }
    }
