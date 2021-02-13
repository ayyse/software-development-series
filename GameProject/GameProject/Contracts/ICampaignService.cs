using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Contracts
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Remove(Campaign campaign);
    }
}
