using System;
using EuroOffice.Framework.Common;
using EuroOffice.Framework.Setup;

namespace EuroOffice.Framework.Pages
{
    public abstract class Page : PageObject
    {
        public static string Url { get; set; }

        protected Page()
        {
            Url = EnvironmentReader.get(GetType().Name).Url;
            PageTitle = EnvironmentReader.get(GetType().Name).PageTitle;
        }
         
        /// <summary>
        /// Navigates to the page URL.
        /// </summary>
        public void Goto()
        {
            try
            {
                Browser.Goto(Url);
                WaitForLoad();
            }
            catch (Exception e)
            {
                throw new Exception(GetType().Name + " could not be loaded. Check page url is correct in app.config." +
                                    " " + e.Message);
            }
        }
    }
}
