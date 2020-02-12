using System;
using CrudMoura.Business.Interfaces;
using CrudMoura.Business.Models;
using CrudMoura.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudMoura.Data.Repository
{
    public class TarefaRepository : Repository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(MyDbContext db) : base(db) {}

        public async Task<IEnumerable<Tarefa>> ObterTarefas()
        {
            return await Db.Tarefas.AsNoTracking().ToListAsync();
        }

        public async Task<Tarefa> ObterTarefa(Guid id)
        {
            return await Db.Tarefas.AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
