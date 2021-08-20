namespace calculadora
{
    internal class ProgramBase1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            string s1 = (Console.ReadLine());

            if (s1 == "+")
            {
                Console.WriteLine(n1 + n2);


            }
        }
    }
}