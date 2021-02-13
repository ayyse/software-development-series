using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Contracts
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Remove(Gamer gamer);
    }
}
