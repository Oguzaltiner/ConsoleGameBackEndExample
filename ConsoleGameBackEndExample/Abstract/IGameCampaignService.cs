using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Abstract
{
    public interface IGameCampaignService 
    {
        void BuyGameWithCampaign(Game game, Campaign campaign, Player player);
    }
}
