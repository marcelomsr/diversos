using HtmlAgilityPack;
using MyLibraryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosB3
{
    public abstract class Ativo
    {
        public struct Provento
        {
            public string tipoProvento;
            public DateTime dataCom;
            public DateTime dataPagamento;
            public double valorPago;
        }

        public string ticker { get; set; }
        public double valorAtual { get; set; }
        public double dividendYield { get; set; }
        public List<Provento> proventos { get; set; }

        protected HtmlDocument _htmlDocument;

        public Ativo(string ticker, Uri pathGetHtml)
        {
            this.ticker = ticker;
            this.proventos = new List<Provento>();

            string htmlTexto = "";
            SimpleFunctions.GetHtml(pathGetHtml.AbsoluteUri + ticker, ref htmlTexto);

            _htmlDocument = new HtmlDocument();
            _htmlDocument.LoadHtml(htmlTexto);

            inicializarAtivo();
        }

        protected void inicializarAtivo()
        {
            definirValorAtual();
            definirDividendYield();
            definirProventos();
        }

        private void definirValorAtual()
        {
            HtmlNode node = _htmlDocument.DocumentNode.SelectNodes("//div[@title='" + "Valor atual do ativo" + "']")[0];
            double outValorAtual;
            if (double.TryParse(node.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText, out outValorAtual))
                this.valorAtual = outValorAtual;
        }

        private void definirDividendYield()
        {
            HtmlNode node = _htmlDocument.DocumentNode.SelectNodes("//div[@title='" + "Dividend Yield com base nos últimos 12 meses" + "']")[0];
            double outDividendYield;
            if (double.TryParse(node.FirstChild.NextSibling.NextSibling.NextSibling.InnerText, out outDividendYield))
                this.dividendYield = outDividendYield;
        }

        private void definirProventos()
        {
            // Obtêm os dados dos proventos
            HtmlNode table = _htmlDocument.DocumentNode.SelectNodes("//*[@title='" + "Tipo do provento" + "']")[0];
            HtmlNodeCollection tbodyCollection = table.ParentNode.ParentNode.ParentNode.SelectNodes("//tbody/tr/td[@class='" + "uppercase" + "']");

            if (tbodyCollection == null)
                return;

            foreach (HtmlNode nodeItem in tbodyCollection)
            {
                Provento provento;
                provento.tipoProvento = nodeItem.InnerText;
                provento.dataCom = Convert.ToDateTime(nodeItem.NextSibling.NextSibling.InnerText);
                DateTime.TryParse(nodeItem.NextSibling.NextSibling.NextSibling.NextSibling.InnerText, out provento.dataPagamento);
                provento.valorPago = Convert.ToDouble(nodeItem.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText);

                proventos.Add(provento);
            }
        }
    }
}
