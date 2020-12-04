using System;
using Microsoft.EntityFrameworkCore;

namespace SinafTeste.models
{
    public class ClienteContexto : DbContext
    {
        public ClienteContexto(DbContextOptions<ClienteContexto> options) : base(options)
        {
        }
        public DbSet<SinafTeste.models.Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SinafTeste.models.Cliente>().HasKey(m => m.IdCliente);
            base.OnModelCreating(builder);
        }
    }
}
