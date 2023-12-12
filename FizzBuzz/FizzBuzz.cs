using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string UserChoice(int userNum)
        {
            if (userNum % 3 == 0 && userNum % 5 == 0)
                return "FizzBuzz";


            if (userNum % 3 == 0)
                return "Fizz";


            if (userNum % 5 == 0)
                return "Buzz";


            return userNum.ToString();


        }
    }
}
