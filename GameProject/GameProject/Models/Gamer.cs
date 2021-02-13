using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Models
{
    public class Gamer
    {
        public int GamerID { get; set; }
        public string Identity { get; set; }
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual Sales Sales { get; set; }
        public int SalesID { get; set; }
    }
}
