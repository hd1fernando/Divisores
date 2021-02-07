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
            if (EhZero(numero))
            {
                Notificar("Nao e possivel encontar divisores de zero.");
                return null;
            }

            var divisores = numero.Divisores();

            foreach (var divisor in divisores)
                AddPrimos(divisor);

            return new DivisoresResult(numero, divisores, _primos);
        }

        private bool EhZero(Numero numero)
            => numero.Equals(new Numero(0));

        private void AddPrimos(Numero numero)
        {
            if (numero.EhPrimo())
                _primos.Add(numero);
        }
    }
}
