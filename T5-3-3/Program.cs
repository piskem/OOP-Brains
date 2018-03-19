﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oblik oblik = new Oblik("Zeleni", "Trougao");
            // Cannot create an instance of the abstract class or interface 'Oblik'

            Oblik krug = new Krug("Crveni", 3);
            krug.StampajPodatke();

            Oblik kvadrat = new Kvadrat("Plavi", 4);
            kvadrat.StampajPodatke();

            Console.ReadKey();
        }
    }
}
