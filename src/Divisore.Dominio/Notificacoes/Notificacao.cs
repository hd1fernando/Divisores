using System.Linq;

namespace Divisore.Dominio.Notificacoes
{
    public class Notificacao
    {
        public string Mensagem { get; }

        public Notificacao(string mensagem)
            => Mensagem = mensagem;
    }
}
