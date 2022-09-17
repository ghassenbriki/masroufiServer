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
    public class AdminController : ControllerBase
    {

        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment hostEnvironment;

        public AdminController(IConfiguration configuration, SignInManager<ApplicationUser> signinManager, UserManager<ApplicationUser> userManager, ApplicationDbContext db, IWebHostEnvironment hostEnvironment)

        {
            _signinManager = signinManager;
            _userManager = userManager;
            _configuration = configuration;
            _dbContext = db;
            this.hostEnvironment = hostEnvironment;
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


        [HttpGet]
        [Route("missions/all")]
        [Authorize(Roles = "admin")]

        public async Task<ActionResult<Mission>> getAllMissions()

        {


            var res = await _dbContext.Missions.ToListAsync();

            if (res != null)

                return Ok(res);

            else return BadRequest();


        }



        [Authorize(Roles = "admin")]
        [HttpPost]
        [Route("mission")]

        public async Task<ActionResult<ApiResponse<Mission>>> postMision([FromBody] MissionModel missionModel)

        {
            var resp = new ApiResponse<Mission>();
            Mission mission;

            mission = resp.Response=new Mission()
             {
                 coinsShare = missionModel.coinsShare,
                 coinsview =missionModel.coinsView
             };

            mission.spot = await saveVid(missionModel.vidName);

        
           _dbContext.Missions.Add(mission);
            
            await _dbContext.SaveChangesAsync();

            return Ok(resp);

            
            



        }







































        public async Task <string> saveVid(IFormFile vidfile)
        {
            string vidName = new string(Path.GetFileNameWithoutExtension(vidfile.FileName)
                .Take(10).ToArray()).Replace(' ', '-');
            vidName = vidName + DateTime.Now.ToString("yymmssfff")+ Path.GetExtension(vidfile.FileName);
            var videoPath = Path.Combine(hostEnvironment.ContentRootPath, "vids", vidName);
            using (var fileStream = new FileStream(videoPath, FileMode.Create)) 
            {
                await vidfile.CopyToAsync(fileStream);
            }

            return vidName;

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
