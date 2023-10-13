using System.Security.AccessControl;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("v1")]
    public class Users : ControllerBase
    {
        private readonly IUseCase _createUserUseCase;

        public Users(IUseCase createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        [HttpPost(Name = "Teste")]
        [Route("teste")]
        public IActionResult Post([FromBody] UserDTO user)
        {
            _createUserUseCase.Execute(user);

            return Ok("Usuário criado com sucesso!");
        }

    }
}
