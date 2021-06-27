using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosB3
{
    public class Fii : Ativo
    {
        public static Uri fonteURI = new Uri("https://statusinvest.com.br/fundos-imobiliarios/");

        public double valorPatrimonial { get; set; }
        public double pvp{ get; set; }

        public Fii(string ticker) : base(ticker, fonteURI)
        {
            inicializarFii();
        }

        private void inicializarFii()
        {
            definirValorPatrimonial();
            definirPVP();
        }

        private void definirValorPatrimonial()
        {
            HtmlNode node = _htmlDocument.DocumentNode.SelectNodes("//*[text()[contains(., '" + "Val. patrimonial p/cota" + "')]]")[0];
            this.valorPatrimonial = Convert.ToDouble(node.NextSibling.NextSibling.NextSibling.NextSibling.InnerText);
        }

        private void definirPVP()
        {
            HtmlNode node = _htmlDocument.DocumentNode.SelectNodes("//*[text()[contains(., '" + "P/VP" + "')]]")[0];
            this.pvp = Convert.ToDouble(node.NextSibling.NextSibling.InnerText);
        }
    }
}
