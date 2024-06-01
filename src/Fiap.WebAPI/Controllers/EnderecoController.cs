using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fiap.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoApplicationServiceGenerico _applicationService;

        public EnderecoController(IEnderecoApplicationServiceGenerico applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost("AdicionarEndereco")]
        public IActionResult AdicionarEndereco([FromBody] EnderecoViewModel EnderecoViewModel)
        {
            if (ModelState.IsValid)
                return Ok(_applicationService.AdicionarCadastro(EnderecoViewModel));

            return BadRequest("Erro ao cadastrar usuário");
        }
        [HttpPut("Atualizar")]
        public IActionResult Atualizar([FromBody] EnderecoViewModel EnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                var resultado = _applicationService.AtualizarCadastro(EnderecoViewModel);
                return Ok(resultado);
            }

            return BadRequest("Erro ao atualizar usuário");
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            var resultado = _applicationService.DeletarCadastro(id);

            if (resultado != null)
                return Ok(resultado);
            else
                return NotFound("Usuário não encontrado");
        }

        [HttpGet("Obter/{id}")]
        public IActionResult Obter(int id)
        {
            var resultado = _applicationService.ObterCadastro(id);

            if (resultado != null)
                return Ok(resultado);
            else
                return NotFound("Usuário não encontrado");
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var resultado = _applicationService.ObterCadastros();
            return Ok(resultado);
        }
    }
}
