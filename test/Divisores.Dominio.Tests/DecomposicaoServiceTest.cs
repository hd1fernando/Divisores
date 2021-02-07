using Divisores.Dominio.Interfaces;
using Divisores.Dominio.Notificacoes;
using Divisores.Dominio.Services;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Divisores.Dominio.Tests
{
    public class DecomposicaoServiceTest
    {
        [Fact(DisplayName = "Deve encontrar divisores de quarenta e cinco")]
        public void DeveEncontrarDivisoresDeQuarentaECinco()
        {
            // Arrange
            INotificador notificador = new Notificador();
            IDecomposicaoService service = new DecomposicaoService(notificador);
            Numero numero = 45;

            // Act
            var result = service.EncontarDivisores(numero);

            // Assert
            result.Should().BeEquivalentTo(
                new DivisoresResult(
                    numero,
                    new HashSet<Numero> { 1, 3, 5, 9, 15, 45 },
                    new HashSet<Numero> { 3, 5 })
            );

        }
    }
}
