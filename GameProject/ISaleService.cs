using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        void Sale(Game game, Gamer gamer);
        void CamapignSales(Game game, Gamer gamer , Campaign campaign);
    }
}
