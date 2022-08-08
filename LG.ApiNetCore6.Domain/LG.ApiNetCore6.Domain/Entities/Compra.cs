using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Entities
{
    public sealed class Compra
    {
        public int Id { get; private set; }
        public int ProdutoId { get; private set; }
        public int PessoaId { get; private set; }
        public DateTime Data { get; private set; }
        public Produto Produto { get; set; }
        public Pessoa Pessoa { get; set; }

        public Compra(int produtiId, int pessoaId,DateTime data)
        {
            Validacao(produtiId, pessoaId, data);
        }

        private void Validacao(int produtoId, int pessoaId, DateTime? data)
        {
            Domain.Validations.DomainValidationException.When((produtoId < 0 ), "Id produto deve ser informado");
            ProdutoId = produtoId;

            Domain.Validations.DomainValidationException.When((pessoaId < 0), "Id pessoa deve ser informado");
            PessoaId = pessoaId;

            Domain.Validations.DomainValidationException.When((!data.HasValue), "Data da compra deve ser informado");
            Data = data.Value;





        }
    }


}
