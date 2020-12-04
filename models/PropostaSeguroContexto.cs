using System;
using Microsoft.EntityFrameworkCore;

namespace SinafTeste.models
{
    public class PropostaSeguroContexto : DbContext
    {
        public PropostaSeguroContexto(DbContextOptions<PropostaSeguroContexto> options) : base(options)
        {
        }
        public DbSet<SinafTeste.models.PropostaSeguro> PropostaSeguro { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SinafTeste.models.PropostaSeguro>().HasKey(m => m.IdPropostaSeguro);
            base.OnModelCreating(builder);
        }
    }
}
