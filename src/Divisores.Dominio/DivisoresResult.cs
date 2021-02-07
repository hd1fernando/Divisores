using System.Collections.Generic;

namespace Divisores.Dominio
{
    public class DivisoresResult
    {
        public Numero NumeroDeEntrada { get; }
        public IEnumerable<Numero> NumerosDivisores { get; }
        public IEnumerable<Numero> DivisoresPrimos { get; }

        public DivisoresResult(
            Numero numeroDeEntrada,
            IEnumerable<Numero> numerosDivisores,
            IEnumerable<Numero> divisoresPrimos)
        {
            NumeroDeEntrada = numeroDeEntrada;
            NumerosDivisores = numerosDivisores;
            DivisoresPrimos = divisoresPrimos;
        }
    }
}
