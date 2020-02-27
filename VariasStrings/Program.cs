using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "É uma string";
            string b = "outra string";
            string c = @"Isto é um codigo em verbatim";
            string d = @"""Esta é uma string entre tres aspas""";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
