using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual Sales Sales { get; set; }
        public int SalesID { get; set; }
    }
}
