using CapiFiscal.Utilitarios;
using Microsoft.VisualBasic;

namespace CapiFiscal
{
    public static class LayoutCupom
    {
        public static void Cabecalho(string nomeLoja, string cnpj, string rua, int numero, string cidade, string estado)
        {

            Escrever.Padrao(nomeLoja);
            Escrever.Padrao("CNPJ: " + cnpj);
            Escrever.Padrao($"{rua}, {numero}, {cidade}, {estado}");
            QuebraLinha.Pontilhado();
            Escrever.Padrao("CapiFiscal-e-documento Auxiliar da nota fiscal eletronica para Consumidor Final - Via Estabelecimento");
            Escrever.Padrao("");
            Escrever.Padrao("CapiFiscal não permite aproveitamento de crédito de ICMS Capifiscal Emitida em ambiente de teste - SEM VALOR FISCAL");
            QuebraLinha.Pontilhado();

        }

        public static void MenuItens(List<Venda> vendas)
        {
            int quantidadeTotal = 0;
            double valorTotalItens = 0;
            Escrever.Padrao("Item     Código     Descricao          Qnt X Valor     Val.Total");
            QuebraLinha.Pontilhado();
            if (vendas.Count == 0)
            {

                Escrever.Padrao("Arquivo Vazio ou Não encontrado");
            }
            else
            {


                foreach (var v in vendas)
                {
                    LogicaMenu descricao = new LogicaMenu();
                    LogicaMenu valorUni = new LogicaMenu();
                    LogicaMenu quantidade = new LogicaMenu();
                    LogicaMenu valorTotal = new LogicaMenu();

                    Escrever.Padrao($"  {v.Item}      {v.Codigo}  {descricao.DescricaoProduto(v)}       {quantidade.QuantidadeProduto(v)} X {valorUni.ValorProduto(v)}     {"R$ " + valorTotal.ValorTotalProduto(v)}");
                    quantidadeTotal = quantidadeTotal + v.Quantidade;
                    valorTotalItens = valorTotalItens + v.ValorTotal;
                }

            }
            QuebraLinha.Pontilhado();
        }


        public static void ValoresTotais(List<Venda> vendas)
        {
            int quantidadeItensTotal = 0;
            double valorItensTotal = 0;
            foreach (var v in vendas)
            {
                quantidadeItensTotal += v.Quantidade;
                valorItensTotal += v.ValorTotal;
            }
            Escrever.Padrao(Escrever.FormataDistancia("Qtd total de itens", quantidadeItensTotal.ToString()));
            Escrever.Padrao(Escrever.FormataDistancia("VALOR TOTAL", "R$ " + valorItensTotal.ToString()));
            Escrever.Padrao(Escrever.FormataDistancia("FORMA PAGAMENTO", "CARTÃO"));
            QuebraLinha.Pontilhado();
            Escrever.Padrao(Escrever.FormataDistancia("Tributos Totais Incidentes (Lei Fed. 12.741/2012)", "0,01"));
            QuebraLinha.Pontilhado();
        }

        public static void Rodape()
        {
            Escrever.Padrao(Escrever.FormataDistancia("N° 00000000135", "Serie 2", DateAndTime.Now.ToString()));
            
        }
    }
}
