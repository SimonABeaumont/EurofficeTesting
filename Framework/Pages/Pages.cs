using OpenQA.Selenium.Support.PageObjects;

namespace EuroOffice.Framework.Pages
{
    //This class allows access to system pages through the tests
    public static class Pages
    {
        //public static void Initilise()
        //{
        //    ArrayList pages = new ArrayList();

        //    foreach (var page in pages)
        //    {
               
        //    }
        //}

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
