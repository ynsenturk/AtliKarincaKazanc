using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtliKarincaKazanc
{
    class Program
    {
        static void Main(string[] args)
        {
            int R, k, N;
            int toplamPara = 0;
            int binenSayisi = 0;
            int temp;
            int kacGrup = 0;
            int sira = 2;

            Console.WriteLine("Gun icerisinde kac defa çalisiyor? - Tek seferde kac kisi binebiliyor? - Kac adet grup vardir? (Aralarinda bosluk birakarak yaziniz)");
            string ilkSatir = Console.ReadLine();
            string[] words = ilkSatir.Split(' ');
            R = Convert.ToInt32(words[0]);
            k = Convert.ToInt32(words[1]);
            N = Convert.ToInt32(words[2]);

            Console.WriteLine(N + " gruptaki kisi sayilarini aralarinda bosluk birakarak yaziniz");
            string ikinciSatir = Console.ReadLine();
            string[] words2 = ikinciSatir.Split(' ');
            int[] grup = new int[N];
            for (int i = 0; i < N; i++)
            {
                grup[i] = Convert.ToInt32(words2[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("\n1. siralama");
            for (int rrt = 0; rrt < N; rrt++)
            {
                Console.Write("{0} ", grup[rrt]);
            }
            Console.WriteLine("");
            for (int a = 0; a < R; a++)
            {
                kacGrup = 0;
                binenSayisi = 0;
                for (int j = 0; j < N; j++)
                {
                    if (binenSayisi + grup[j] <= k)
                    {
                        binenSayisi = binenSayisi + grup[j];
                        toplamPara = toplamPara + grup[j];
                        kacGrup++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int y = 0; y < kacGrup; y++)
                {
                    for (int x = 0; x < N - 1; x++)
                    {
                        temp = grup[x];
                        grup[x] = grup[x + 1];
                        grup[x + 1] = temp;
                    }
                }
                Console.WriteLine("\n" + sira + ". siralama");
                for (int rrt = 0; rrt < N; rrt++)
                {
                    Console.Write("{0} ", grup[rrt]);
                }
                sira++;
                Console.WriteLine("\nBinen Sayisi: " + binenSayisi);
                Console.WriteLine("Kac Grup: " + kacGrup);
            }
            Console.WriteLine("Toplam kazanc: " + toplamPara);
            Console.ReadLine();
        }
    }
}
