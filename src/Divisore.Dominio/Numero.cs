using System;
using System.Collections.Generic;

namespace Divisore.Dominio
{
    public class Numero
    {
        private readonly int _numero;

        public Numero(int numero)
        {
            _numero = numero;
        }

        public IList<int> Divisores()
        {
            List<int> lista = new();

            lista.Add(1);

            var metade = Math.Round((double)_numero / 2);

            for (int i = 2; i < metade; i++)
            {
                if (_numero % i == 0)
                    lista.Add(i);
            }

            lista.Add(_numero);

            return lista;
        }

    }
}
