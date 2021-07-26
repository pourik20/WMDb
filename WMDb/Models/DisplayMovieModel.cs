using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMDb.Models
{
    public class DisplayMovieModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Název je příliš dlouhý.")]
        [MinLength(1, ErrorMessage = "Zadejte název filmu.")]
        public string Title { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public int Rating { get; set; }
    }
}
