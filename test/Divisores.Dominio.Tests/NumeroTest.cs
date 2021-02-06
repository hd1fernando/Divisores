using Divisore.Dominio;
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

            divisores.Should().Equal(new HashSet<int> { 1, 3, 5, 9, 15, 45 });
        }

        [Fact(DisplayName = "Deve retornar divisores de dois.")]
        public void DeveRetonarDivisoresDeDois()
        {
            Numero numero = new(2);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<int> { 1, 2 });
        }

        [Fact(DisplayName = "Deve retornar divisores de um.")]
        public void DeveRetonarDivisoresUm()
        {
            Numero numero = new(1);

            var divisores = numero.Divisores();

            divisores.Should().Equal(new HashSet<int> { 1 });
        }

        [Fact(DisplayName = "Deve levantar exce��o quando numero for zero.")]
        public void DeveLancarExcecaoQuandoNumeroForZero()
        {
            Numero numero = new(0);

            Action acao = () => { numero.Divisores(); };

            acao.Should().ThrowExactly<ArgumentException>().WithMessage("O N�mero zero n�o possui divizores.");
        }
    }
}
