using OpenQA.Selenium.Support.PageObjects;

namespace EuroOffice.Framework.Pages
{
    //This class allows access to system pages through the tests
    public static class Pages
    {

        public static HomePage HomePage
        {
            get
            {
                var page = new HomePage();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }

        public static SearchResults SearchResults
        {
            get
            {
                var page = new SearchResults();
                PageFactory.InitElements(Browser.Driver, page);
                return page;
            }
        }
    }

}
