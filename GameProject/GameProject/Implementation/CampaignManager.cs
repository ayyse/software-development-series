using GameProject.Contracts;
using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Implementation
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " added.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated.");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " removed.");
        }
    }
}
