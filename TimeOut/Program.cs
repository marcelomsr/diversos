using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeOut
{
    static class Program
    {
        static void Main()
        {
            var tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            int timeOut = 1000; // 1000 ms

            var task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(970); // Costuma estourar.
                //Thread.Sleep(950); // Costuma dar tempo.
            }, token);

            if (!task.Wait(timeOut, token))
                Console.WriteLine(String.Format("Estourou o timeout"));
            else
                Console.WriteLine(String.Format("Deu tempo!"));

            while (true) ;
        }
    }
}
