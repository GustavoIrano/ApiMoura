using CrudMoura.Business.Interfaces;
using CrudMoura.Business.Models;
using System;
using System.Threading.Tasks;

namespace CrudMoura.Business.Services
{
    public class TarefaService : BaseService, ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository,
                             INotificador notificador) : base(notificador)
        {
            _tarefaRepository = tarefaRepository;
        }
        
        public async Task Adicionar(Tarefa tarefa)
        {
            await _tarefaRepository.Adicionar(tarefa);
        }

        public async Task Atualizar(Tarefa tarefa)
        {
            await _tarefaRepository.Atualizar(tarefa);
        }

        public async Task Remover(Guid id)
        {
            await _tarefaRepository.Remover(id);
        }

        public void Dispose()
        {
            _tarefaRepository?.Dispose();
        }
    }
}
