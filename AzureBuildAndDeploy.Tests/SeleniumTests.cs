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
            //var chromeDriverPath = Environment.GetEnvironmentVariable("ChromeWebDriver");
            var driver = new ChromeDriver();
            var appUrl = "https://cuc-buildanddeploy.azurewebsites.net/";
            var newWebPageUrl = "https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2";

            driver.Navigate().GoToUrl(appUrl);

            var elementToClick = driver.FindElementById("overviewLink");
            elementToClick.Click();

            Assert.That(driver.PageSource == newWebPageUrl);

            driver.Quit();
        }

    }
}
