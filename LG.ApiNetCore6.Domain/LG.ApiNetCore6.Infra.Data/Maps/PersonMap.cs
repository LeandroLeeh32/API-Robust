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
            builder.ToTable("TB_PESSOA");
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id).HasColumnName("Idpessoa").UseIdentityColumn();
            builder.Property(x => x.Nome).HasColumnName("NOME").UseIdentityColumn();
            builder.Property(x => x.Celular).HasColumnName("CELULAR").UseIdentityColumn();

            builder.HasMany(c => c.Compra).WithOne(p => p.Pessoa).HasForeignKey(c => c.PessoaId);



        }
    }
}
