using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cykly.CyklusWhile();
            //Cykly.CyklusDoWhile();
            // Cykly.CyklusFor();
            // Cykly.CyklusForContinue();
            //Cykly.HodnotVsReferencia();
            //Auto autoPovodne = new Auto();
            // autoPovodne.Farba = "cierna";
            //Cykly.PrefarbiAuto(autoPovodne);
            //Console.WriteLine(autoPovodne.Farba);
            //int aPovodne = 10;
            //Cykly.ZvysOJedna(ref aPovodne);
            //Console.WriteLine(aPovodne);

            Pole p = new Pole();
            //p.VypisPole();
            p.NaplPole();
            Console.ReadLine();
        }
    }
}
