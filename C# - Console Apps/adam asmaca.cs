using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._25
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] kelime = { "ankara",  "adana", "erzurum" };
            Random rnd = new Random();
            int randomsayi = rnd.Next(0, kelime.Length);
            int uzunluk = kelime[randomsayi].Length;
            string bilmece =kelime[randomsayi];

            char[] soru = bilmece.ToCharArray();
            
            for (int i = 0; i < soru.Length; i++)
            {
                soru[i] = '_';
            }
           
            String gelen;
            char geldi;
            int puan = 0;
            for (int i = 8; i>=0; i--) //toplam hak
            {
                if (puan == soru.Length * 100)
                {
                    Console.WriteLine("Puaniniz :{0}", puan);
                    Console.WriteLine("###-> {0} <-### Tebrikler Kazandiniz!",bilmece);
                    break;
                }
                Console.WriteLine("Kalan Hakkiniz {0} kadardir", i);
                Console.WriteLine("Puaniniz :{0}", puan);
                Console.WriteLine(soru);
                Console.WriteLine("harf giriniz");
                gelen = Console.ReadLine();
                geldi = Convert.ToChar(gelen);

                for (int j = 0; j < soru.Length; j++)
                {
                    
                    if (geldi == bilmece[j])
                    {
                        soru[j] = geldi;
                        puan += 100;
                    }
                }
            }

            Console.Read();
        }

    }
}
