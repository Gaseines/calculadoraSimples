using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            Console.WriteLine(n1 + n2);
        }
    }
}
