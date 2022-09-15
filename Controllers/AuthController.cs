using masroufiServer.apiModels;
using masroufiServer.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace masroufiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration ,SignInManager<ApplicationUser> signinManager,UserManager<ApplicationUser> userManager
            ,RoleManager<IdentityRole> roleManager)

        {
            _signinManager = signinManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;

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


                var userFromDb = await _userManager.FindByNameAsync(requestModel.username);
                await _userManager.AddToRoleAsync(userFromDb, "simpleUser");

                responseModel.Response = new RegisterModel.Response()
                {
                 
                    genre = requestModel.genre,
                    coins = user.coins,
                    interrets = requestModel.interrets,
                    token= await JwtTokenGeneratorMachineAsync(user)


                };


               /* var userRole = await _userManager.GetRolesAsync(user);

                responseModel.Response.role = userRole;*/
            
          



            return Ok(responseModel);

       

            }
            else
            {

              responseModel.errorMessages. AddRange(result.Errors.Select(err => err.Description));


            return BadRequest(responseModel) ;

            }
        }
        
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<ApiResponse<LoginModel.Response>>> Login(LoginModel.Request requestModel)
        {
            var responseModel= new ApiResponse<LoginModel.Response>();
            ApplicationUser user;



            user = await _userManager.FindByNameAsync(requestModel.username);

            if (user == null)
            {
                responseModel.errorMessages.Add("Pseudo intouvable");
                return BadRequest( responseModel);
            }

            var result = await _signinManager.PasswordSignInAsync(user, requestModel.password, false, false);

            if (result.Succeeded)
            {
                /*var userFromDb = await _userManager.FindByNameAsync(requestModel.username);
                var userRole = await _userManager.GetRolesAsync(userFromDb);*/

            


                responseModel.Response = new LoginModel.Response()
                {
                    token = await JwtTokenGeneratorMachineAsync(user),
                   // role= userRole
                };
                

                return Ok(responseModel);
            }

            responseModel.errorMessages.Add("mot de passe éronné");


            return  BadRequest(responseModel);
        }



        private async Task<string> JwtTokenGeneratorMachineAsync(ApplicationUser userInfo)
        {
            var claims = new List<Claim>
    {
         new Claim(ClaimTypes.NameIdentifier, userInfo.Id),
         new Claim(ClaimTypes.Name, userInfo.UserName)
    };
            var roles = await _userManager.GetRolesAsync(userInfo);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }


            var securityKey = new SymmetricSecurityKey(Encoding.UTF8
             .GetBytes(_configuration.GetSection("AppSettings:Key").Value));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = credentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }




    }    

}

