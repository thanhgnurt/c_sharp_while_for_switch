using System;

namespace BT_064_065_066
{
    class Program
    {

        static void Main(string[] args)
        {
            pt_bac_4 pt = new pt_bac_4();
            Console.WriteLine("Hello World!");
            Console.WriteLine("hay nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("hay nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap c:");
            int c = int.Parse(Console.ReadLine());
            pt.ptbac2(a, b, c, false);
            pt.ptbac4(a, b, c, true);
            
            


        }
    }
}
