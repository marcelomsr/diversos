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
            HtmlNode node = obterNodeCollectionPrincipal("//*[text()[contains(., '" + "Val. patrimonial p/cota" + "')]]");

            if (node == null)
            {
                return;
            }

            this.valorPatrimonial = Convert.ToDouble(node.NextSibling.NextSibling.NextSibling.NextSibling.InnerText);
        }

        private void definirPVP()
        {
            HtmlNode node = obterNodeCollectionPrincipal("//*[text()[contains(., '" + "P/VP" + "')]]");

            if (node == null)
            {
                return;
            }

            this.pvp = Convert.ToDouble(node.NextSibling.NextSibling.InnerText);
        }
    }
}
