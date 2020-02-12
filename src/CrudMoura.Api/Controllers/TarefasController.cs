using AutoMapper;
using CrudMoura.Api.ViewModels;
using CrudMoura.Business.Interfaces;
using CrudMoura.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudMoura.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/tarefas")]
    public class TarefasController : MainController
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly ITarefaService _tarefaService;
        private readonly IMapper _mapper;
        
        public TarefasController(ITarefaRepository tarefaRepository,
                                 ITarefaService tarefaService,
                                 IMapper mapper,
                                 INotificador notificador) : base(notificador)
        {
            _tarefaRepository = tarefaRepository;
            _tarefaService = tarefaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TarefaViewModel>> ObterTodasTarefas()
        {
            return _mapper.Map<IEnumerable<TarefaViewModel>>(await _tarefaRepository.ObterTodos());
        }

        [HttpPost]
        public async Task<ActionResult<TarefaViewModel>> Adicionar([FromBody]TarefaViewModel tarefaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _tarefaService.Adicionar(_mapper.Map<Tarefa>(tarefaViewModel));

            return CustomResponse(tarefaViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Atualizar(Guid id, [FromBody]TarefaViewModel tarefaViewModel)
        {
            if (id != tarefaViewModel.Id)
            {
                NotificarErro("Os ids informados são diferentes!");
                return CustomResponse();
            }

            var tarefaParaAtualizar = await ObterTarefa(id);

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            tarefaParaAtualizar.Nome = tarefaViewModel.Nome;
            tarefaParaAtualizar.Realizada = tarefaViewModel.Realizada;

            await _tarefaService.Atualizar(_mapper.Map<Tarefa>(tarefaParaAtualizar));

            return CustomResponse(tarefaViewModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<TarefaViewModel>> Deletar(Guid id)
        {
            var tarefaViewModel = await ObterTarefa(id);

            if (tarefaViewModel == null) return NotFound();

            await _tarefaService.Remover(id);

            return CustomResponse(tarefaViewModel);
        }

        private async Task<TarefaViewModel> ObterTarefa(Guid id)
        {
            return _mapper.Map<TarefaViewModel>(await _tarefaRepository.ObterTarefa(id));
        }
    }
}