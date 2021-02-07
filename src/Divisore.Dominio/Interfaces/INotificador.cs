using Divisore.Dominio.Notificacoes;
using System.Collections.Generic;

namespace Divisore.Dominio.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        IList<Notificacao> ObterNotificacoes();
        void Manipulador(Notificacao notificacao);
    }
}
