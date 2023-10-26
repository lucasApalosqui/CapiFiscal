using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapiFiscal.Utilitarios
{
    public static class Credencial
    {
        public static string GerarChaveAcesso()
        {
            var chaveAcesso = new System.Text.StringBuilder();
            Random rdn = new Random();
            for (int i = 0; i < 10; i++)
            {
                chaveAcesso.Append(rdn.Next(100, 999));
                if (i != 9)
                {
                    chaveAcesso.Append(" ");
                }
            }
            return chaveAcesso.ToString();
        }
    }
}
