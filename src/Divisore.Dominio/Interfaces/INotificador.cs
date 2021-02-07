using Divisores.Dominio.Notificacoes;
using System.Collections.Generic;

namespace Divisores.Dominio.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        IList<Notificacao> ObterNotificacoes();
        void Manipular(Notificacao notificacao);
    }
}
