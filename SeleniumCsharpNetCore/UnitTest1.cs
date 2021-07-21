using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpNetCore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("http://backend.tmsapp.2stallions.site/login");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Id("email")).SendKeys("superadmin@mail.com");
            Driver.FindElement(By.Id("password")).SendKeys("123456");
            Driver.FindElement(By.XPath("//button")).Click();
            Assert.Pass();
            Driver.Quit();
        }
    }
}