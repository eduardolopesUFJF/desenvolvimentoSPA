using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoWeb.DTO;

namespace TreinamentoWeb.Database
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaDTO>
    {
        public void Configure(EntityTypeBuilder<PessoaDTO> builder)
        {
            builder.ToTable("TBLPESSOA");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Nome)
                .HasColumnName("Nome");

            builder.Property(e => e.Link)
                .HasColumnName("Link");
        }
    }
}
