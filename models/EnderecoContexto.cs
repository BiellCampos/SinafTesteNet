using System;
using Microsoft.EntityFrameworkCore;

namespace SinafTeste.models
{
    public class EnderecoContexto : DbContext
    {
        public EnderecoContexto(DbContextOptions<EnderecoContexto> options) : base(options)
        {
        }
        public DbSet<SinafTeste.models.Endereco> Endereco { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SinafTeste.models.Endereco>().HasKey(m => m.IdEndereco);
            base.OnModelCreating(builder);
        }
    }
}
