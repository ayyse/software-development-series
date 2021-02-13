using GameProject.Contracts;
using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Implementation
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name + " was sold to gamer " + gamer.Name + " " + gamer.Surname + ".");
        }

        public void CampaignSales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.Name + " was sold to gamer " + gamer.Name + " " + gamer.Surname + " with " + campaign.Name + ".");
        }
    }
}
