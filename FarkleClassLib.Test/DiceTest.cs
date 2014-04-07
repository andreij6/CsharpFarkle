using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarkleClassLib.Test
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void RollTest_DefaultOneDice()
        {
            int rolledValue = Dice.HeadsOrTails();
            bool answer = false;
            
            if (rolledValue <= 6 & rolledValue > 0)
	        {
                answer = true;
	        }

            Assert.IsTrue(answer);
        }

    }
}
