using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SeleniumNunit
{
    class MainPage 
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private string URL = "http://automationpractice.com/index.php";


        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl(URL);

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "search_query_top")]
        private IWebElement SearchField;

        [FindsBy(How = How.Name, Using = "submit_search")]
        private IWebElement SearchButton;

        public void SearchFor(string Item)
        {
            SearchField.SendKeys(Item);
            SearchButton.Click();
        }

    }
}
