using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Alkemy_DesarrolloChallenge.Models;

namespace Alkemy_DesarrolloChallenge.Models
{

    //● Usuario: deberá tener,

    //                 Id.
    //                Name
    //                Password
    //                Email.
    //                Posts
    //                Comments
    public class Usuario
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public ICollection<Posts> Posts { get; set; }

        public ICollection<Comments> Comments { get; set; }
    }
}
