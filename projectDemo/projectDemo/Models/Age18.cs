using projectDemo.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectDemo.Models
{
    public class Age18
    {
        [PelnoletnoscAttribute]
        public int Age {get; set;}
    }
}