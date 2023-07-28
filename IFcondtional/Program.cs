using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace IFcondtional
    //arithmetic operators :+,-,*,/,%

    //relational operators :== >= <= < <  !=

    // assigmant operator:= // atama operotörü 
    
    // logical operators:&& || and ve or   ! (değil)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            if (sayi == 10) // sayı 10 a eşitmi demek 
            {
                Console.WriteLine("On");
            }

            sayi = 30;
            if (sayi == 10)


            {
                Console.WriteLine("on");

            }
            else
            {
                Console.WriteLine("on değil");


            }

            string adSoyad;
            Console.WriteLine("adınızı ve soyadınızı giriniz");
            adSoyad = Console.ReadLine();
            Console.WriteLine("adınız vee soyadınız :" + adSoyad); // write alt satıra geçmiyor yan yana yazılıyor writeline arasındaki fark bu 



            #region yaş grubu

            /*
            1.başla
            2.kullanıcıya yaşı sorulur
            3.kullanıcıdan yaşı al 
            4.kullanıcının yaşı 0 ile 30 arası ise gnç 
            5.kullanıcının yaşı 31 60 arası ise orta 
            6.kullanıcının yaşı 60 üstü yaşlı
            7.ekrana kullanıcının yaşı ile yaş karşılığı yazdırılır 
            8. bitir

            */

            /*önermeler 
        p           and  (&&) (VE)    q           sonuç

       true         and              true           true  1*1=1
       true                          false          false 1*0=0
       false                         true           false 0*1=0
       false                         false          false 0*0=0


        p         or|| (veya)         q              sonuç
        true                        true           true     1+1=2
        true                        false          true     1+0=1
        false                       true           true     0+1=1
        false                       false          false    0+0=0 */



        



            
            




            string giris;
            int yas;

            Console.Write("yaş giriniz:");
            giris= Console.ReadLine();
            yas = Convert.ToInt32(giris);
            if (yas>=0 && yas<=30) 

              
            {

                Console.WriteLine("yasınız" + yas + " , yaş grubunuzu genç");

                }
           else if (yas >30 && yas <=60)
            {
                Console.WriteLine("yasınız"+ yas+",yas grubunuzu orta yaşlı");



            }


            // TODO : bir koşul grubunun değilini alma 


            if (!(yas >= 0 && yas <= 30)) // if yaş<0  || yas >30



            {
                if (yas >= 0 && yas <= 30)

                    Console.WriteLine("yaşınız" + yas + " , yaş grubunuz genç");







            }


            #endregion


            int age = 40;
            bool result = age >= 0 && age <= 40 || age > 60 && age <= 100;

            Console.WriteLine(result);


        }
    }
}