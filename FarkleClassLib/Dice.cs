using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarkleClassLib
{
    public class Dice
    {
        public static int HeadsOrTails()
        {
            Random r = new Random();
            int value = r.Next(1, 6);

            return value;
        }

        public static List<int> Roll(int numberOfDi)
        {
            Random r = new Random();
            List<int> rolledValues = new List<int>();

            while(numberOfDi > 0)
            {
                rolledValues.Add(r.Next(1, 7));
                numberOfDi--;
            }

            return rolledValues;
                
        }


    }
}
