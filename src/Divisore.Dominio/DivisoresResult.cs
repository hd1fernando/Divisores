using System.Collections.Generic;

namespace Divisores.Dominio
{
    public class DivisoresResult
    {
        public long NumeroDeEntrada { get; }
        public IEnumerable<long> NumerosDivisores { get; }
        public IEnumerable<long> DivisoresPrimos { get; }

        public DivisoresResult(
            long numeroDeEntrada,
            IEnumerable<long> numerosDivisores,
            IEnumerable<long> divisoresPrimos)
        {
            NumeroDeEntrada = numeroDeEntrada;
            NumerosDivisores = numerosDivisores;
            DivisoresPrimos = divisoresPrimos;
        }
    }
}
