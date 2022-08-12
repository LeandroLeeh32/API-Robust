using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.DTOs.Validations
{
    public class CompraDTOValidator: AbstractValidator<CompraDTO>
    {
        public CompraDTOValidator()
        {
            //RuleFor();

            RuleFor(x => x.Pessoa).NotNull().WithMessage("Erro ao relacionar dados da compra com usuario");
            RuleFor(x => x.Produto).NotNull().WithMessage("Erro ao relacionar dados do produto com a compra");
            
        }
    }
}
