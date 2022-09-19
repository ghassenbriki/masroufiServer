using masroufiServer.apiModels;
using masroufiServer.migrations;
using masroufiServer.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace masroufiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
   
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment hostEnvironment;

        public AdminController(IConfiguration configuration,  ApplicationDbContext db, IWebHostEnvironment hostEnvironment)

        {
           
            _configuration = configuration;
            _dbContext = db;
            this.hostEnvironment = hostEnvironment;
        }

        
        //[Authorize(Roles ="admin")]
        [HttpGet]
        [Route("Missions")]

        public async Task<ActionResult<IEnumerable<Mission>>> getAllMissions()

        {



            return await _dbContext.Missions.Select(x=>new Mission
            {
                Id = x.Id,
                category=x.category,
                Sponsor=x.Sponsor,
                nbShare=x.nbShare,
                nbView=x.nbView,
                vidSource=String.Format("{0}://{1}{2}/vids/{3}",Request.Scheme,Request.Host,Request.PathBase,x.spot)
               
            }).ToListAsync();


            
        }



       [Authorize(Roles = "admin")]
        [HttpPost]
        [Route("Mission")]

        public async Task<ActionResult> postMision([FromForm] MissionModel missionModel)

        {
            var resp = new ApiResponse<Mission>();
            Mission mission;

            mission = resp.Response = new Mission()
            {
                coinsShare = missionModel.coinsShare,
                coinsview = missionModel.coinsView,
                Sponsor = missionModel.Sponsor,
                category =missionModel.category
            };

            mission.spot = await saveVid(missionModel.vidName);


            _dbContext.Missions.Add(mission);

            await _dbContext.SaveChangesAsync();

            return Ok("mission posted succepully");

        }



        [Authorize(Roles = "admin")]
        [HttpDelete("delete/{id}")]
       

        public async Task<ActionResult<Mission>> deleteMission(int id)

        {
            var mission=await _dbContext.Missions.FindAsync(id);
            if(mission==null)
            {
                return NotFound();

            }

             _dbContext.Remove(mission);
            await _dbContext.SaveChangesAsync();

            return Ok(mission);
        }














        [NonAction]
        public async Task<string> saveVid(IFormFile vidfile)
        {
            string vidName = new string(Path.GetFileNameWithoutExtension(vidfile.FileName)
                .Take(10).ToArray()).Replace(' ', '-');
            vidName = vidName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(vidfile.FileName);
            var videoPath = Path.Combine(hostEnvironment.ContentRootPath, "vids", vidName);
            using (var fileStream = new FileStream(videoPath, FileMode.Create))
            {
                await vidfile.CopyToAsync(fileStream);
            }

            return vidName;

        }
    }
}
