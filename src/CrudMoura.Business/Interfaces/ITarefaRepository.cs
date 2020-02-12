using System;
using CrudMoura.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudMoura.Business.Interfaces
{
    public interface ITarefaRepository : IRepository<Tarefa>
    {
        Task<IEnumerable<Tarefa>> ObterTarefas();
        Task<Tarefa> ObterTarefa(Guid id);
    }
}
