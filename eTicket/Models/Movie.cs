using eTicket.Data;
using eTicket.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public virtual  Cinema Cinemas { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public virtual  Producer Producers { get; set; }

        public ICollection<Actor_Movie> Actors_Movies { get; set; }

    }
}
