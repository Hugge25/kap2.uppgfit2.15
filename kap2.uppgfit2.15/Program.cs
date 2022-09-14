using System;

namespace kap2._uppgfit2._15
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv tre ord med punkt");
            var ord = Console.ReadLine().Split(' ');
            string a = ord[0];
            string b = ord[1];
            string c = ord[2];

            c = c.TrimEnd('.');


            Console.WriteLine(c + " " + b + " " + a + ".");
        }
    }
}