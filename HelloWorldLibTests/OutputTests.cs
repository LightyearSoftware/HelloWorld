using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorldLib.Tests
{
    [TestClass()]
    public class OutputTests
    {
        [TestMethod()]
        public void OutputFactoryTest()
        {
            try
            {
                IOutput demo = Output.OutputFactory();
                demo.WriteData("Hello World");
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}