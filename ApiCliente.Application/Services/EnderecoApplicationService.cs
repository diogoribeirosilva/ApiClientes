using ApiCliente.Application.DTO.DTO;
using ApiCliente.Application.Interfaces;
using ApiCliente.Domain.Core.Interfaces.Services;
using ApiCliente.Domain.Validations;
using ApiCliente.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace ApiCliente.Application.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoService _enderecoService;
        private readonly IEnderecoMapper _enderecoMapper;

        public EnderecoApplicationService(IEnderecoService enderecoService, IEnderecoMapper enderecoMapper)
        {
            _enderecoService = enderecoService;
            _enderecoMapper = enderecoMapper;
        }

        public void Add(EnderecoDTO obj)
        {
            EnderecoValidation enderecoValidation = new EnderecoValidation();

            if (enderecoValidation.ValidarLogradouro(obj.Logradouro))
                throw new System.ArgumentException("Campo logradouro é obrigatório ou tem mais de 50 caracteres", "Erro cliente");
            if (enderecoValidation.ValidarEstado(obj.Estado))
                throw new System.ArgumentException("O campo estado é obrigatório ou tem mais de 40 caracteres", "Erro cliente");
            if (enderecoValidation.ValidarCidade(obj.Cidade))
                throw new System.ArgumentException("O campo cidade é obrigatório ou tem mais de 40 caracteres", "Erro cliente");
            if (enderecoValidation.ValidarBairro(obj.Bairro))
                throw new System.ArgumentException("O campo bairro é obrigatório ou tem mais de 40 caracteres", "Erro cliente");

            var objEndereco = _enderecoMapper.MapperToEntity(obj);
            _enderecoService.Add(objEndereco);
        }

        public void Dispose()
        {
            _enderecoService.Dispose();
        }

        public IEnumerable<EnderecoDTO> GetAll()
        {
            var objEndereco = _enderecoService.GetAll();
            return _enderecoMapper.MapperListEnderecos(objEndereco);
        }

        public EnderecoDTO GetById(int id)
        {
            var objProduto = _enderecoService.GetById(id);
            return _enderecoMapper.MapperToDTO(objProduto);
        }

        public void Remove(EnderecoDTO obj)
        {
            var objEndereco = _enderecoMapper.MapperToEntity(obj);
            _enderecoService.Remove(objEndereco);
        }

        public void Update(EnderecoDTO obj)
        {
            EnderecoValidation enderecoValidation = new EnderecoValidation();

            if (enderecoValidation.ValidarLogradouro(obj.Logradouro))
                throw new System.ArgumentException("Campo logradouro é obrigatório ou tem mais de 50 caracteres", "Erro cliente");
            if (enderecoValidation.ValidarEstado(obj.Estado))
                throw new System.ArgumentException("O campo estado é obrigatório ou tem mais de 40 caracteres", "Erro cliente");
            if (enderecoValidation.ValidarCidade(obj.Cidade))
                throw new System.ArgumentException("O campo cidade é obrigatório ou tem mais de 40 caracteres", "Erro cliente");
            if (enderecoValidation.ValidarBairro(obj.Bairro))
                throw new System.ArgumentException("O campo bairro é obrigatório ou tem mais de 40 caracteres", "Erro cliente");

            var objEndereco = _enderecoMapper.MapperToEntity(obj);
            _enderecoService.Update(objEndereco);
        }
    }
}
