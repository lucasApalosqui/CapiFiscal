using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapiFiscal.Mapeamento
{
    public class VendaMap : ClassMap<Venda>
    {
        public VendaMap()
        {
            Map(v => v.Item).Name("item");
            Map(v => v.Codigo).Name("codigo_produto");
            Map(v => v.Descricao).Name("descricao_produto");
            Map(v => v.Quantidade).Name("quantidade_produto");
            Map(v => v.ValorUnitario).Name("valor_produto");
            Map(v => v.ValorTotal).Name("valor_total_produto");
        }
    }
}
