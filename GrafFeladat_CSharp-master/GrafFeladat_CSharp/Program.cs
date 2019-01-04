﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            Console.WriteLine(graf); 
            graf.SzelessegiBejaras(4);
            Console.WriteLine();
            graf.MelysegiBejaras(4);
            Console.WriteLine("\n" + graf.Osszefuggo());
            Console.WriteLine("\n" + graf.Feszitofa());
            Console.ReadLine();
        }
    }
}
