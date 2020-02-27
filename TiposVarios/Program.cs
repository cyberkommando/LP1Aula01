using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 7;
            uint y = 7U;
            long z = 7L;
            ulong a = 7UL;
            int b = 0x10;
            uint c = 0x10U;
            int d = 0b10110110;
            char e = '\u0065';


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            
        }
    }
}
