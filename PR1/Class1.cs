using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_6
{
    public class Class1
    {
        public static double Lib_6(out double randomValue, out double numberValue)
        {
            randomValue = 0;
            numberValue = 0;
            Random rnd = new Random();
            int randomNumber = rnd.Next(-5, 4);
            int randomNumber2 = rnd.Next(-5, 4);
            while (randomNumber != randomNumber2)
            {
                randomNumber2 = randomNumber;
                if (randomNumber > 0)
                {
                    double numberCalc = Math.Sqrt(randomNumber);
                    numberValue = numberCalc;
                }
                if (randomNumber < 0)
                {
                    double numberCalc = Math.Pow(randomNumber, 2);
                    numberValue = numberCalc;
                }
                randomNumber = rnd.Next(-5, 4);
                randomValue = randomNumber2;
            }
            return 0;
        }
    }
}