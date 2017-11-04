using projectDemo.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectDemo.Models
{
    public class ZipCode
    {
        [ZipCodeAttribute]
        public string KodPocztowy { get; set; }
    }
}