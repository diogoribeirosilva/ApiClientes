using ApiCliente.Application.DTO.DTO;
using ApiCliente.Domain.Models;
using ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Infrastruture.CrossCutting.Adapter.Map
{
    public class ClienteMapper : IClienteMapper
    {
 
        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();


        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {
                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    DataNascimento = item.DataNascimento,
                    Email = item.Email
                };
                clienteDTOs.Add(clienteDTO);
            }

            return clienteDTOs;
        }
        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Cpf = clienteDTO.Cpf,
                DataNascimento = clienteDTO.DataNascimento,
                Email = clienteDTO.Email
            };

            return cliente;
        }

        public ClienteDTO MapperToDTO(Cliente Cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = Cliente.Id,
                Nome = Cliente.Nome,
                Cpf = Cliente.Cpf,
                DataNascimento = Cliente.DataNascimento,
                Email = Cliente.Email
            };

            return clienteDTO;
        }
    }
}
