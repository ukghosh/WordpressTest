using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordpress.steps;

namespace Wordpress.tests
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dependencies.New();
            Dependencies.Inject.Logger.Debug("Hello world");
        }
    }
}
