using ConsoleGameBackEndExample.Abstract;
using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Concreate
{
    public class CampaignManager : BaseCampaignManager
    {
        public override void Save(Campaign entity)
        {
            base.Save(entity);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
        }
        public override void Update(Campaign entity)
        {
            base.Update(entity);
        }
    }
}
