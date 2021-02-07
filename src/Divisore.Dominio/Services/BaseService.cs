using Divisores.Dominio.Interfaces;
using Divisores.Dominio.Notificacoes;

namespace Divisores.Dominio.Services
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
