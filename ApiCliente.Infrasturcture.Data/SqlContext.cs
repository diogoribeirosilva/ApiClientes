using ApiCliente.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Infrastruture.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Endereco> Endereco { get; set; }
    }
}
