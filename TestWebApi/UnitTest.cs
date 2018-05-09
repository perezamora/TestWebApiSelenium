using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestWebApi
{
    [TestClass]
    public class UnitTest
    {
        private IWebDriver driverFirefox;
        private IWebDriver driverChrome;

        [TestInitialize]
        public void TestSetup()
        {
            driverFirefox = new FirefoxDriver();
            driverChrome = new ChromeDriver();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driverFirefox.Quit();
            driverChrome.Quit();
        }


        [TestMethod]
        [DataRow("http://localhost:57657/api/Student/")]
        public void Shoud_WebApi_using_Firefox(string url)
        {
            driverFirefox.Navigate().GoToUrl(url);
            driverFirefox.Manage().Window.Maximize();
        }

        [TestMethod]
        [DataRow("http://localhost:57657/api/Student/")]
        public void Shoud_WebApi_using_Chrome(string url)
        {
            driverChrome.Navigate().GoToUrl(url);
            driverChrome.Manage().Window.Maximize();
        }
    }
}
