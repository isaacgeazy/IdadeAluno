using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime aniversario = new DateTime(2003, 01, 10);
            DateTime anv = new DateTime(2021, 01, 10);
            Console.WriteLine($"Eu nasci numa {aniversario.ToLongDateString()}");
            Console.WriteLine($"Meu aniversário de 18 foi em um {anv.ToLongDateString()}");

        }
    }
}
