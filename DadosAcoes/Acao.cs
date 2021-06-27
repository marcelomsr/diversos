using MyLibraryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosB3
{
    public class Acao : Ativo
    {
        private static Uri fonteURI = new Uri("https://statusinvest.com.br/acoes/");

        public Acao(string ticker) : base(ticker, fonteURI)
        {
        }
    }
}
