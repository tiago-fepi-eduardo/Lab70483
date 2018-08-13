using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Metodos assincronos executam e caso nao recebam o retorno de imediato liberam a memoria e a aplicacao segue a exeucao da thread. Apos o retorno
/// a thread reativa e termina a execucao. Como assincronos pertencem a classe Thread, o framework utiliza de tasks para fazer estas acoes.
/// Desta forma deve-se sempre esperar um retornar com parametro TASK de metodos async.
/// </summary>
namespace Lab70483
{
    class ConsoleAsync
    {
        //static void Main()
        //{
        //    string result = DownloadContent().Result;
        //    Console.Write("Resultado: " + result);
        //    Console.Read();
        //}

        private static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
