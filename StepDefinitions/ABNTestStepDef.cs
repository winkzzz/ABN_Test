using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ABN_Test.StepDefinitions
{
    [Binding]
    public sealed class ABNTestStepDef
    {
        private IWebDriver driver;

        public ABNTestStepDef(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given("I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            //do nothing
        }

        [When("Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://abr.business.gov.au/";
        }

        [Then("ABN Lookup page is open")]
        public void ThenABNLookupPageIsOpen()
        {
            driver.FindElement(By.Id("HyperlinkHomeHeader"));
            Thread.Sleep(5000);
            //driver.Quit();
        }

    }
}
