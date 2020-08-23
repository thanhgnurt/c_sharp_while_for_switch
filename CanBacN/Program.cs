using System;
using System.Globalization;

namespace CanBacN
{
    class Program
    {
       double luyThuaN(int n, double i)
        {
            int j = 1;
            double result = 1;
            while (j <= n)
            {
                result *=(double) i;
                
                j++;
            }
            result =Math.Round(result, 15);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap can n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap x:");
            double x = double.Parse(Console.ReadLine());
            Program luyThua = new Program();
            
            double i = 1;
            double temp = 0, temp1 = 0, temp2 = 0;
            if (i <= x)
            {
                while (i <= x)
                {
                    temp = luyThua.luyThuaN(n, i);
                    if (temp >= x)
                    {
                        if (temp == x)
                        {
                            temp1 = i;
                            break;
                        }
                        break;
                    }

                    i++;


                }
            }

            if (i > x)
            {
                i /=(double) 10;
                while (true)
                {
                    temp =(double) luyThua.luyThuaN(n, i);
                    
                    if(temp <= x)
                    {
                        if(temp == x)
                        {
                            temp1 = i;
                            break;
                        }
                        temp = i;
                        break;
                    }
               
                    

                }
                double j = (double)i;
                while (temp >= x)
                {
                    j += (double)i;
                    temp = luyThua.luyThuaN(n, j);
                    
                    if (temp>=x)
                    {
                        if (temp == x)
                        {
                          
                            temp1 = j;
                            break;
                        }
                        temp
                            = j;
                        break;

                    }
                   
                }

            }
         

                if (temp != x)
                {
                    temp2 = i;
                    double khoang_chan = 1;
                    int k = 1;
                    while (k <= 15)
                    {
                        if (k % 2 != 0)
                        {
                            temp1 = temp2 - khoang_chan;
                            while (temp1 <= temp2)
                            {
                                temp = luyThua.luyThuaN(n, temp1);
                                if (temp >= x)
                                {
                                    if(temp == x)
                                {
                                    temp1 = x;
                                    break;
                                }

                                    break;
                                }
                                temp1 += (double)khoang_chan / 10;

                            }
                            khoang_chan /= (double)10;

                            if (temp1 == x)
                            {
                                break;
                            }

                        }
                        else
                        {
                            temp2 = temp1 - khoang_chan;
                            while (temp2 <= temp1)
                            {
                                temp = luyThua.luyThuaN(n, temp2);
                                if (temp >= x)
                                {
                                if(temp == x)
                                {
                                    temp1 = x;
                                    break;
                                }
                                    break;
                                }
                                temp2 += (double)khoang_chan / 10;

                            }
                            khoang_chan /= (double)10;
                            if (temp2 == x)
                            {
                                temp1 = temp2;
                                break;
                            }
                        }


                        k++;
                    }
                }






            Console.WriteLine(temp1);

        }
    }
}
