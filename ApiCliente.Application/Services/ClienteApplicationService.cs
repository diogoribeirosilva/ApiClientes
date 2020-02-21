using ApiCliente.Application.DTO.DTO;
using ApiCliente.Application.Interfaces;
using ApiCliente.Domain.Core.Interfaces.Services;
using ApiCliente.Domain.Validations;
using ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace ApiCliente.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteService _clienteService;
        private readonly IClienteMapper _clienteMapper;

        public ClienteApplicationService(IClienteService clienteService, IClienteMapper mapperCliente)
        {
            _clienteService = clienteService;
            _clienteMapper = mapperCliente;
        }
        public void Add(ClienteDTO obj)
        {
            ClienteValidation clienteValidation = new ClienteValidation();

            if (clienteValidation.ValidaNome(obj.Nome))
                throw new System.ArgumentException("Campo nome é obrigatório ou tem mais de 30 caracteres", "Erro cliente");
            if (clienteValidation.ValidaCpf(obj.Cpf))
                throw new System.ArgumentException("CPF Invalido", "Erro cliente");
            if (clienteValidation.ValidaDataNascimento(obj.DataNascimento))
                throw new System.ArgumentException("Campo data de nascimento é obrigatório", "Erro cliente");

            obj.Cpf = obj.Cpf.Replace(".", "").Replace("-", "");
            var objCliente = _clienteMapper.MapperToEntity(obj);
            _clienteService.Add(objCliente);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var objCliente = _clienteService.GetAll();

            var clientes = _clienteMapper.MapperListClientes(objCliente);
            foreach (var item in clientes)
            {
                item.Idade = Convert.ToInt32(DateTime.Now.Year - item.DataNascimento.Year);
            }
            return clientes;
        }

        public ClienteDTO GetById(int id)
        {
            var objCliente = _clienteService.GetById(id);
            ClienteDTO cliente = _clienteMapper.MapperToDTO(objCliente);
            cliente.Idade = Convert.ToInt32(DateTime.Now.Year - cliente.DataNascimento.Year);
            return cliente;
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = _clienteMapper.MapperToEntity(obj);
            _clienteService.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {

            ClienteValidation clienteValidation = new ClienteValidation();

            if (clienteValidation.ValidaNome(obj.Nome))
                throw new System.ArgumentException("Campo nome é obrigatório ou tem mais de 30 caracteres", "Erro cliente");
            if (clienteValidation.ValidaCpf(obj.Cpf))
                throw new System.ArgumentException("CPF Invalido", "Erro cliente");
            if (clienteValidation.ValidaDataNascimento(obj.DataNascimento))
                throw new System.ArgumentException("Campo data de nascimento é obrigatório", "Erro cliente");

            obj.Cpf = obj.Cpf.Replace(".", "").Replace("-", "");
            var objCliente = _clienteMapper.MapperToEntity(obj);
            _clienteService.Update(objCliente);
        }
    }
}
