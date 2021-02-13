using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Contracts
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Gamer gamer, Game game, Campaign campaign);
    }
}
