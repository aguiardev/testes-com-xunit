using System;
using System.Linq;

namespace SistemaVendas
{
    public class VendasNegocio
    {
        private IVendasRepositorio _vendasRepo;

        public VendasNegocio(IVendasRepositorio vendasRepo)
        {
            _vendasRepo = vendasRepo;    
        }

        public decimal CalcularMediaMensal(short mes, short ano)
        {
            var vendas = _vendasRepo.BuscarVendas(mes, ano);

            var vendasMensal = vendas.Sum(s => s.Valor) / vendas.Count();

            return Math.Round(vendasMensal, 2);
        }
    }
}