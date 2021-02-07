using Divisore.Dominio.Interfaces;
using System.Collections.Generic;

namespace Divisore.Dominio.Notificacoes
{
    public class Notificador : INotificador
    {
        private IList<Notificacao> _notificacoes;
        public Notificador()
            => _notificacoes = new List<Notificacao>();

        public void Manipulador(Notificacao notificacao)
            => _notificacoes.Add(notificacao);

        public IList<Notificacao> ObterNotificacoes()
            => _notificacoes;
        public bool TemNotificacao()
            => _notificacoes.Any();
    }
}
