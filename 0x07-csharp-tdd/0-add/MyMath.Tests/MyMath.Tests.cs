using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void OnePlusOne()
        {
            
            Assert.AreEqual(2, Operations.Add(1, 1));
        }
    }
}