using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapiFiscal.Mapeamento;
using CapiFiscal.Utilitarios;

namespace CapiFiscal
{
    public class CupomFiscal
    {
        private string _nomeLoja, _cnpj, _rua, _cidade, _estado;
        private int _numero;
        private List<Venda> _vendas = new List<Venda>();

        public CupomFiscal(string nomeLoja, string cnpj, string rua, int numero, string cidade, string estado)
        {
            _nomeLoja = nomeLoja;
            _cnpj = cnpj;
            _rua = rua;
            _numero = numero;
            _cidade = cidade;
            _estado = estado;
        }

        public void AdicionarCsv(string arquivo)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            try
            {
                using (var reader = new StreamReader("../../../../../ArquivosDiversos/" + arquivo))
                    try
                    {
                        using (var csv = new CsvReader(reader, config))
                        {
                            csv.Context.RegisterClassMap<VendaMap>();
                            var vendas = csv.GetRecords<Venda>();

                            foreach (var v in vendas)
                            {
                                _vendas.Add(v);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Arquivo com falha na escrita");
                    }
            }
            catch (Exception ex)
            {
                throw new Exception("Arquivo não existe ou Não encontrado");
            }

        }

        public void GerarCupom()
        {
            Cores.LigarCorCupom();
            LayoutCupom.Cabecalho(_nomeLoja, _cnpj, _rua, _numero, _cidade, _estado);
            LayoutCupom.MenuItens(_vendas);
            
            
            Cores.DesligarCorCupom();
        }


    }
}
