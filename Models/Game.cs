using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameHubRentals.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Platform { get; set; }
        public string Name { get; set; }
        public int rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool inStock { get; set; }
        public int quantity { get; set; }

        
    }
}