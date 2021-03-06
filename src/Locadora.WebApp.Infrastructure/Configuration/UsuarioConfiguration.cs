using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Infrastructure.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(p => p.IdUsuario);

            builder
                .Property(p => p.DataCriacao)
                .IsRequired();

            builder
                .Property(p => p.Login)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(p => p.Senha)
               .HasMaxLength(50)
               .IsRequired();
        }
    }
}
