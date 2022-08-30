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
    public class PersonMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("tb_pessoa");
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id).HasColumnName("idpessoa").UseIdentityColumn();
            builder.Property(c => c.Nome).HasColumnName("nome");
            builder.Property(c => c.Celular).HasColumnName("celular");

            builder.HasMany(c => c.Compra).WithOne(p => p.Pessoa).HasForeignKey(c => c.PessoaId);



        }
    }
}
