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
            var appUrl = "https://cuc-buildanddeploy.azurewebsites.net/";

            driver.Navigate().GoToUrl(appUrl);

            try
            {
                var elementToClick = driver.FindElementById("doesnotexist");
                Assert.Pass();
            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

    }
}
