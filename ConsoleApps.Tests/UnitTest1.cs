using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApps.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter()
            
            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.ToDistance)
       
        }
    }
    
}
