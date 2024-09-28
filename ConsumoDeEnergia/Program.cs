using System;

namespace ConsumoDeEnergia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Salário mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            double custoQuilowatt = salarioMinimo * (1.0 / 5.0);

            Console.Write("Quantidade de quilowatts consumida: ");
            double quantidadeQuilowatts = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double custoEnergia = custoQuilowatt * quantidadeQuilowatts;
            double custoEnergiaDesconto = custoEnergia - (custoEnergia * (15.0 / 100.0));

            Console.WriteLine("Preço do quilowatt R$ " + custoQuilowatt.ToString("F2"));
            Console.WriteLine("Custo de energia R$: " + custoEnergia.ToString("F2"));
            Console.WriteLine("Custo de energia com desconto R$" + custoEnergiaDesconto.ToString("F2"));

        }
    }
}
