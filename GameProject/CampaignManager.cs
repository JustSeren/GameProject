using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi" +campaign.CampaignName+ "indirim="+campaign.CampaignRate);
        }

     

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi"+ campaign.CampaignName );
        }



        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"kampanya güncellendi" +campaign.CampaignRate +"oldu");
        }

    }
}
