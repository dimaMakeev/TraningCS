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
        WebDriverWait wait;

        public static Customer BuildCustomer()
        {
            return new Customer();
        }

        [SetUp]
        public void SetupDriver()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        }

        [Test]
        public void MainScenario(Customer cr)
        {


        }
    }
}
