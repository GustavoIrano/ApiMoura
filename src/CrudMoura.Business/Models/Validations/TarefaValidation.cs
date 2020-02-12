using FluentValidation;

namespace CrudMoura.Business.Models.Validations
{
    public class TarefaValidation : AbstractValidator<Tarefa>
    {
        public TarefaValidation()
        {
            RuleFor(t => t.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} não pode ser vazio!")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} deve ter entre {MinLenght} e {MaxLenght} caracteres");
        }
    }
}
