using GameProject.Implementation;
using GameProject.Models;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GAMES");
            Game game1 = new Game() { GameID = 1, Name = "League of Legends", Price = 200 };
            Game game2 = new Game() { GameID = 2, Name = "PUBG", Price = 300 };
            Game game3 = new Game() { GameID = 3, Name = "Counter-Strike: Global Offensive", Price = 450 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game2);
            gameManager.Remove(game3);

            Console.WriteLine("");
            Console.WriteLine("GAMERS");

            Gamer gamer = new Gamer() { GamerID = 1, Identity = "11111", Name = "Ayşe", Surname = "Akışık", BirthYear = 1999 };

            GamerManager gamerManager = new GamerManager(new AuthenticationManager());
            gamerManager.Add(gamer);

            Console.WriteLine("");
            Console.WriteLine("CAMPAIGNS");

            Campaign campaign1 = new Campaign() { CampaignID = 1, Name = "Campaign1" };
            Campaign campaign2 = new Campaign() { CampaignID = 2, Name = "Campaign2" };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Remove(campaign1);

            Console.WriteLine("");
            Console.WriteLine("SALES");

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game1);
            salesManager.CampaignSales(gamer, game2, campaign2);

        }
    }
}
