using Divisore.Dominio;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Divisores.Dominio.Tests
{
    public class NumeroTest
    {
        [Fact(DisplayName = "Deve retornar divisores.")]
        public void DeveRetonarDivisores()
        {
            Numero numero = new(45);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new List<int> { 1, 3, 5, 9, 45 });
        }
    }
}
