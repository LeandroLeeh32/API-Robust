using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set;}
        public string Descricao { get; set;}
        public string Codigo { get; set;}
        public decimal Preco { get; set;}
        public ICollection<CompraDTO> Compra { get; set;}
    }
}
