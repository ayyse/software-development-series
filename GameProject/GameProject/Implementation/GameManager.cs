using GameProject.Contracts;
using GameProject.Models;
using System;

namespace GameProject.Implementation
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " added.");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.Name + " removed.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " updated.");
        }
    }
}
