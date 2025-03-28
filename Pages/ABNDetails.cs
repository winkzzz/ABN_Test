using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ABN_Test.Pages
{
    internal class ABNDetails
    {
        private IWebDriver driver;

        public ABNDetails(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //Elements for ABN Details page can be added here
        By ABNResultTable = By.XPath("//div[contains(@class, 'container-content')]");
        By ABNEntityName = By.XPath("//span[contains(@itemprop, 'legalName')]");
        By ABNStatus = By.XPath("//td[contains(text(), 'Active from')]");
        By ABNEntityType = By.XPath("//a[contains(@href, '/Help/EntityTypeDescription?Id=00019')]");
        By ABNGoodServiceTax = By.XPath("//td[contains(text(), 'Registered from')]");
        By ABNBusinessLocation = By.XPath("//span[contains(@itemprop, 'addressLocality')]");

        public void ValidateABNResultPage()
        {
            bool ABNResultTableDisplayed = driver.FindElement(ABNResultTable).Displayed;

            string ABNEntityNameText = driver.FindElement(ABNEntityName).Text;
            string ABNStatusText = driver.FindElement(ABNStatus).Text;
            string ABNEntityTypeText = driver.FindElement(ABNEntityType).Text;
            string ABNGoodServiceTaxText = driver.FindElement(ABNGoodServiceTax).Text;
            string ABNBusinessLocationText = driver.FindElement(ABNBusinessLocation).Text;

            Assert.AreEqual(ABNEntityNameText, "FIABLE PTY LTD");
            Assert.AreEqual(ABNStatusText, "Active from 25 Oct 2018");
            Assert.AreEqual(ABNEntityTypeText, "Australian Private Company");
            Assert.AreEqual(ABNGoodServiceTaxText, "Registered from 25 Oct 2018");
            Assert.AreEqual(ABNBusinessLocationText, "NSW 2232");
        }
    }
}
