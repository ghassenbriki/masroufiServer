using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace masroufiServer.models
{
    public class Feedback
    {

        public int Id { get; set; }
        public string? message { get; set; }

        public string? date { get; set; }




    }



}