using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapiFiscal.Utilitarios
{
    public class LogicaMenu
    {
        public string DescricaoProduto(Venda venda)
        {
            int linhaDescricao = 15;
            int padrao = 0;
            string descricaoFormatada;

            padrao = linhaDescricao - venda.Descricao.Length;
            if (padrao < 0)
            {
                descricaoFormatada = venda.Descricao.Substring(0, linhaDescricao);
            }
            else
            {
                var concatenado = new System.Text.StringBuilder();
                concatenado.Append(venda.Descricao);
                for (int i = 0; i < padrao; i++)
                {
                    concatenado.Append(" ");
                }
                descricaoFormatada = concatenado.ToString();

            }

            return descricaoFormatada;
        }

        public string ValorProduto(Venda venda)
        {
            int padrao = 6;
            string valorDepoisVirgula;
            string valorString = venda.ValorUnitario.ToString();
            if (valorString.Contains(","))
            {
                valorDepoisVirgula = valorString.Split(',')[1];
                if (valorDepoisVirgula.Length > 2)
                {
                    valorDepoisVirgula = valorDepoisVirgula.Substring(0, 2);
                    valorString = valorString.Split(',')[1] + "," + valorDepoisVirgula;
                }
                if (valorDepoisVirgula.Length == 1)
                {
                    valorDepoisVirgula = valorDepoisVirgula + "0";
                    valorString = valorString.Split(',')[0] + "," + valorDepoisVirgula;
                }

            }
            else
            {
                valorString = valorString + ",00";
            }

            var concatenado = new System.Text.StringBuilder();
            concatenado.Append(valorString);
            for (int i = 0; i < padrao - valorString.Length; i++)
            {
                concatenado.Append(" ");
            }
            valorString = concatenado.ToString();


            return valorString;
        }

       
    }
}
