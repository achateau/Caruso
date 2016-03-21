using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriverProgram;

using NUnit.Framework;

namespace Program1
{

    [TestFixture]
    public class ExampleTests
    {
        [Test]
        public void AddNumbersTest()
        {
            Assert.AreEqual(10, NumberFunctions.AddNumbers(5, 5));
        }
    
    }

}
    