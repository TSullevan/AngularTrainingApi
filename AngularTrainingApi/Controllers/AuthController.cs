using AngularTrainingApi.Models;
using AngularTrainingApi.Repositories;
using AngularTrainingApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularTrainingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public string Login([FromBody] LoginRequest request)
        {
            var user = UserAuthRepository.Get(request.Name, request.Password);
            if (user == null)
            {
                return null;
            }
            user.Password = "";
            string token = TokenService.GenerateToken(user);

            return token;
        }
    }
}
