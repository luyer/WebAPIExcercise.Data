using System.ComponentModel.DataAnnotations;

namespace WebAPIExercise.Data.Models
{

    public class Post
    {
        public long Id { get; set; }
        
        [Required] [MaxLength(10)]
        public string Title { get; set; }
        
        [MaxLength(30)]
         public string Body { get; set; }
         
         [MaxLength(15)]
         public string Autor { get; set; }
    }
}