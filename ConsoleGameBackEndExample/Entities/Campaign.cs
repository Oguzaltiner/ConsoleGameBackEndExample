using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Entities
{
    public class Campaign : BaseModel
    {
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }



    }
}
