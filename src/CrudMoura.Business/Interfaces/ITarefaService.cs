using CrudMoura.Business.Models;
using System;
using System.Threading.Tasks;

namespace CrudMoura.Business.Interfaces
{
    public interface ITarefaService : IDisposable
    {
        Task Adicionar(Tarefa tarefa);
        Task Atualizar(Tarefa tarefa);
        Task Remover(Guid id);
    }
}
