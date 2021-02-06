using System;
using System.Collections.Generic;

namespace Divisore.Dominio
{
    public class Numero
    {
        private readonly int _numero;
        private HashSet<int> _listaDeDivisores;

        public Numero(int numero)
        {
            _numero = numero;
            _listaDeDivisores = new HashSet<int>();
        }


        public IEnumerable<int> Divisores()
        {
            ValidarSeZero();

            _listaDeDivisores.Add(1);

            var metade = ObterMetade();

            for (int i = 2; i < metade; i++)
                AdicionarDivisor(i);

            _listaDeDivisores.Add(_numero);

            return _listaDeDivisores;
        }

        private void ValidarSeZero()
        {
            if (_numero == 0)
                throw new ArgumentException("O Número zero não possui divizores.");
        }

        private void AdicionarDivisor(int numero)
        {
            if (EhDivisor(numero))
                _listaDeDivisores.Add(numero);
        }

        private bool EhDivisor(int numero)
            => _numero % numero == 0;

        private double ObterMetade()
            => Math.Round((double)_numero / 2);

    }
}
