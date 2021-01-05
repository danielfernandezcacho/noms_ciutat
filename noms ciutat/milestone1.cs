using System;
using System.Collections.Generic;
using System.Text;

namespace noms_ciutat
{
    class milestone1
    {
        public static void Milestone1()
        {
            String ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;

            Console.WriteLine("Digues el nom de la primer ciutat");
            ciutat1 = Console.ReadLine();
            Console.WriteLine("Digues el nom de la segona ciutat");
            ciutat2 = Console.ReadLine();
            Console.WriteLine("Digues el nom de la tercera ciutat");
            ciutat3 = Console.ReadLine();
            Console.WriteLine("Digues el nom de la quarta ciutat");
            ciutat4 = Console.ReadLine();
            Console.WriteLine("Digues el nom de la cinquena ciutat");
            ciutat5 = Console.ReadLine();
            Console.WriteLine("Digues el nom de la sisena ciutat");
            ciutat6 = Console.ReadLine();

            String[] ciutats = new string[6];
            int i;

            string[] arrayCiudades = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };

            Array.Sort(ciutats, 0, ciutats.Length);

            for (i = 0; i < ciutats.Length; i++)
            {
                Console.WriteLine(ciutats[i]);
            }
            string[] arrayCiudadesModificadas = new string[arrayCiudades.Length];
            for (i = 0; i < arrayCiudades.Length; i++)
            {
                arrayCiudadesModificadas[i] = arrayCiudades[i].Replace('a', '4');
                Console.WriteLine(arrayCiudadesModificadas[i]);
            }
            String[] ciudads = new string[6];
            int j, pos;

            for (i = 0; i < ciutats.Length; i++)
            {
                Console.WriteLine("Digues el nom de la primer ciutat");
                ciutats[i] = Console.ReadLine();
            }

            String[] ciudad1 = new string[ciutats[0].Length];
            String[] ciudad2 = new string[ciutats[1].Length];
            String[] ciudad3 = new string[ciutats[2].Length];
            String[] ciudad4 = new string[ciutats[3].Length];
            String[] ciudad5 = new string[ciutats[4].Length];
            String[] ciudad6 = new string[ciutats[5].Length];

            for (i = 0; i < ciutats.Length; i++)
            {
                for (j = 0; j < ciutats[i].Length; j++)
                {
                    String[] arrayAux;
                }
            }

            for (i = 0; i < ciutats.Length; i++)
            {
                Console.Write(ciutat1[i]);
            }
        }
    }
}
