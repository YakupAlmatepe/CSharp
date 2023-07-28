using System.ComponentModel.Design;

namespace ıffdemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogruKullaniciAdi = "gizem";
            string dogruSifre = "123";
            Console.WriteLine("*** Kullanıcı Girişi ***");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre:");
            string sifre = Console.ReadLine();

            if (dogruKullaniciAdi == kullaniciAdi)

            {
                if (dogruSifre == sifre)
                {
                    Console.WriteLine("Kullanıcı adı ve şifreniz doğrudur,");
                    Console.WriteLine("hoşgeldiniz");



                }

                else // ! ( dogruSifre== sifre) -> dogruSifre ! = sifre{
                {
                    Console.WriteLine("Şifreniz yanlıştır,tekrar deneyiniz....");
                }




            }
            else //!(dogruKullaniciAdi == kullaniciAdi)->dogruKullaniciAdi! = kullaniciAdi
            {
                

            }
             

            
        }
      
    }
}