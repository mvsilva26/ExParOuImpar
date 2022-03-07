using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("A soma é: {0}", soma);
            if(soma % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            Console.ReadLine();
        }
    }
}
