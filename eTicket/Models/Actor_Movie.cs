using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor_Movie
    {
        public int ActorId { get; set; }
        public Actor Actors { get; set; }

        public int MovieId { get; set; }
        public Movie Movies { get; set; }
    }
}
