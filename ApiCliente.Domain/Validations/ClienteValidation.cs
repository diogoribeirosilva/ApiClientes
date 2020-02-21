using ApiCliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Domain.Validations
{
    public class ClienteValidation
    {
        public bool ValidaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome) || nome.Length > 30)
                return true;
            else
                return false;
        }
        public bool ValidaDataNascimento(DateTime dataNascimento)
        {
            if (dataNascimento == null)
                return true;
            else
                return false;
        }
        public bool ValidaCpf(string cpf)
        {
            CpfValidation cpfValidation = new CpfValidation();
            if (string.IsNullOrEmpty(cpf) || !cpfValidation.ValidaCpf(cpf))
                return true;
            else
                return false;
        }
    }
}
