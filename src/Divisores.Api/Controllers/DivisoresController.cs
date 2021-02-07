using AutoMapper;
using Divisores.Api.Controllers.DTOs;
using Divisores.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Divisores.Api.Controllers
{
    [Route("api/[controller]")]
    public class DivisoresController : MainController
    {
        IDecomposicaoService _decomposicaoService;
        IMapper _mapper;
        public DivisoresController(
            IDecomposicaoService decomposicaoService,
            IMapper mapper,
            INotificador notificador) : base(notificador)
        {
            _decomposicaoService = decomposicaoService;
            _mapper = mapper;
        }

        [HttpGet("{numero:long}")]
        public ActionResult<DivisoresResultDTO> Divisores(long numero)
        {
            var divisores = _decomposicaoService.EncontarDivisores(numero);

            return _mapper.Map<DivisoresResultDTO>(divisores);
        }
    }
}
