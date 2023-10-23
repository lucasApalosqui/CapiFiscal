using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapiFiscal.Utilitarios
{
    public static class Cores
    {
        public static void LigarCorCupom()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DesligarCorCupom()
        {
            Console.ResetColor();
        }




    }
}
