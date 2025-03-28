using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ABN_Test.Pages
{
    internal class SearchResult
    {
        private IWebDriver driver;

        public SearchResult(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //Elements for Search Result page can be added here
        By ABNHomeButton = By.Id("HyperlinkHomeTop");
        By ABNSeachDropdown = By.XPath("//a[contains(@class, 'nav-icon-down') and text() = 'Search']");
        By ABNToolsAndResourcesDropdown = By.XPath("//a[contains(@class, 'nav-icon-down') and text() = 'Tools & resources']");
        By ABNHelpDropdown = By.XPath("//a[contains(@class, 'nav-icon-down') and text() = 'Help']");
        By ABNFooter = By.XPath("//div[contains(@class, 'footer-nav')]");
        By ABNTableResult = By.XPath("//div[contains(@class, 'table-wrapper')]");
        By ABNErrorResult = By.XPath("//div[contains(@class, 'process-message')]");
        By ABNFiableNumber = By.XPath("//a[contains(text(), '36 629 615 390')]");

        public void ValidSearchResultPage()
        {
            Assert.True(driver.FindElement(ABNHomeButton).Displayed);
            Assert.True(driver.FindElement(ABNSeachDropdown).Displayed);
            Assert.True(driver.FindElement(ABNToolsAndResourcesDropdown).Displayed);
            Assert.True(driver.FindElement(ABNHelpDropdown).Displayed);
            Assert.True(driver.FindElement(ABNFooter).Displayed);
            Assert.True(driver.FindElement(ABNTableResult).Displayed);
            Assert.True(driver.FindElement(ABNFiableNumber).Displayed);
        }

        public void InvalidSearchResultPage()
        {
            Assert.True(driver.FindElement(ABNErrorResult).Displayed);
        }

        public void OpenFiableABN()
        {
            driver.FindElement(ABNFiableNumber).Click();
        }
    }
}
