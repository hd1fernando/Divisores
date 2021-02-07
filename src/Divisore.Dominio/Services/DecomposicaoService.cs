using Divisores.Dominio.Interfaces;
using System.Collections.Generic;

namespace Divisores.Dominio.Services
{
    public class DecomposicaoService : BaseService, IDecomposicaoService
    {
        private HashSet<long> _primos;

        public DecomposicaoService(INotificador notificador) : base(notificador)
        {
            _primos = new HashSet<long>();
        }

        public DivisoresResult EncontarDivisores(long num)
        {
            Numero numero = num;
            var divisores = numero.Divisores();

            foreach (var divisor in divisores)
            {
                AddPrimos(divisor);
            }

            return new DivisoresResult(num, divisores, _primos);
        }

        private void AddPrimos(long numero)
        {
            Numero num = numero;
            if (num.EhPrimo())
                _primos.Add(numero);
        }
    }
}
