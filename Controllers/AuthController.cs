using masroufiServer.apiModels;
using masroufiServer.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace masroufiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(SignInManager<ApplicationUser> signinManager,UserManager<ApplicationUser> userManager
            ,RoleManager<IdentityRole> roleManager)

        {
            _signinManager = signinManager;
            _userManager = userManager;
            _roleManager = roleManager;

        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<ApiResponse<RegisterModel.Response>>> Register(RegisterModel.Request requestModel)
        {

            if (!await _roleManager.RoleExistsAsync("simpleUser"))
            {
                await _roleManager.CreateAsync(new IdentityRole("simpleUser"));
            }
            var user = new ApplicationUser()
            {
                UserName = requestModel.username,
                genre = requestModel.genre,
                interrets = requestModel.interrets,

            };


            var result = await _userManager.CreateAsync(user, requestModel.password);

            var responseModel = new ApiResponse<RegisterModel.Response>();

            if (result.Succeeded)
            {



                responseModel.Response = new RegisterModel.Response()
                {
                    username = requestModel.username,
                    genre = requestModel.genre,
                    coins = user.coins,
                    interrets = requestModel.interrets


                };


                var userFromDb = await _userManager.FindByNameAsync(requestModel.username);
                await _userManager.AddToRoleAsync(userFromDb, "simpleUser");
                var userRole = await _userManager.GetRolesAsync(user);

                responseModel.Response.role = userRole;
            
          



            return Ok(responseModel);

       

            }
            else
            {

              responseModel.errorMessages. AddRange(result.Errors.Select(err => err.Description));


            return BadRequest(responseModel);

            }
        }
    }
}
