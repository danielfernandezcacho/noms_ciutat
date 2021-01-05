using System;
using System.Collections.Generic;
using System.Text;

namespace noms_ciutat
{
    class milestone3
    {
        public static void Milestone3()
        {
            int n, fibo, anterior1 = 0, anterior2 = 1, i = 0;

            Console.WriteLine("Digues la quantitat de nombres");
            n = Int32.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(anterior1); 
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine(anterior1); 
                    Console.WriteLine(anterior2);
                }
                else
                {
                    Console.WriteLine(anterior1);
                    i++;
                    Console.WriteLine(anterior2);
                    i++;
                    do
                    {

                        fibo = anterior2 + anterior1;
                        Console.WriteLine(fibo);
                        anterior1 = anterior2;
                        anterior2 = fibo;
                        i++;
                    } while (i < n);
                }
            }
        }
    }
}
