using MyLibrary;
using System;

namespace CapturaHtml
{
    public class Program
    {
        static void Main(string[] args)
        {
            string html = "";

            SimpleFunctions.GetHtml("http://www.lbv.org.br", ref html);
            SimpleFunctions.FileWriter(@"c:\teste.txt", false, "teste");

            Console.Read();
        }
    }
}
