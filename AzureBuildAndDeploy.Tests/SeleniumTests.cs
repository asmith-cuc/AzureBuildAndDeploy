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
            var chromeDriverPath = Environment.GetEnvironmentVariable("ChromeWebDriver");
            var driver = new ChromeDriver(chromeDriverPath);
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Quit();
            Assert.Fail();
        }

    }
}
