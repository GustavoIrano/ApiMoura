using AutoMapper;
using CrudMoura.Api.ViewModels;
using CrudMoura.Business.Models;

namespace CrudMoura.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Tarefa, TarefaViewModel>().ReverseMap();
        }
    }
}
