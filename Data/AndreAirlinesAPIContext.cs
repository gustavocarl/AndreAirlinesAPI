using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndreAirlinesAPI.Model;

namespace AndreAirlinesAPI.Data
{
    public class AndreAirlinesAPIContext : DbContext
    {
        public AndreAirlinesAPIContext (DbContextOptions<AndreAirlinesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Passageiro> Passageiro { get; set; }

        public DbSet<Aeroporto> Aeroporto { get; set; }

        public DbSet<Aeronave> Aeronave { get; set; }

        public DbSet<Voo> Voo { get; set; }

        public DbSet<Classe> Classe { get; set; }

        public DbSet<Passagem> Passagem { get; set; }

        public DbSet<PrecoBase> PrecoBase { get; set; }

    }
}
