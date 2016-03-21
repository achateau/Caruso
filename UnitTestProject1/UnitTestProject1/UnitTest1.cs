using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathProject;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSubstract()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Substract(10, 7);
            Assert.AreEqual(3, result);
        }
    }
}
