using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRobotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Console.CursorLeft);
            Console.Write("Hola");
            Console.Write(Console.CursorLeft);
            Console.CursorLeft = 0;
            Console.Write("*");
            Console.ReadKey();
        }
    }
}
