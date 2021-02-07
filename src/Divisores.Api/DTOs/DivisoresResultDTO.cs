using Divisores.Dominio;
using System.Collections.Generic;

namespace Divisores.Api.Controllers.DTOs
{
    public class DivisoresResultDTO
    {
        public long NumeroDeEntrada { get; set; }
        public IEnumerable<long> NumerosDivisores { get; set; }
        public IEnumerable<long> DivisoresPrimos { get; set; }
    }
}
