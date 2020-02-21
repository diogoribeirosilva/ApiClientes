using ApiCliente.Domain.Core.Interfaces.Repositories;
using ApiCliente.Domain.Models;
using ApiCliente.Infrastruture.Data;

namespace ApiCliente.Infrastructure.Repository.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly SqlContext _context;
        public EnderecoRepository(SqlContext Context) : base(Context)
        {
            _context = Context;
        }
    }
}
