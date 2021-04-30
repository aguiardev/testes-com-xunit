using System;

namespace SistemaVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorMediaMensal = new VendasNegocio().CalcularMediaMensal(04, 2021);
            Console.WriteLine($"Valor Médio de Vendas no Mês: {valorMediaMensal}");
        }
    }
}
