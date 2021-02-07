using Divisores.Dominio.Interfaces;
using System.Collections.Generic;

namespace Divisores.Dominio.Services
{
    public class DecomposicaoService : BaseService, IDecomposicaoService
    {
        private HashSet<Numero> _primos;

        public DecomposicaoService(INotificador notificador) : base(notificador)
        {
            _primos = new HashSet<Numero>();
        }

        public DivisoresResult EncontarDivisores(Numero numero)
        {
            var divisores = numero.Divisores();

            foreach (var divisor in divisores)
            {
                Numero num = divisor;
                AddPrimos(num);
            }

            return new DivisoresResult(numero, divisores, _primos);
        }

        private void AddPrimos(Numero numero)
        {
            if (numero.EhPrimo())
                _primos.Add(numero);
        }
    }
}
