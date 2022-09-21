using masroufiServer.apiModels;
using masroufiServer.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace masroufiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ClientController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _dbContext = db;
            _userManager = userManager;
        }





        [Authorize(AuthenticationSchemes = "Bearer", Roles = "simpleUser")]
        [HttpGet]
        [Route("filtredMissions")]
        
        public  async Task<ActionResult <IEnumerable<Mission>>> getMissions()
        {

               var user = await _userManager.FindByNameAsync(User.Identity.Name);

                var tab = user.interrets.Split(" ");



            return Ok(_dbContext.Missions.Where(x => tab.Contains(x.category))
                                          .Where(x=>!x.users.Contains(user)));
           

    
        }
        
/*
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "simpleUser")]
        [HttpPost]
        [Route("spotview")]

        public async Task <ActionResult> ViewMission()
        {
            

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            user.missions = new List<Mission>();

            var mission = new Mission()
            {
                category = "sport",
                coinsShare = 70,
                coinsview = 40,
                Sponsor="deze"
            };


            user.coins += (int)(mission.coinsview);
            user.missions.Add(mission);
          

            _dbContext.SaveChanges();

           

                return Ok(mission);




       


        }


        */


        [HttpPost("Feedback")]

        public async Task<IActionResult> postFeedback([FromBody] FeedbackModel feedbackModel)

        {

         
             Feedback _feedback;

            _feedback = new Feedback()
            {
                message = feedbackModel.message,
                date = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
            };

             _dbContext.FeedBacks.Add(_feedback);

            await _dbContext.SaveChangesAsync();

            return Ok("votre feedback a été envoyé ");



        }


        [Authorize(AuthenticationSchemes = "Bearer", Roles = "simpleUser")]
        [HttpPost("changePseudo")] 
        public async Task <ActionResult<ApiResponse>> changeUsername( PseudoModel pseudoModel)

        {
            // Get the user
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user!=null)
            {
                user.UserName = pseudoModel.pseudo;
                await _userManager.UpdateAsync(user);

            }
        
            
            return Ok(new ApiResponse());

        }







        [Authorize(AuthenticationSchemes = "Bearer", Roles = "simpleUser")]
        [HttpPost("changepwd")]
        public async Task<ActionResult<ApiResponse>> ChangePassword(ChangePasswordModel requestModel)
        {
            var responseModel = new ApiResponse();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            // Try to change the password

            if (user != null)
            {
                var result = await _userManager.ChangePasswordAsync(user, requestModel.oldPassword, requestModel.newPassword);


           
                // if there is an error
                if (!result.Succeeded)
                {
                    // Add the errors to the response
                    responseModel.errorMessages.AddRange(result.Errors.Select(err => err.Description));

                    return responseModel;
                }


                return Ok(responseModel);


            }

            return NotFound();


        }



        [Authorize(AuthenticationSchemes = "Bearer", Roles = "simpleUser")]
        [HttpGet("infos")]
        public async Task<ActionResult<APIResponse<UserAPIModel>>> GetMyInfo()
        {

            // Get the logged in user

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
          
        
            

            var responseModel = new APIResponse<UserAPIModel>();

       
            responseModel.Response = new UserAPIModel
            {
                pseudo=user.UserName,
                coins=user.coins,
                ville=user.ville
            };

            return Ok(responseModel);

        }







    }


}

        

    

