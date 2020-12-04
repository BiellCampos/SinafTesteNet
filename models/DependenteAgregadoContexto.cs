using System;
using Microsoft.EntityFrameworkCore;

namespace SinafTeste.models
{
    public class DependenteAgregadoContexto : DbContext
    {
        public DependenteAgregadoContexto(DbContextOptions<DependenteAgregadoContexto> options) : base(options)
        {
        }
        public DbSet<SinafTeste.models.DependenteAgregado> DependenteAgregado { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SinafTeste.models.DependenteAgregado>().HasKey(m => m.IdDependenteAgregado);
            base.OnModelCreating(builder);
        }
    }
}
