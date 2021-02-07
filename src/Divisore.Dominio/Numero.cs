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

            AdicionarDivisoresSeNumeroPositivo(ListaDeDivisores);
            AdicionarDivisoresSeNumeroNegativo(ListaDeDivisores);

            return ListaDeDivisores;
        }

        private void AdicionarDivisoresSeNumeroPositivo(HashSet<Numero> listaDeDivisores)
        {
            if (_numero > 0)
            {
                var metade = ObterMetade();
                listaDeDivisores.Add(1);
                for (long i = 1; i < metade; i++)
                    AdicionarDivisor(i, listaDeDivisores);
                listaDeDivisores.Add(_numero);
            }
        }

        private void AdicionarDivisoresSeNumeroNegativo(HashSet<Numero> listaDeDivisores)
        {
            if (_numero < 0)
            {
                var metade = ObterMetade();
                listaDeDivisores.Add(_numero);
                for (long i = (long)metade; i < 0; i++)
                    AdicionarDivisor(i, listaDeDivisores);
            }
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
            long numero = _numero;
            if (numero < 0) numero = numero * (-1);
            if (numero == 1 || numero == 0) return false;
            if (EhPar() && numero > 2) return false;

            var raiz = ObterRaizQuadrada();

            for (int i = 2; i <= raiz; i++)
            {
                if (EhDivisor(i))
                    return false;
            }

            return true;
        }

        public bool EhPar() => _numero % 2 == 0;

        private double ObterRaizQuadrada()
        {
            long numero = (_numero >= 0) ? _numero : _numero * -1;
            return Math.Sqrt(numero);
        }
    }
}
