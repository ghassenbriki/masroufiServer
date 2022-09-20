using System.ComponentModel.DataAnnotations;

namespace masroufiServer.apiModels
{
    public class FeedbackModel
    {
        [Required]
        public string message { get; set; }
    }
}
