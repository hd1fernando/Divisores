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
            throw new NotImplementedException();
        }
    }
}
