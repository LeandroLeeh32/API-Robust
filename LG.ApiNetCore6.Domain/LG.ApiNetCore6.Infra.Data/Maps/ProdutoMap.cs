using LG.ApiNetCore6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Infra.Data.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("TB_PRODUTO");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("IDPRODUTO").UseIdentityColumn();

            builder.Property(x => x.Descricao).HasColumnName("DESCRICAO");
            builder.Property(x => x.Codigo).HasColumnName("CODIGO");
            builder.Property(x => x.Preco).HasColumnName("PRECO");

            builder.HasMany(x=>x.Compra).WithOne(p=>p.Produto).HasForeignKey(x=>x.ProdutoId);

         
        }
    }
}
