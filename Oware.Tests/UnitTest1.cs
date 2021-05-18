using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            House h = new House(0, 0);
            for (int i = 0; i < 3; i++)
            {
                h.AddSeedInPot(new Seed());
            }
            // Act
            h.ResetHouse();
            // Assert
            Assert.AreEqual(4, h.GetCount(), "adding new seeds increases the pots new seed number");
            
        }

        [Test]

        public void Test2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Pass();
        }
    }
}