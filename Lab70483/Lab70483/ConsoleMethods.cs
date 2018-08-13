using System;
using System.Collections.Generic;
using System.Text;

namespace Lab70483
{
    //public class ConsoleMethods
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Valor: " + 5.);
    //        Console.Read();
    //    }
    //}

    public static class ExtensionsMethods
    {
        public static int AddFive(this int source) {
            return source + 5;
        }
    }
}
