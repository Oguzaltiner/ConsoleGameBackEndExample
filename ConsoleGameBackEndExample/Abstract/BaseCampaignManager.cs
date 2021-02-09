using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Abstract
{
    public abstract class BaseCampaignManager : IRepository<Campaign, int>
    {
        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Campaign entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Campaign entity)
        {
            throw new NotImplementedException();
        }
    }
}
