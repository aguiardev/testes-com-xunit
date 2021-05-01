using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace SistemaVendas.TestesUnitarios
{
    public class VendasNegocioTest
    {
        VendasNegocio _vendasNegocio;
        Mock<IVendasRepositorio> _vendasRepositorioMock;

        public VendasNegocioTest()
        {
            var retorno = new List<Vendas>
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

            _vendasRepositorioMock = new Mock<IVendasRepositorio>();
            _vendasRepositorioMock.Setup(x => x.BuscarVendas(It.IsAny<short>(), It.IsAny<short>()))
                .Returns(retorno);
            
            _vendasNegocio = new VendasNegocio(_vendasRepositorioMock.Object);
        }

        [Fact(DisplayName = "Deve calcular media mensal com sucesso")]
        public void DeveCalcularMediaMensalComSucesso()
        {
            var valorMensal = _vendasNegocio.CalcularMediaMensal(4, 2021);

            Assert.Equal(301.03m, valorMensal);
        }
    }
}
