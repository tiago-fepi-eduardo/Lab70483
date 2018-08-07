using System;
using System.Threading;

namespace Lab70483
{
    /// <summary>
    /// Criacao de thread com intervenca pelo teclado para pausar a execucao da primeira thread.
    /// Uma forma manual de criar um timer que espera a acao de um usuario para tomar decisoes sem basear em evento click.
    /// Importante: Uma thread recebe para si uma copia de todo contexto da aplicacao. Datas, idioma, seguranca do context. Essa funcionalidade
    /// pode ser dedabilitado suando 'supressFlow'.
    /// Para se trabalhar com muitas thread é recomendado o uso de ThreadPool. Menos oneroso.
    /// </summary>
    class ConsoleThread01
    {
        static bool stopped = false;
        
        //public static void Main(string[] args)
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.Start();

        //    Console.ReadKey();
        //    stopped = true;

        //    t.Join();

        //    Console.WriteLine("\nEnd together");
        //    Console.Read();
        //}

        public static void ThreadMethod()
        {
            while (!stopped)
            {
                Console.WriteLine("Second thread.");
                Thread.Sleep(5000);
            }
        }

    }
}
