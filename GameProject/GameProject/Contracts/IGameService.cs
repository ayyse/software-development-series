using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Contracts
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Remove(Game game);
    }
}
