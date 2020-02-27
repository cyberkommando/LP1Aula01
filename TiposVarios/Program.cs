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
            double f = 3.14159;
            float g = 3.14159f;
            decimal h = 3.14159m;
            double i =1_712_432.23;
            bool j = false; 


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            
            
        }
    }
}
