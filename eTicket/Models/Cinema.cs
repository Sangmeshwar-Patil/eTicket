using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
