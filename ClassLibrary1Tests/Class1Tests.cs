using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod]
        public void And_BothTrueGiven_ShouldReturnTrue()
        {
            var result = Class1.And(true, true);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void And_AnyFalseGiven_ShouldReturnFalse()
        {
            var result = Class1.And(true, false);
            Assert.AreEqual(result, false);
        }
    }
}