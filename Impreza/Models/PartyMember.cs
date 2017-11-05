using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Impreza.Models
{
    public class PartyMember
    {
      
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        
        public bool Confirmation { get; set; } 
        

    }
}