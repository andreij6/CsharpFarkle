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
            int rolledValue = Dice.Roll();
            bool answer = false;
            
            if (rolledValue <= 6 & rolledValue > 0)
	        {
                answer = true;
	        }

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void RollTest()
        {
            int rolledValue = Dice.Roll(4);
            bool answer = false;

            if (rolledValue <= 24 & rolledValue > 4)
            {
                answer = true;
            }

            Assert.IsTrue(answer);
        }

        #region Roll Range Tests
        [TestMethod]
        public void RollTest_ReturnsZeroOutofRangeAbove()
        {
            int rolledValue = Dice.Roll(7);

            Assert.AreEqual(0, rolledValue);
        }

        [TestMethod]
        public void RollTest_ReturnsZeroOutofRangeBelow()
        {
            int rolledValue = Dice.Roll(0);

            Assert.AreEqual(0, rolledValue);
        }
        //Edge Cases
        [TestMethod]
        public void RollTest_ReturnsZeroOutofRangeTopEdge()
        {
            int rolledValue = Dice.Roll(1);

            Assert.AreNotEqual(0, rolledValue);
        }

        [TestMethod]
        public void RollTest_ReturnsZeroOutofRangeBottomEdge()
        {
            int rolledValue = Dice.Roll(6);

            Assert.AreNotEqual(0, rolledValue);
        }
        #endregion
    }
}
