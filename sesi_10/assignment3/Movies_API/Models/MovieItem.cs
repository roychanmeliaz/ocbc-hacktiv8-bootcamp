using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_API.Models
{
    public class MovieItem
    {
        private Models.MovieContext context;

        public int id {get; set;}
        public string name {get; set;}
        public string genre {get; set;}
        public string duration {get; set;}
        public DateTime releasedate {get; set;}
    }
}