using CapiFiscal.Utilitarios;

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
                }
            }
        }


    }
}
