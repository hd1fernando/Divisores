using Divisores.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Divisores.Api.Controllers
{
    public class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
            => _notificador.TemNotificacao() == false;

        protected ActionResult CustomResponse(object result)
           => OperacaoValida()
           ? Ok(result)
           : BadRequest(_notificador
               .ObterNotificacoes()
               .Select(n => n.Mensagem));
    }
}
