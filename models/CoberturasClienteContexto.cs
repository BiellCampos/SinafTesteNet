using System;
using Microsoft.EntityFrameworkCore;

namespace SinafTeste.models
{
    public class CoberturasClienteContexto : DbContext
    {
        public CoberturasClienteContexto(DbContextOptions<CoberturasClienteContexto> options) : base(options)
        {
        }
        public DbSet<SinafTeste.models.CoberturasCliente> CoberturasCliente { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SinafTeste.models.CoberturasCliente>().HasKey(m => m.IdCoberturascliente);
            base.OnModelCreating(builder);
        }
    }
}
