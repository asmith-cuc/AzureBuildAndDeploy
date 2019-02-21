using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AzureBuildAndDeploy.Tests
{
    [TestFixture]
    public class SeleniumTests
    {
        [Test]
        public void SeleniumTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Close();
            Assert.Pass();
        }

    }
}
