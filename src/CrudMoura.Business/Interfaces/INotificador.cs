using CrudMoura.Business.Notifications;
using System.Collections.Generic;

namespace CrudMoura.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
