using System;
using System.Globalization;

namespace Vetor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            Product[] produtos = new Product[entrada];

            for (int i = 0; i < entrada; i++)
            {
                string nome = Console.ReadLine();
                double preco = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                produtos[i] = new Product { Nome = nome, Price = preco };
    
            }

            double soma = 0;

            for (int y = 0; y < entrada; y++)
            {
                soma += produtos[y].Price;
            }

            double media = soma / entrada;

            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
