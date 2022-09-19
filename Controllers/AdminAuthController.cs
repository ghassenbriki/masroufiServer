using masroufiServer.apiModels;
using masroufiServer.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Text;

namespace masroufiServer.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AdminAuthController : ControllerBase
    {

        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _dbContext;
      

        public AdminAuthController(IConfiguration configuration, SignInManager<ApplicationUser> signinManager, UserManager<ApplicationUser> userManager, ApplicationDbContext db)

        {
            _signinManager = signinManager;
            _userManager = userManager;
            _configuration = configuration;
            _dbContext = db;
           
        }

        [HttpPost]
        [Route("Login")]

        public async Task<ActionResult<ApiResponse<LoginModel.Response>>> Login(LoginModel.Request requestModel)

        {


            var responseModel = new ApiResponse<LoginModel.Response>();
            ApplicationUser user;

            user = await _userManager.FindByNameAsync(requestModel.username);

            if (user == null)
            {
                responseModel.errorMessages.Add("vérifiez ton username");
                return BadRequest(responseModel);
            }
            var result = await _signinManager.PasswordSignInAsync(user, requestModel.password, false, false);

            if (result.Succeeded)
            {


                responseModel.Response = new LoginModel.Response()
                {
                    token = await JwtTokenGeneratorMachineAsync(user),

                };


                return Ok(responseModel);
            }

            responseModel.errorMessages.Add("mot de passe éronné");


            return BadRequest(responseModel);

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

