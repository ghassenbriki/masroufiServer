using masroufiServer.apiModels;
using masroufiServer.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace masroufiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ClientController(ApplicationDbContext db)
        {
            _dbContext = db;
        }



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






}
    

}

        

    

