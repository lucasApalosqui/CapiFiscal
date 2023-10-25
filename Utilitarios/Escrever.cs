using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapiFiscal.Utilitarios
{
    public static class Escrever
    {
        public static void Padrao(string texto)
        {
            int contagemCaracteres = texto.Length;
            int QntLinhas = 80;
            int padrao = QntLinhas - texto.Length;
            if (padrao < 0)
            {
                string texto1 = texto.Substring(QntLinhas);
                string texto2 = texto.Substring(0, QntLinhas);
                Console.WriteLine(texto2);
                
                padrao = QntLinhas - texto1.Length;
                Console.Write(texto1);
                for (int i = 0; i < padrao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            else
            {
                Console.Write(texto);
                for (int i = 0; i < padrao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }




        }
    }
}
