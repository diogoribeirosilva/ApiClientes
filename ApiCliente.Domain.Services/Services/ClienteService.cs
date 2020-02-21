using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Domain.Core.Interfaces.Services;
using ApiCliente.Domain.Models;

namespace ApiCliente.Domain.Services.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
             : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
