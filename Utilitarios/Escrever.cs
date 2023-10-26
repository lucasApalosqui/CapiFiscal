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

        public static string FormataDistancia(string texto1, string texto2)
        {
            int qntLinhas = 80;
            int espacoSobra = 0;
            int totalLenght = texto1.Length + texto2.Length;
            var textoFinal = new System.Text.StringBuilder();

            if (totalLenght < 80)
            {
                espacoSobra = 80 - totalLenght;
                textoFinal.Append(texto1);
                for (int i = 0; i < espacoSobra; i++)
                {
                    textoFinal.Append(" ");

                }
                textoFinal.Append(texto2);
            }
            else
            {
                textoFinal.Append(texto1);
                textoFinal.Append(texto2);
            }
            return textoFinal.ToString();
        }

        public static string FormataDistancia(string texto1, string texto2, string texto3)
        {
            int qntLinhas = 80;
            int espacoSobra = 0;
            int totalLenght = texto1.Length + texto2.Length + texto3.Length;
            var textoFinal = new System.Text.StringBuilder();

            if (totalLenght < 80)
            {
                espacoSobra = 80 - totalLenght;
                textoFinal.Append(texto1);
                for (int i = 0; i < espacoSobra / 2; i++)
                {
                    textoFinal.Append(" ");

                }
                textoFinal.Append(texto2);
                for (int i = 0; i < espacoSobra / 2; i++)
                {
                    textoFinal.Append(" ");

                }
                textoFinal.Append(texto3);
            }
            else
            {
                textoFinal.Append(texto1);
                textoFinal.Append(texto2);
                textoFinal.Append(texto3);
            }
            return textoFinal.ToString();

        }
    }
}
