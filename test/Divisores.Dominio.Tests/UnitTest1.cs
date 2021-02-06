using FluentAssertions;
using Xunit;

namespace Divisores.Dominio.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TesteInicial()
        {
            var verdade = true;

            verdade.Should().BeTrue();

        }
    }
}
