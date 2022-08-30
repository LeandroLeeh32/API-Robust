using LG.ApiNetCore6.Application.DTOs;
using LG.ApiNetCore6.Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LG.ApiNetCore6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PersonController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PessoaDTO pessoaDTO)
        {
            var result = await _pessoaService.CreateAsync(pessoaDTO);
            if (result.IsSucess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
