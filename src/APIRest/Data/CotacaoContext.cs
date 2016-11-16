using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIRest.Data
{
    public class CotacaoContext:DbContext
    {
        public DbSet<Cotacao> Cotacoes { get; set; }

        public CotacaoContext(DbContextOptions<CotacaoContext> options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cotacao>().HasKey(c=> c.Sigla);
        }
    }
}
