using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarkleClassLib
{
    public class Dice
    {
        public static int Roll(int numberOfDice = 1)
        {
            var range = Enumerable.Range(1, 6);
            if( !range.Contains(numberOfDice))
            {
                return 0;
            }

            int value = 0;
            Random r = new Random();

            while (numberOfDice > 0)
            {
                value += r.Next(1, 6);
                numberOfDice -= 1;
            }

            return value;
        }
    }
}
