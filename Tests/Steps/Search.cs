using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using EuroOffice.Framework.Pages;

namespace EuroOffice.Tests.Steps
{
    [Binding]
    class Search
    {
        [Given(@"That I have gone to the website")]
        public void GivenThatIHaveGoneToTheWebsite()
        {
            Pages.HomePage.Goto();
        }

        [Given(@"I enter the search value '(.*)'")]
        [Then(@"I enter the search value '(.*)'")]
        public void GivenIEnterTheSearchValue(string searchText)
        {
            Pages.HomePage.EnterSearchValue(searchText);
        }

        [Given(@"I click the search button")]
        [Then(@"I click the search button")]
        public void GivenIClickTheSearchButton()
        {
            Pages.HomePage.ClickSearch();
        }

        [Then(@"successful product search results are shown")]
        public void ThenSuccessfulProductSearchResultsAreShown()
        {
            Assert.IsTrue(Pages.SearchResults.SearchResultsFound());
        }

        [Then(@"unsucessful search message it shown")]
        public void ThenUnsucessfulSearchMessageItShown()
        {
            Assert.IsTrue(Pages.SearchResults.UnsucessfulSearch());
        }

        [Then(@"I save the product count results for a search without speech marks")]
        public void ThenISaveTheProductCountResults()
        {
            int productCount = Pages.SearchResults.TotalProductsFound();
            if (!ScenarioContext.Current.ContainsKey("productCount"))
            {
                ScenarioContext.Current.Add("productCount", productCount);
            }
        }

        [Then(@"The search without speech marks should return more records than the one with speech marks")]
        public void ThenTheSearchWithoutSpeechMarksShouldReturnMoreRecordsThanTheOneWithSpeechMarks()
        {
            int productCount = 0;
            if (ScenarioContext.Current.ContainsKey("productCount"))
            {
                productCount = ScenarioContext.Current.Get<int>("productCount");
            }
            int speechMarkCount = Pages.SearchResults.TotalProductsFound();
            Assert.IsTrue(productCount > speechMarkCount);
        }
    }
}
