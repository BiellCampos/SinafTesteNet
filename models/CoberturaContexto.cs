using System;
using Microsoft.EntityFrameworkCore;

namespace SinafTeste.models
{
    public class CoberturaContexto : DbContext
    {
        public CoberturaContexto(DbContextOptions<CoberturaContexto> options) : base(options)
        {
        }
        public DbSet<SinafTeste.models.Cobertura> Coberturas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SinafTeste.models.Cobertura>().HasKey(m => m.IdCobertura);
            base.OnModelCreating(builder);
        }
    }
}
