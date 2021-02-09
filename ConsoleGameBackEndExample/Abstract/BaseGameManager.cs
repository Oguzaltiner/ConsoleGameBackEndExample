using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Abstract
{
    public abstract class BaseGameManager : IRepository<Game, int>
    {
        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Game entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
