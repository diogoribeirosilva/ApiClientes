using ApiCliente.Application.DTO.DTO;
using ApiCliente.Application.Interfaces;
using ApiCliente.Application.Services;
using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Domain.Models;
using ApiCliente.Infrastructure.Repository.Repositories;
using AutoMapper;

namespace ApiClientes.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();

        }
    }
}
