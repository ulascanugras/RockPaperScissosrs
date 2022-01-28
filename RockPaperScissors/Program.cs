using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan rock icin r, paper icin p, scissors icin s tuslamasını isteyiniz r icin r yada R olma durumunu kabul ediiniz Exit icin ise e yada E/exit tusasın.
            //kullanıcı cıkıs tusuna basmadıgı sürece giris yaptıgı ve bilgisayarında rasgele bir secım yaparak her tur ıcın kım kazanırsa onun puanını artttırınız(playerscore, computerscore)

            // her tur sonunda kımın kazandıgını yada berabere olma durumunu bılgılendırınız ve aynı zamanda score larıda ekrana yazdırınız
            // her tur bıttıkten sonra yeni tur basladıgında ıse console ekranını temizleyiniz
            //kullanıcı cıkıs tusuna bastığında console u kapatınız

            int lose = 0;
            int win = 0;
            string key = "";
            do
            {
                
                Console.WriteLine("This is a Rock Paper S   cissors game");
                Console.WriteLine("Press E or ESC to exit the game. Press any key to continue");
                Console.WriteLine("Press (R,r) key  for Rock, (P,p) key for Paper, (S,s) key for Scissors ");
                key = (Console.ReadLine().ToLower());
                Console.WriteLine($"your choice =  {key}");
                string[] computerChoose = { "P", "r", "s" };
                Random rnd = new Random();
                int a = rnd.Next(3);

                if (key == "r" && computerChoose[a] == "p")
                {
                    lose++;

                }
                if (key == "r" && computerChoose[a] == "s")
                {
                    win++;

                }
                if (key == "s" && computerChoose[a] == "p")
                {
                    win++;

                }
                if (key == "s" && computerChoose[a] == "r")
                {
                    lose++;

                }
                if (key == "p" && computerChoose[a] == "r")
                {
                    win++;

                }
                if (key == "p" && computerChoose[a] == "s")
                {
                    lose++;

                }
                Console.WriteLine("kullanıcı  pc yi " + win+ "kadar yeniyor");
                Console.WriteLine("kullanıcı  pc ye  " + lose + "kadar yeniliyor" );

            } while (key!= "e");

   




;

        }
    }
}
