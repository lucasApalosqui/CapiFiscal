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

        public string QntXValor(Venda venda)
        {
            return "";
        }
    }
}
