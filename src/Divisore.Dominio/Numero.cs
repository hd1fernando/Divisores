using System;
using System.Collections.Generic;

namespace Divisores.Dominio
{
    public struct Numero
    {
        private readonly long _numero;

        public Numero(long numero)
        {
            _numero = numero;
        }

        public override string ToString() => _numero.ToString();

        public static implicit operator Numero(long numero)
            => new Numero(numero);

        public IEnumerable<Numero> Divisores()
        {
            ValidarSeZero();

            HashSet<Numero> ListaDeDivisores = new();

            ListaDeDivisores.Add(1);

            var metade = ObterMetade();

            for (long i = 2; i < metade; i++)
                AdicionarDivisor(i, ListaDeDivisores);

            ListaDeDivisores.Add(_numero);

            return ListaDeDivisores;
        }

        private void ValidarSeZero()
        {
            if (_numero == 0)
                throw new ArgumentException("O Numero zero nao possui divizores.");
        }

        private void AdicionarDivisor(long numero, HashSet<Numero> listaDeDivisores)
        {
            if (EhDivisor(numero))
                listaDeDivisores.Add(numero);
        }

        private bool EhDivisor(long numero)
            => _numero % numero == 0;

        private double ObterMetade()
            => Math.Round((double)_numero / 2);

        public bool EhPrimo()
        {
            if (_numero <= 1) return false;
            if (EhPar() && _numero > 2) return false;

            var raiz = ObterRaizQuadrada();

            for (int i = 2; i <= raiz; i++)
            {
                if (EhDivisor(i))
                    return false;
            }

            return true;
        }

        public bool EhPar() => _numero % 2 == 0;

        public double ObterRaizQuadrada()
            => Math.Sqrt(_numero);
    }
}
