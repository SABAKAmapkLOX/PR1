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
            int randomNumber = rnd.Next(-5, 4);// Генерируется рандомное число от -5 до 4 для randomNumber
            int randomNumber2 = rnd.Next(-5, 4);// Генерируется рандомное число от -5 до 4 для randomNumber2
            while (randomNumber != randomNumber2)// Цикл
            {
                randomNumber2 = randomNumber;
                if (randomNumber > 0)//Условие
                {
                    double numberCalc = Math.Sqrt(randomNumber);// Возводится в корень
                    numberValue = numberCalc;
                }
                if (randomNumber < 0)// Условие
                {
                    double numberCalc = Math.Pow(randomNumber, 2);// Возводится в степень
                    numberValue = numberCalc;
                }
                randomNumber = rnd.Next(-5, 4);// Генерируется рандомное число от -5 до 4 для randomNumber
                randomValue = randomNumber2;
            }
            return 0;//Вернуть 0
        }
    }
}