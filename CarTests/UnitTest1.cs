using NUnit.Framework;
using Car_Raicing;
using NUnit.Framework.Legacy;

namespace CarTests
{
    public class AutobasTests
    {
        private Autobas autobas { get; set; }

        [SetUp]
        public void Setup()
        {
            autobas = new Autobas();
        }

        [Test]
        public void TestDriving()
        {
            // Arrange
            var expectedSpeed = autobas.Speed +50;

            // Act
            autobas.Driving();

            // Assert
            ClassicAssert.AreEqual(expectedSpeed, autobas.Speed);
        }

        [Test]
        public void TestFinish()
        {
            // Arrange
            autobas.distance = 0;

            // Act
            var result = autobas.Finish();

            // Assert
            ClassicAssert.IsTrue(result);
        }
    }
}
