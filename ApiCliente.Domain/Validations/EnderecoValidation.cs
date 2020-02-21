using ApiCliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Domain.Validations
{
    public class EnderecoValidation
    {
        public bool ValidarLogradouro(string logradouro)
        {
            if (string.IsNullOrEmpty(logradouro) || logradouro.Length > 50)
                return true;
            else
                return false;
        }
        public bool ValidarEstado(string estado)
        {
            if (string.IsNullOrEmpty(estado) || estado.Length > 40)
                return true;
            else
                return false;
        }
        public bool ValidarBairro(string bairro)
        {
            if (string.IsNullOrEmpty(bairro) || bairro.Length > 40)
                return true;
            else
                return false;
        }
        public bool ValidarCidade(string cidade)
        {
            if (string.IsNullOrEmpty(cidade) || cidade.Length > 40)
                return true;
            else
                return false;
        }
    }
}
