using System;
using System.ComponentModel.DataAnnotations;

namespace CrudMoura.Api.ViewModels
{
    public class TarefaViewModel
    {
        [Key] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo {0} não pode ter mais de 100 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public bool Realizada { get; set; }
    }
}
