using System;
using System.Collections.Generic;
using System.Text;

namespace ExPower.Extension
{
    public static class NumPower
    {
        
        public static double Power(this int num, double power)
            
        {

            return Math.Pow(num, power);
        }

       
    } 
}
