using AutoMapper;
using Divisores.Api.Controllers.DTOs;
using Divisores.Dominio;

namespace Divisores.Api.Configuracoes
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<DivisoresResult, DivisoresResultDTO>();
        }
    }
}
