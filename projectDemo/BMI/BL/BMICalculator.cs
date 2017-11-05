using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMI.BL
{
    public class BMICalculator
    {

        public float CalculateBMI(float masa, float wzrost)
        {
            var bmi = masa / ((wzrost/100) * (wzrost/100));
            return bmi;
        }





    }
}