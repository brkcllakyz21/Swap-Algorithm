using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elinizde bulunan bir dizide kullanıcının istediği 2 elemanın yerini değiştirebilecek algoritmayı tasarlayınız.

            int[] dizi = new int[10];
            int c = 3;
            int ilk = 0, son = 0, swap = 0;
            Console.Write("Dizi = ");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = c;
                Console.Write(dizi[i] + "-");
                c += 3;
            }

            Console.WriteLine();

            Console.Write("Yerlerinin değiştirilmesini istediğiniz sayılardan ilkinin indisini giriniz = ");
            ilk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yerlerinin değiştirilmesini istediğiniz sayılardan ikincisinin indisini giriniz = ");
            son = Convert.ToInt32(Console.ReadLine());
            swap = dizi[son];
            dizi[son] = dizi[ilk];
            dizi[ilk] = swap;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + "-");
            }

        }
    }
}
