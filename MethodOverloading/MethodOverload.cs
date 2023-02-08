using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class MethodOverload
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool check)
        {
            var sum = num1 + num2;
            if (check == true && sum > 1)
            {
                return $"{sum} dollars!";
               
            }
            else if (check == true && sum == 1) 
            {
                return $"{sum} dollar.";
            }
            else if (check == true && sum < 1)
            {
                return $"{sum} cents";
            }
            else
            {
                return sum.ToString();
            } 

            
        }
    }
}
