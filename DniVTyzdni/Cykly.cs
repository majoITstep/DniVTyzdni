﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class Cykly
    {
        public static void CyklusWhile()
        {
            int i = 0;
            while (i < 4)
            {

                Console.WriteLine("Ahoj");
                i++;
            }

        }

        public static void CyklusDoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            while (i < 5);
        }

        public static void CyklusFor()
        {
            for (int i = 0, j = 10; i <= j; i++, j--)
            {

                Console.WriteLine("dvojice{0},{1}", i, j);
            }
        }

        public static void CyklusFor2(int opakovanie)
        {


            for (int i = 0; i < opakovanie; i++)
            {
                Console.WriteLine(i);
            }


        }
        public static void CyklusForContinue()

        {
            for (int i = 0; i <= 10; i++)
            {

                int zbyt = i % 2;

                if (zbyt != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }

        public static void HodnotVsReferencia()
        {
            int hodnota1 = 6;
            int hodnota2;
            hodnota2 = hodnota1;
            hodnota2++;
            Console.WriteLine(hodnota1);
            Console.WriteLine(hodnota2);

            Auto auto1 = new Auto();
            auto1.Farba = "cervena";
            Auto auto2 = auto1;
            auto2.Farba = "cierna";

            Console.WriteLine(auto1.Farba);
            Console.WriteLine(auto2.Farba);
        }

        public static void PrefarbiAuto(Auto auto)
        {
            auto.Farba = "biela";

        }

        public static void ZvysOJedna(ref int a)
        {
            a++;
        }
    }


}
