using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(u => u.Id);
            //Builder utiliza o padrão Fluent
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
               .Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(255);

            builder
               .Property(p => p.Preco)
               .IsRequired();
        }
    }
}
