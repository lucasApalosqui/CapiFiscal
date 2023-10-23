using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapiFiscal
{
    public class CupomFiscal
    {
        private string _nomeLoja, _cnpj, _rua, _cidade, _estado;
        private int _numero;

        public CupomFiscal(string nomeLoja, string cnpj, string rua, int numero, string cidade, string estado)
        {
            _nomeLoja = nomeLoja;
            _cnpj = cnpj;
            _rua = rua;
            _numero = numero;
            _cidade = cidade;
            _estado = estado;
        }

        public void GerarCupom()
        {
            LayoutCupom.Cabecalho(_nomeLoja, _cnpj, _rua, _numero, _cidade, _estado);
        }


    }
}
