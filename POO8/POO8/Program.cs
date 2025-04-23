using System;

namespace POO8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Maior de 2 números==");

            Maior m;
            m = new Maior();

            Console.Write("Digite o primeiro número: ");
            m.setn1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o segundo número: ");
            m.setn2(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Maior: {0} ({1} número)", m.indicarMaior(), m.getns());
        }
    }
}
