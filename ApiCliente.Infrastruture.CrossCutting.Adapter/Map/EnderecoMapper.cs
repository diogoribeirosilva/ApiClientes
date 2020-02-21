using ApiCliente.Application.DTO.DTO;
using ApiCliente.Domain.Models;
using ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCliente.Infrastruture.CrossCutting.Adapter.Map
{
    public class EnderecoMapper : IEnderecoMapper
    {
        List<EnderecoDTO> enderecoDTOs = new List<EnderecoDTO>();
        public IEnumerable<EnderecoDTO> MapperListEnderecos(IEnumerable<Endereco> enderecos)
        {
            foreach (var endereco in enderecos)
            {

                EnderecoDTO enderecoDTO = new EnderecoDTO
                {
                    Id = endereco.Id,
                    ClienteId = endereco.ClienteId,
                    Logradouro = endereco.Logradouro,
                    Bairro = endereco.Bairro,
                    Cidade = endereco.Cidade,
                    Estado = endereco.Estado
                };

                enderecoDTOs.Add(enderecoDTO);
            }
            return enderecoDTOs;
        }

        public EnderecoDTO MapperToDTO(Endereco endereco)
        {
            EnderecoDTO enderecoDTO = new EnderecoDTO
            {
                Id = endereco.Id,
                ClienteId = endereco.ClienteId,
                Logradouro = endereco.Logradouro,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Estado = endereco.Estado,
            };
            return enderecoDTO;
        }

        public Endereco MapperToEntity(EnderecoDTO enderecoDTO)
        {
            Endereco endereco = new Endereco
            {
                Id = enderecoDTO.Id,
                ClienteId = enderecoDTO.ClienteId,
                Logradouro = enderecoDTO.Logradouro,
                Estado = enderecoDTO.Estado,
                Bairro = enderecoDTO.Bairro,
                Cidade = enderecoDTO.Cidade
            };

            return endereco;
        }
    }
}
