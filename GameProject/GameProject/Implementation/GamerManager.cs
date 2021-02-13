using GameProject.Contracts;
using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Implementation
{
    public class GamerManager : IGamerService
    {
        IAuthenticationService _authenticationService;
        public GamerManager(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public void Add(Gamer gamer)
        {
            if (_authenticationService.Authentication(gamer) == true)
            {
                Console.WriteLine("Gamer " + gamer.Name + " " + gamer.Surname + " added.");
            }
            else
            {
                Console.WriteLine("Gamer " + gamer.Name + " " + gamer.Surname + " not added.");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.Name + " " + gamer.Surname + " removed.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.Name + " " + gamer.Surname + " updated.");
        }
    }
}
