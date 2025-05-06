using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteTestsDemo
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfDay)
        {
            string output = string.Empty;
            if(hourOfDay < 12)
            {
                output = $"Good morning {firstName}";
            }
            else if (hourOfDay < 18)
            {
                output = $"Good afternoon {firstName}";
            }
            else
            {
                output = $"Good evening {firstName}";
            }
            return output;
        }
    }
}
