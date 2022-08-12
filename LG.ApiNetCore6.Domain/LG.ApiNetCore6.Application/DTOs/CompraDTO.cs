using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.DTOs
{
    public class CompraDTO
    {
        public int Id { get;  set; }
        public int ProdutoId { get;  set; }
        public int PessoaId { get;  set; }
        public DateTime Data { get;  set; }
        public ProdutoDTO Produto { get; set; }
        public PessoaDTO Pessoa { get; set; }
    }
}
