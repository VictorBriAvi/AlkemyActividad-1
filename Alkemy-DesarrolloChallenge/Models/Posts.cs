using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alkemy_DesarrolloChallenge.Models
{

    //● Posts: deberá tener,

    //Title
    //Date
    //Content
    //User que creo el Post
    public class Posts
    {
        [Key]
        public int PostsId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public Usuario Usuario { get; set; }
    }
}
