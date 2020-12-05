using Microsoft.EntityFrameworkCore;
using SinafTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinafTeste.Context
{
    public class SinafTestContext : DbContext
    {
        public SinafTestContext(DbContextOptions<SinafTestContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cobertura> Cobertura { get; set; }
        public DbSet<DependenteAgregado> DependenteAgregado { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<PropostaSeguro> PropostaSeguro { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().HasKey(m => m.IdCliente);
            builder.Entity<Cobertura>().HasKey(m => m.IdCobertura);
            builder.Entity<DependenteAgregado>().HasKey(m => m.Id);
            builder.Entity<Endereco>().HasKey(m => m.Id);
            builder.Entity<PropostaSeguro>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
