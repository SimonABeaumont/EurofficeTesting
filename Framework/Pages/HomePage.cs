using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Euroffice.Framework.Pages
{
    public class HomePage : Page
    {
        [FindsBy(How = How.Id, Using = "term")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "searchButton")]
        public IWebElement SearchButton { get; set; }

        /// <summary>
        /// Send text to the Search Field text box
        /// </summary>
        public void EnterSearchValue(string searchText)
        {
            try
            {
                SearchField.Clear();
                SearchField.SendKeys(searchText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        /// Clicks on the Search button and waits for the search results elements to show
        /// on screen
        /// </summary>
        public void ClickSearch()
        {
            try
            {
                SearchButton.Click();
                var wait = new WebDriverWait(Browser.getDriver, TimeSpan.FromSeconds(5));
                wait.Until(x => x.FindElement(By.ClassName("product-wrapper,ga-no-results")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }            
        }
    }
}
