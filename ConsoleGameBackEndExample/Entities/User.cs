using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Entities
{
    public class User : BaseModel
    {

        public string Tc { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
