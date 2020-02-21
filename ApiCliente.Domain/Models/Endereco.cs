using System.ComponentModel.DataAnnotations;

namespace ApiCliente.Domain.Models
{
    public class Endereco : Base
    {
        [Required(ErrorMessage = "Campo logradouro é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo logradouro deve conter no máximo 50 caracteres")]
        public string Logradouro { get; set; }
        [StringLength(40, ErrorMessage = "O Campo bairro deve conter no máximo 40 caracteres")]
        public string Bairro { get; set; }
        [StringLength(40, ErrorMessage = "O Campo cidade deve conter no máximo 40 caracteres")]
        public string Cidade { get; set; }
        [StringLength(40, ErrorMessage = "O Campo estado deve conter no máximo 40 caracteres")]
        public string Estado { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
