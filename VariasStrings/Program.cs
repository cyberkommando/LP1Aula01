using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;
            int x = 0;
            int y = 2;
            int z = 5;
            int t = 6;
            int s = 7;
            int v3 = 11;
            int v4 = 13;
            string a = "É uma string";
            string b = "outra string";
            string c = @"Isto é um codigo em verbatim";
            string d = @"""Esta é uma string entre tres aspas""";
            string e = "Esta" + "é" + "uma" + "história";
            string f = "Com" + x;
            string g = $"O valor de y e' {7}";
            string h = $"{y} é maior que {z}";
            string i = String.Format("Arg {0} e {1}", t, s);
            string j = String.Format("Arg {1} e {0}", v3, v4);
            Console.WriteLine("Como estás {0}", x);
            string  xx1 = $"xx = {xx:f2}";
            string xx2 = $"xx = {xx:p1}";
            string ii1 = $"ii = {ii:x}";
            string ii2 = $"ii = {ii:c}";

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
            Console.WriteLine(xx1);
            Console.WriteLine(xx2);
            Console.WriteLine(ii1);
            Console.WriteLine(ii2);


        }
    }
}
