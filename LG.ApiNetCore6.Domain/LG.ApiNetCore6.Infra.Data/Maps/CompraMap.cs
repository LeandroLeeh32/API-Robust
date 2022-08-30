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
            builder.ToTable("tb_compra");
            builder.HasKey(x => x.Id);

            builder.Property(X => X.Id).HasColumnName("idcompra").UseIdentityColumn();

            builder.Property(x => x.ProdutoId).HasColumnName("idproduto");
            builder.Property(x => x.PessoaId).HasColumnName("idpessoa");
            builder.Property(X => X.Data).HasColumnName("data");

            builder.HasOne(x => x.Pessoa).WithMany(x => x.Compra);
            builder.HasOne(x =>x.Produto).WithMany(x => x.Compra);

 


        }
    }
}
