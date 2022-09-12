using masroufiServer.apiModels;
using masroufiServer.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace masroufiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(SignInManager<ApplicationUser> signinManager,UserManager<ApplicationUser> userManager)

        {
            _signinManager = signinManager;
            _userManager = userManager;

        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<RegisterModel.Response>> Register(RegisterModel.Request requestModel)
        {
            var user = new ApplicationUser()
            {
                UserName = requestModel.username,
                genre = requestModel.genre,
               
            };
   
        
            var result = await _userManager.CreateAsync(user, requestModel.password);

            if (result.Succeeded)
            {
                var responseModel = new RegisterModel.Response()
                {
                    username = requestModel.username,
                    genre = requestModel.genre,
                    coins = user.coins,
                    

                };

                return Ok(responseModel);
            }
            else
            {
                var responseModel = new RegisterModel.Response()
                {
                    Errors = result.Errors
                };

                return responseModel;
            }
        }
    }
}
