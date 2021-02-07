using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Divisores.Dominio.Tests
{
    public class NumeroTest
    {
        [Trait("Unidade", nameof(Numero))]
        [Fact(DisplayName = "Deve retornar divisores de 45.")]
        public void DeveRetonarDivisoresDeQuarentaECinco()
        {
            Numero numero = new(45);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { 1, 3, 5, 9, 15, 45 });
        }

        [Trait("Unidade", nameof(Numero))]
        [Fact(DisplayName = "Deve retornar divisores de -45.")]
        public void DeveRetonarDivisoresDeMenosQuarentaECinco()
        {
            Numero numero = new(-45);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { -45, -15, -9, -5, -3, -1 });
        }

        [Trait("Unidade", nameof(Numero))]
        [Fact(DisplayName = "Deve retornar divisores de dois.")]
        public void DeveRetonarDivisoresDeDois()
        {
            Numero numero = new(2);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { 1, 2 });
        }

        [Trait("Unidade", nameof(Numero))]
        [Fact(DisplayName = "Deve retornar divisores de um.")]
        public void DeveRetonarDivisoresUm()
        {
            Numero numero = new(1);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { 1 });
        }

        [Trait("Unidade", nameof(Numero))]
        [Fact(DisplayName = "Deve levantar exceção quando numero for zero.")]
        public void DeveLancarExcecaoQuandoNumeroForZero()
        {
            Numero numero = new(0);

            Action acao = () => { numero.Divisores(); };

            acao.Should().ThrowExactly<ArgumentException>().WithMessage("O Numero zero nao possui divizores.");
        }

        [Trait("Unidade", nameof(Numero))]
        [Theory(DisplayName = "Deve Considerar numero primo.")]
        [InlineData(2)]
        [InlineData(-2)]
        [InlineData(3)]
        [InlineData(37)]
        [InlineData(97)]
        [InlineData(-97)]
        [InlineData(6_700_417)]
        [InlineData(2_147_483_647)]
        [InlineData(67_280_421_310_721)]
        public void DeveConsiderarNumeroPrimo(long num)
        {
            Numero numero = num;

            var divisores = numero.EhPrimo();

            divisores.Should().BeTrue();
        }

        [Trait("Unidade", nameof(Numero))]
        [Theory(DisplayName = "Não Deve Considerar numero primo.")]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(99)]
        [InlineData(-99)]
        [InlineData(123456789)]
        public void NaoDeveConsiderarNumeroPrimo(long num)
        {
            Numero numero = num;

            var divisores = numero.EhPrimo();

            divisores.Should().BeFalse();
        }

    }
}
