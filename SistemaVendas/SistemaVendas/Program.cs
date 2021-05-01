using System;

namespace SistemaVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorMediaMensal = new VendasNegocio(new VendasRepositorio()).CalcularMediaMensal(04, 2021);
            
            Console.WriteLine($"Valor Médio de Vendas no Mês: {valorMediaMensal}");
        }
    }
}
