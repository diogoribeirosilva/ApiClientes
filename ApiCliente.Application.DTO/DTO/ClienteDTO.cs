using ApiCliente.Domain.Models;
using ApiCliente.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Application.DTO.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
