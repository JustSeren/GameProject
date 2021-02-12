using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public class SaleManager : ISaleService
    {
        public void CamapignSales(Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "adlı kullanıcı" + campaign.CampaignName + "kampanyasıyla" + game.GameName + "oyununu aldı");
        }


        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "adlı kullanıcı" + game.GameName + "adlı oyunu aldı");
           
        }
    }
}
