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
        [Trait("Integração", nameof(DecomposicaoService))]
        [Fact(DisplayName = "Deve encontrar divisores de quarenta e cinco.")]
        public void DeveEncontrarDivisores()
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
            notificador.TemNotificacao().Should().BeFalse();
        }

        [Trait("Integração", nameof(DecomposicaoService))]
        [Fact(DisplayName = "Deve gerar notificação quando número for zero.")]
        public void DeveGerarNotificaoQuandoNumeroForZero()
        {
            // Arrange
            INotificador notificador = new Notificador();
            IDecomposicaoService service = new DecomposicaoService(notificador);
            Numero numero = 0;

            // Act
            var result = service.EncontarDivisores(numero);

            // Assert
            notificador.TemNotificacao().Should().BeTrue();
            notificador.ObterNotificacoes()
                .Should().ContainEquivalentOf(new Notificacao("Nao e possivel encontar divisores de zero."));
        }
    }
}
