using JovemProgramadorWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JovemProgramadorWeb.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(t => t.Codigo);

            builder.Property(t => t.Email).HasColumnType("nvarchar");
            builder.Property(t => t.Senha).HasColumnType("nvarchar");

        }
    }
}
