using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace seleniumCsharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://abv.bg");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }


}