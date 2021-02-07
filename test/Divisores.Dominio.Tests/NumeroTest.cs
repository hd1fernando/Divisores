using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Divisores.Dominio.Tests
{
    public class NumeroTest
    {
        [Fact(DisplayName = "Deve retornar divisores de 45.")]
        public void DeveRetonarDivisoresDeQuarentaECinco()
        {
            Numero numero = new(45);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { 1, 3, 5, 9, 15, 45 });
        }

        [Fact(DisplayName = "Deve retornar divisores de dois.")]
        public void DeveRetonarDivisoresDeDois()
        {
            Numero numero = new(2);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { 1, 2 });
        }

        [Fact(DisplayName = "Deve retornar divisores de um.")]
        public void DeveRetonarDivisoresUm()
        {
            Numero numero = new(1);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<Numero> { 1 });
        }

        [Fact(DisplayName = "Deve levantar exce��o quando numero for zero.")]
        public void DeveLancarExcecaoQuandoNumeroForZero()
        {
            Numero numero = new(0);

            Action acao = () => { numero.Divisores(); };

            acao.Should().ThrowExactly<ArgumentException>().WithMessage("O Numero zero nao possui divizores.");
        }

        [Theory(DisplayName = "Deve Considerar numero primo.")]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(37)]
        [InlineData(97)]
        [InlineData(6_700_417)]
        [InlineData(2_147_483_647)]
        [InlineData(67_280_421_310_721)]
        public void DeveConsiderarNumeroPrimo(long num)
        {
            Numero numero = num;

            var divisores = numero.EhPrimo();

            divisores.Should().BeTrue();
        }

        [Theory(DisplayName = "N�o Deve Considerar numero primo.")]
        [InlineData(1)]
        [InlineData(99)]
        [InlineData(10)]
        [InlineData(123456789)]
        public void NaoDeveConsiderarNumeroPrimo(long num)
        {
            Numero numero = num;

            var divisores = numero.EhPrimo();

            divisores.Should().BeFalse();
        }

    }
}