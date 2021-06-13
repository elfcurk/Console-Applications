using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomsayi = rnd.Next(1, 100);
            string sayi;
            int deger;
            string tamamDevam;


            for (int i = 3; i > 0; i--)
            {
                for (int j = 10; j >= 1;)
                {
                    Console.WriteLine("Tahmininizi Giriniz");
                    sayi = Console.ReadLine();
                    deger = Convert.ToInt32(sayi);
                    if (deger == randomsayi)
                    {
                        Console.WriteLine("Tebrikler Buldunuz");
                        Environment.Exit(1);
                        
                    }
                    else
                    {
                        j = j - 2;
                        Console.WriteLine("Kalan canınız {0}", j);
                    }


                }
                Console.WriteLine("Kalan Jeton Sayınız {0} devam etmek için o'ya çıkmak için herhangi bir tuşa basınız", i-1);
                tamamDevam = Console.ReadLine();
                char karakter = Convert.ToChar(tamamDevam);
                if (karakter != 'o')
                {
                    break;
                }
               
            }
        }
    }
}
