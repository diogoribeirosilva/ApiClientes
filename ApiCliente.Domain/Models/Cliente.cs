using System;
using System.ComponentModel.DataAnnotations;

namespace ApiCliente.Domain.Models
{
    public class Cliente : Base
    {
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(30,ErrorMessage = "Campo nome deve conter no máximo 30 caracteres")]
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Data de Nascimento é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
