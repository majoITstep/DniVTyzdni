using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class DniVTyzdni
    {
        public static void VypisDenTyzdna(string CisloDna)
        {
            int denTyzdna = int.Parse(CisloDna);
            if (SkontrolujVstup(denTyzdna))
            { 
                switch (denTyzdna)
                {
                    case 0:
                    case 7:
                        Console.WriteLine("Nedela");
                        break;
                    case 1:
                        Console.WriteLine("Pondelok");
                        break;

                    case 2:
                        Console.WriteLine("Utorok");
                        break;
                    case 3:
                        Console.WriteLine("Streda");
                        break;
                    case 4:
                        Console.WriteLine("Stvrtok");
                        break;
                    case 5:
                        Console.WriteLine("Piatok");
                        break;
                    case 6:
                        Console.WriteLine("Sobota");
                        break;

                    default:
                        Console.WriteLine("Nespravna hodnota");
                        break;

                }

        }
        else
        {
         Console.WriteLine("Chybny vstup");
        }
}
        public static void VypisDenTyzdna(string CisloDna, bool nedelaJePrva)
        {
            int denTyzdna = int.Parse(CisloDna);
            if (SkontrolujVstup(denTyzdna))
            {
                if (nedelaJePrva)
                {
                    denTyzdna--;
                }
                VypisDenTyzdna(denTyzdna.ToString());

            }
            else
            {
                Console.WriteLine("Chybny vstup");
            }

        }
        public static bool SkontrolujVstup(int cisloDna)
        {
            return (cisloDna >= 1 && cisloDna <= 7);            
            
        }
    }
}
