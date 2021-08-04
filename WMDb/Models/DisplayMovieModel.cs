using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMDb.Models
{
    public class DisplayMovieModel
    {
        [Required(ErrorMessage = "Zadejte název filmu")]
        [StringLength(100, ErrorMessage = "Název je příliš dlouhý.")]
        public string Title { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        [Range(0, 100, ErrorMessage = "Zadejte číslo od 0 do 100")]
        public int Rating { get; set; }
    }
}
