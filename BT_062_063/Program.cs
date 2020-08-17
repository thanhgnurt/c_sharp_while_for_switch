using System;

namespace BT_062_063
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BT 62 , 63");
            Console.WriteLine("Hay nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x");
            int x = int.Parse(Console.ReadLine());
            
            int UocChung = 1;
            int boiChung = 1;
            if (n<x)
            {
                UocChung = n / 2;
                boiChung = x;

            } else
            {
                UocChung = x / 2;
                boiChung = n;
            }
            // uoc chung lon nhat
            while (UocChung < 1)
            {
                if ( n% UocChung == 0 && x % UocChung == 0)
                {
                    break;
                }
                UocChung--;

            }

            Console.WriteLine("Uoc chung lon nhat cua n va x la:{0}", UocChung);


            //boi chung nho nhatt
            int i = 1;
            while (true)
            {
                if (boiChung % n == 0 && boiChung % x == 0)
                {
                    break;
                }
                else boiChung *= i;

                i++;

            }

            Console.WriteLine("Boi chung nho nhat cua n va x la:{0}", boiChung);



            


            


        }
    }
}
