using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using TreinamentoWeb.DTO;

namespace TreinamentoWeb.Database
{
    public class Context : DbContext
    {
        public DbSet<PessoaDTO> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"), builder => builder.UseRowNumberForPaging());

            //dotnet ef migrations add InitialCreate
            //dotnet ef database update
        }
    }
}
