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

        public DbSet<AndreAirlinesAPI.Model.Endereco> Endereco { get; set; }

        public DbSet<AndreAirlinesAPI.Model.Passageiro> Passageiro { get; set; }

        public DbSet<AndreAirlinesAPI.Model.Aeroporto> Aeroporto { get; set; }

        public DbSet<AndreAirlinesAPI.Model.Aeronave> Aeronave { get; set; }

        public DbSet<AndreAirlinesAPI.Model.Voo> Voo { get; set; }
    }
}
