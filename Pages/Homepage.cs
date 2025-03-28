using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ABN_Test.Pages
{
    internal class Homepage
    {
        private IWebDriver driver;

        public Homepage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //Elements for ABN Lookup homepage can be added here
        By ABNLookUpIcon = By.Id("HyperlinkHomeHeader");
        By ABNHeaderPage = By.Id("header");
        By ABNSearchText = By.Id("SearchText");
        By ABNSearchButton = By.Id("MainSearchButton");
        By ABNHomeButton = By.Id("HyperlinkHomeTop");
        By ABNSeachDropdown = By.XPath("//a[contains(@class, 'nav-icon-down') and text() = 'Search']");
        By ABNToolsAndResourcesDropdown = By.XPath("//a[contains(@class, 'nav-icon-down') and text() = 'Tools & resources']");
        By ABNHelpDropdown = By.XPath("//a[contains(@class, 'nav-icon-down') and text() = 'Help']");
        By ABNFooter = By.XPath("//div[contains(@class, 'footer-nav')]");
        By AdvanceSearch = By.XPath("//a[contains(@href, '/Search/Advanced')]");

        public void ValidaeABNLookupIcon()
        {
            bool ABNLookupIconDisplayed = driver.FindElement(ABNLookUpIcon).Displayed; 
        }
            
        public void ValidateABNLookupDashboard()
        {
            bool ABNHeaderPageDisplayed = driver.FindElement(ABNHeaderPage).Displayed;
            bool ABNSearchTextDisplayed = driver.FindElement(ABNSearchText).Displayed;
            bool ABNSearchButtonDisplayed = driver.FindElement(ABNSearchButton).Displayed;
            bool ABNHomeButtonDisplayed = driver.FindElement(ABNHomeButton).Displayed;
            bool ABNSeachDropdownDisplayed = driver.FindElement(ABNSeachDropdown).Displayed;
            bool ABNToolsAndResourcesDropdownDisplayed = driver.FindElement(ABNToolsAndResourcesDropdown).Displayed;
            bool ABNHelpDropdownDisplayed = driver.FindElement(ABNHelpDropdown).Displayed;
            bool ABNFooterDisplayed = driver.FindElement(ABNFooter).Displayed;
        }

        public void SearchABN(string text)
        {
            driver.FindElement(ABNSearchText).SendKeys(text);
            driver.FindElement(ABNSearchButton).Click();
            Thread.Sleep(500);
        }

        public void OpenAdvanceSearchPage()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(ABNSeachDropdown)).Perform();

            driver.FindElement(AdvanceSearch).Click();
        }
    }
}
