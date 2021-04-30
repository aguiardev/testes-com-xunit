using System;
using System.Collections.Generic;

namespace SistemaVendas
{
    public class VendasRepositorio
    {
        public IList<Vendas> BuscarVendas(short mes, short ano)
        {
            return new List<Vendas>
            {
                new Vendas
                {
                    Data = new DateTime(2021, 04, 02),
                    Valor = 500.00m
                },
                new Vendas
                {
                    Data = new DateTime(2021, 04, 05),
                    Valor = 50.00m
                },
                new Vendas
                {
                    Data = new DateTime(2021, 04, 10),
                    Valor = 353.10m
                }
            };
        }
    }
}