using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckRealPerson(Customer customer);
    }
}
