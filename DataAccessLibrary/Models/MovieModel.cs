using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class MovieModel
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Length { get; set; }
        public int Rating { get; set; }
    }
}
