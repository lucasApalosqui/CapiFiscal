
using CapiFiscal.Utilitarios;

namespace CapiFiscal
{
    public static class LayoutCupom
    {
        public static void Cabecalho(string nomeLoja, string cnpj, string rua, int numero, string cidade, string estado)
        {
            Cores.LigarCorCupom();
            Escrever.Padrao(nomeLoja);
            Escrever.Padrao("CNPJ: " + cnpj);
            Escrever.Padrao($"{rua}, {numero}, {cidade}, {estado}");
            QuebraLinha.Pontilhado();
            Cores.DesligarCorCupom();
        }
    }
}
