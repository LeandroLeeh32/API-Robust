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
    public class CompraMap : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("TB_COMPRA");
            builder.HasKey(x => x.Id);

            builder.Property(X => X.Id).HasColumnName("Idcompra").UseIdentityColumn();

            builder.Property(x => x.ProdutoId).HasColumnName("Idproduto");
            builder.Property(x => x.PessoaId).HasColumnName("Idpessoa");
            builder.Property(X => X.Data).HasColumnName("DATA");

            builder.HasOne(x => x.Pessoa).WithMany(x => x.Compra);
            builder.HasOne(x =>x.Produto).WithMany(x => x.Compra);

 


        }
    }
}
