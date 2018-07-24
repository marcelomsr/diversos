using MyLibrary;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TimeOut
{
    static class Program
    {        
        static void Main()
        {
            /*
            if ( SimpleFunctions.TimeOut(() =>
                    {
                        Thread.Sleep(980); // Costuma estourar.
                        //Thread.Sleep(950); // Costuma dar tempo.
                    }, 1000) )
                Console.WriteLine(String.Format("Estourou o timeout"));
            else
                Console.WriteLine(String.Format("Deu tempo!"));
            */

            if (SimpleFunctions.TimeOut(teste, 1000))
                Console.WriteLine(String.Format("Estourou o timeout"));
            else
                Console.WriteLine(String.Format("Deu tempo!"));

            while (true) ;
        }

        public static void teste()
        {
            Thread.Sleep(980); // Costuma estourar.
            //Thread.Sleep(950); // Costuma dar tempo.
        }
    }
}
