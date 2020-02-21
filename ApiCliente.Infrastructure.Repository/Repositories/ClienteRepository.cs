using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Domain.Models;
using ApiCliente.Infrastruture.Data;

namespace ApiCliente.Infrastructure.Repository.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly SqlContext _context;
        public ClienteRepository(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
