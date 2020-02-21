using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Domain.Core.Interfaces.Services;
using ApiCliente.Domain.Models;

namespace ApiCliente.Domain.Services.Services
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        public readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
            : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
    }
}
