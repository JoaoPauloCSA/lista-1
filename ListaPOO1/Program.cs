using System;

namespace ListaPOO1
{
    class Program
    {
        static void Main(string[] args)
        {

            Area a;
            a = new Area();

            Console.WriteLine("==Calcular área do retângulo (base e altura)==");

            do
            {
                Console.Write("Digite a Base: ");
                a.setBasinha(double.Parse(Console.ReadLine()));
            }
            while (a.getBasinha() <= 0);

            do
            {
                Console.Write("Digite a Altura: ");
                a.setAltura(double.Parse(Console.ReadLine()));
            }
            while (a.getAltura() <= 0);

            a.calcular();

            Console.WriteLine();
            Console.WriteLine("Base = {0}; Altura = {1}", a.getBasinha(), a.getAltura());
            Console.Write("Área do retângulo = {0}", a.getResultado());
        }
    }
}
