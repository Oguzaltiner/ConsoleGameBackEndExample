using ConsoleGameBackEndExample.Abstract;
using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Concreate
{
    public class CustomerManager : BaseCustomerManager
    {
        public override void Update(Customer entity)
        {
            base.Update(entity);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
        }
        public override void Save(Customer entity)
        {
            base.Save(entity);
        }


    }
}
