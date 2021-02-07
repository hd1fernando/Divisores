using System.Collections.Generic;

namespace Divisores.Api.Controllers.DTOs
{
    public class DivisoresResultDTO
    {
        public string NumeroDeEntrada { get; set; }
        public IEnumerable<string> NumerosDivisores { get; set; }
        public IEnumerable<string> DivisoresPrimos { get; set; }
    }
}
