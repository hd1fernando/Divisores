using Divisore.Dominio.Interfaces;
using Divisore.Dominio.Notificacoes;

namespace Divisore.Dominio.Services
{
    public class BaseService
    {
        private INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected virtual void Notificar(string mensagem)
            => _notificador.Manipular(new Notificacao(mensagem));
    }
}
