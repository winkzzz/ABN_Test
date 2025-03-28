using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace ABN_Test.Pages
{
    internal class AdvanceSearch
    {
        private IWebDriver driver;

        public AdvanceSearch(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //Elements for Advance Search page can be added here
        By SearchTextBox = By.Id("SearchParameters_SearchText");
        By SearchButton = By.XPath("//input[contains(@class, 'default button-submit')]");

        public void FiableAdvanceSearch(string text)
        {
            driver.FindElement(SearchTextBox).SendKeys(text);
            driver.FindElement(SearchButton).Click();
        }
    }
}
