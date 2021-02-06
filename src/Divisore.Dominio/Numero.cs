using System;
using System.Collections.Generic;

namespace Divisore.Dominio
{
    public class Numero
    {
        private readonly int _numero;
        HashSet<int> _listaDeDivisores;

        public Numero(int numero)
        {
            _numero = numero;
            _listaDeDivisores = new HashSet<int>();
        }

        public IEnumerable<int> Divisores()
        {
            _listaDeDivisores.Add(1);

            var metade = ObterMetade();

            for (int i = 2; i < metade; i++)
                AdicinarDivisor(i);

            _listaDeDivisores.Add(_numero);

            return _listaDeDivisores;
        }

        private void AdicinarDivisor(int numero)
        {
            if (EDivisor(numero))
                _listaDeDivisores.Add(numero);
        }

        private bool EDivisor(int numero)
            => _numero % numero == 0;

        private double ObterMetade()
            => Math.Round((double)_numero / 2);

    }
}
