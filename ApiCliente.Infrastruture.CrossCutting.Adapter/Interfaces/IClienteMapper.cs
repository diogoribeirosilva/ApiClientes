using ApiCliente.Application.DTO.DTO;
using ApiCliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IClienteMapper
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion

    }
}
