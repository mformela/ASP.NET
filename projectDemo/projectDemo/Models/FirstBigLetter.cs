using projectDemo.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectDemo.Models
{
    public class FirstBigLetter
    {
        [BigLetterAttribute]
        public string Nazwa { get; set; }
    }
}