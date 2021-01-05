using System;
using System.Collections.Generic;
using System.Text;

namespace noms_ciutat
{
    class milestone2
    {
        public static void notas_de_alumnes()
        {
            {
                int[,] array2d = new int[5, 3];
                int i, j;
                double mitja = 0.0;

                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("alumno nuevo " + (i + 1));
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("nota");
                        array2d[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Alumno " + (i + 1));
                    for (j = 0; j < 3; j++)
                    {
                        mitja += array2d[i, j];
                    }

                    mitja /= 3;
                    if (mitja >= 5)
                    {
                        Console.WriteLine("L'alumne {0} ha aprovat: {1}", (1 + i), mitja);
                    }
                    else
                    {
                        Console.WriteLine("L'alumne {0} ha suspes: {1}", i, mitja);
                    }
                }

            }
        }
    }
}
