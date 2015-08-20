using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EuroOffice.Framework.Pages
{
    public class SearchResults : Page
    {
        [FindsBy(How = How.ClassName, Using = "product-list")]
        public IWebElement ProductList { get; set; }

        [FindsBy(How = How.ClassName, Using = "ga-no-results")]
        public IWebElement NoResultsFound { get; set; }

        [FindsBy(How = How.ClassName, Using = "filtersBar")]
        public IWebElement FiltersBar { get; set; }

        /// <summary>
        /// Searches the page for the product search results element.
        /// </summary>
        /// <returns>Returns true in the no of found elements > 0 i.e. the search has found results.</returns>
        public bool SearchResultsFound()
        {
            return (Browser.Driver.FindElements(By.ClassName("product-wrapper")).Count > 0 );
        }

        /// <summary>
        /// Searches the page for the product search, nothing found element.
        /// </summary>
        /// <returns>Returns true if it find the element containing the unsuccessful match message.</returns>
        public bool UnsucessfulSearch()
        {
            return NoResultsFound.Displayed;
        }

        /// <summary>
        /// Find the Filters element with the total no of products found.
        /// </summary>
        /// <returns>Returns true if it find the element containing the unsuccessful match message.</returns>
        public int TotalProductsFound()
        {
            try
            {
                int productCount = 0;
                bool ok = int.TryParse(FiltersBar.FindElement(By.XPath("span/strong[3]")).Text, out productCount);

                if (ok)
                {
                    return productCount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
