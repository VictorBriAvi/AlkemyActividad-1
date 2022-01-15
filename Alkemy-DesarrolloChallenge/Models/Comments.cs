using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alkemy_DesarrolloChallenge.Models
{

    //● Comments: deberá tener,

    // Id.
    //Date
    //Comment
    //User que creo el Comment
    public class Comments
    {
        [Key]
        public int CommentsId { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public Usuario Usuario { get; set; }

    }
}
