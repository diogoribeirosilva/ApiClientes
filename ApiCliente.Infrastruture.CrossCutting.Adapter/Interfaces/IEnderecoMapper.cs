using ApiCliente.Application.DTO.DTO;
using ApiCliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IEnderecoMapper
    {
        #region Interfaces Mappers
        Endereco MapperToEntity(EnderecoDTO enderecoDTO);

        IEnumerable<EnderecoDTO> MapperListEnderecos(IEnumerable<Endereco> enderecos);

        EnderecoDTO MapperToDTO(Endereco endereco);

        #endregion
    }
}
