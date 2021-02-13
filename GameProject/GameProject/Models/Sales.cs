using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Models
{
    public class Sales
    {
        public int SalesID { get; set; }
        public List<Game> Games { get; set; }
        public List<Gamer> Gamers { get; set; }
    }
}
