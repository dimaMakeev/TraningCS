using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumNunit
{
    public class Test
    {

        IWebDriver driver;


        public static Customer BuildCustomer()
        {
            return new Customer();
        }

        [SetUp]
        public void SetupDriver()
        {
            driver = new ChromeDriver();
            
        }

        [Test]
        public void SearchAndBuy()
        {
            var MainPage = new MainPage(driver);
            MainPage.SearchFor("T-Shirt");

        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
