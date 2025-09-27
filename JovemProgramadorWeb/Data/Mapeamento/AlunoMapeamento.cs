using JovemProgramadorWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JovemProgramadorWeb.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Codigo);

            builder.Property(t => t.Nome).HasColumnType("nvarchar");
            builder.Property(t => t.CPF).HasColumnType("nvarchar");
            builder.Property(t => t.Email).HasColumnType("nvarchar");
            builder.Property(t => t.Matricula).HasColumnType("nvarchar");
            builder.Property(t => t.DataNascimento).HasColumnType("date");

        }
    }
}
