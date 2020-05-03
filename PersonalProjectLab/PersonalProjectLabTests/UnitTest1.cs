using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;


namespace PersonalProjectLabTests
{
    [TestClass]
    public class MathClassTests
    {
        [TestMethod]
        public void CalculateTotalMilesCheck()
        {
            MathClass Numbers = new MathClass();
            int TotalMiles = Numbers.CalculateAverageTime();
        }

        [TestMethod]
        public void CalculateAverageTimeCheck()
        {
            MathClass Numbers = new MathClass();
            decimal Average = Numbers.CalculateAverageTime(3,30,25);

            Assert.AreEqual(8.4, Average);
        }
    }
}
