using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.DTOs.Validations
{
    public class ProdutoDTOValidator : AbstractValidator<ProdutoDTO>
    {
        public ProdutoDTOValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().NotNull().WithMessage("Descricao deve ser informado");
            RuleFor(x => x.Codigo).NotEmpty().NotNull().WithMessage("Codigo deve ser informado");
            RuleFor(x => x.Compra).NotNull().WithMessage("Compra deve ser informado");
        }
    }
}
