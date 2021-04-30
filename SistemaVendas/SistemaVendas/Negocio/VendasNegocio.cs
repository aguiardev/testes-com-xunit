using System;
using System.Linq;

namespace SistemaVendas
{
    public class VendasNegocio
    {
        public decimal CalcularMediaMensal(short mes, short ano)
        {
            var vendas = new VendasRepositorio().BuscarVendas(mes, ano);

            var vendasMensal = vendas.Sum(s => s.Valor) / vendas.Count();

            return Math.Round(vendasMensal, 2);
        }
    }
}