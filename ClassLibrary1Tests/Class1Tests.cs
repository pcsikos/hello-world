using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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