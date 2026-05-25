using ClientesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClienteMap : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .HasColumnName("ID")
            .ValueGeneratedOnAdd();
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("NAME");

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("EMAIL");
        builder.Property(c => c.Telefone)
            .HasMaxLength(20)
            .HasColumnName("TELEFONE");

        builder.HasIndex(c => c.Email).IsUnique();

        builder.OwnsOne(c => c.Endereco, endereco =>
            {
                endereco.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("RUA");
                endereco.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NUMERO");
                endereco.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CIDADE");
                endereco.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ESTADO");
                endereco.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CEP");
            });

    }
}