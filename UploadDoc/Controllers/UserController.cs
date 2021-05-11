using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.ViewModels;
using UploadDoc.Auth;

namespace UploadDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize] // quando Anottation Authorize estiver aqui todos os métodos irão precisar da autenticação, ou poderia colocar em cada método
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
               
        [HttpPost("authenticate"), AllowAnonymous]
        public IActionResult Authenticate(UserAuthenticateRequestViewModel userViewModel)
        {
            return Ok(this.userService.Authenticate(userViewModel));
        }

        // Método que irá utilizar token que só o próprio usuário poderá deletar
        [HttpDelete]
        public IActionResult Delete()
        {
            string _userId = TokenService.GetValueFromClaim(HttpContext.User.Identity, ClaimTypes.NameIdentifier);
            return Ok(this.userService.Delete(_userId));
        }
    }
}