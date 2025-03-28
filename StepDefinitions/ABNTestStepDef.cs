using ABN_Test.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ABN_Test.StepDefinitions
{
    [Binding]
    public sealed class ABNTestStepDef
    {
        private IWebDriver driver;
        Homepage homepage;
        SearchResult searchResult;
        ABNDetails abnDetails;
        AdvanceSearch advanceSearch;

        public ABNTestStepDef(IWebDriver driver)
        {
            this.driver = driver;
            homepage = new Homepage(driver);
            searchResult = new SearchResult(driver);
            abnDetails = new ABNDetails(driver);
            advanceSearch = new AdvanceSearch(driver);
        }

        [Given("I open ABN Lookup webpage")]
        public void GivenIOpenABNLookupWebpage()
        {
            driver.Url = "https://abr.business.gov.au/";
        }

        [When("ABN Lookup page is open")]
        public void ThenABNLookupPageIsOpen()
        {
            homepage.ValidaeABNLookupIcon();
        }

        [Then("The page is validated")]
        public void ThenThePageIsValidated()
        {
            homepage.ValidateABNLookupDashboard();
        }

        [When("I search Fiable on the ABN Lookup page")]
        public void WhenISearchFiableOnTheABNLookupPage()
        {           
            homepage.SearchABN("fiable");
        }

        [Then("list with Fiable matching name will appear")]
        public void ThenListWithFiableMatchingNameWillAppear()
        {
            searchResult.ValidSearchResultPage();
        }

        [When("I click the ABN for Fiable PTY LTD")]
        public void WhenIClickTheABNForFiablePTYLTD()
        {
            searchResult.OpenFiableABN();
        }

        [Then("I will see the details of the entity")]
        public void ThenIWillSeeTheDetailsOfTheEntity()
        {
            abnDetails.ValidateABNResultPage();
            Thread.Sleep(500);
        }

        [When("I search invalid ABN")]
        public void WhenISearchInvalidABN()
        {
            homepage.SearchABN("abcd1234test123");
        }

        [Then("No matching names are found")]
        public void ThenNoMatchingNamesAreFound()
        {
            searchResult.InvalidSearchResultPage();
            Thread.Sleep(500);
        }

        [When("I open advance search")]
        public void WhenIOpenAdvanceSearch()
        {
            Thread.Sleep(500);
            homepage.OpenAdvanceSearchPage();
        }

        [Then("I search fiable on advance search page")]
        public void ThenISearchFiableOnAdvanceSearchPage()
        {
            advanceSearch.FiableAdvanceSearch("Fiable");
        }

    }
}
