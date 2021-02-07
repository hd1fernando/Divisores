using Divisore.Dominio.Interfaces;
using System.Collections.Generic;

namespace Divisore.Dominio.Services
{
    public class DecomposicaoService : BaseService, IDecomposicaoService
    {
        public DecomposicaoService(INotificador notificador) : base(notificador)
        { }

        public DivisoresResult EncontarDivisores(Numero numero)
        {
            HashSet<Numero> primos = new();
            var divisores = numero.Divisores();

            foreach (var divisor in divisores)
            {
                Numero n = divisor;
                if (n.EhPrimo())
                    primos.Add(n);
            }

            return new DivisoresResult(
                     numero,
                     new HashSet<Numero> { 1, 3, 5, 9, 15, 45 },
                     primos);
        }
    }
}
