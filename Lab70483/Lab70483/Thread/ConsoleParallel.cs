using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lab70483
{
    /// <summary>
    /// Criacao de tasks paralelas.
    /// </summary>
    class ConsoleParallel
    {
        //static void Main()
        //{
        //    Parallel.For(0, 10, i => { Thread.Sleep(1000); });
            
        //    var numbers = Enumerable.Range(0, 10);
        //    Parallel.ForEach(numbers, i => { Thread.Sleep(1000); });

        //    ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) => {
        //        if (i == 500)
        //        {
        //            Console.WriteLine("Breaking loop"); loopState.Break();
        //        }
        //        return;
        //    });

        //    Console.Read();
        //}
    }
}
