using System;
using Xunit;

namespace SistemaVendas.TestesUnitarios
{
    public class FreteNegocioTest
    {
        [Theory(DisplayName = "Deve calcular frete com distância até 5km com sucesso")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void DeveCalcularFretePara5KmComSucesso(int distanciaKm)
        {
            var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

            Assert.Equal(0.00m, valorFrete);
        }

        [Theory(DisplayName = "Deve calcular frete com distância maior que 5km e mnor que 15km com sucesso")]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void DeveCalcularFreteEntre5kmE15kmComSucesso(int distanciaKm)
        {
            var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

            Assert.Equal(10.00m, valorFrete);
        }

        [Theory(DisplayName = "Deve calcular frete com distância superior à 15km com sucesso")]
        [InlineData(16)]
        [InlineData(20)]
        [InlineData(50)]
        [InlineData(400)]
        public void DeveCalcularFreteSuperior15kmComSucesso(int distanciaKm)
        {
            var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

            Assert.Equal(30.00m, valorFrete);
        }
    }
}
