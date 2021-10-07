using Domain.Dtos;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;
        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginDto user)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (user == null) return BadRequest();

            try
            {
                var result = await loginService.FindByLogin(user);
                return result != null ? Ok(result) : NotFound();
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
