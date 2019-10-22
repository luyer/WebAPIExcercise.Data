using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIExercise.Data.Models
{
    public class Comment
    {
        public long Id { get; set; }
        
        [Required] [MaxLength(10)]
        public string Autor { get; set; }
        
        [MaxLength(30)]
         public string Body { get; set; }
        
        public long PostId { get; set; }

         public Post Post { get; set; }

    }
}