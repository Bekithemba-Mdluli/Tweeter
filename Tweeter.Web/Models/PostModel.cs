using System;
namespace Tweeter.Web.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public DateTime PostedAt { get; set; } = DateTime.Now;
        public string Caption { get; set; }

        //public int Id { get; set; }
        //public int Id { get; set; }
        //public int Id { get; set; }
    }
}

