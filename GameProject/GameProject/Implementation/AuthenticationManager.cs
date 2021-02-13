using GameProject.Contracts;
using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Implementation
{
    public class AuthenticationManager : IAuthenticationService
    {
        public bool Authentication(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.Name == "Ayşe"
                && gamer.Surname == "Akışık" && gamer.Identity == "11111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
