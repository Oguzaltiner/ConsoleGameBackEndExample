using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Abstract
{
    public abstract class BaseCustomerManager : IRepository<Customer, int>
    {
        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

      
        public virtual void Save(Customer entity)
        {
            throw new NotImplementedException();
        }


        public virtual void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
