using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using Reqnroll.BoDi;

namespace ABN_Test.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@TestTagExample")]
        public void BeforeScenarioWithTag()
        {
           //edit the tag to add methods before the scenario tag
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver != null) 
            {
                driver.Quit();
            }
        }
    }
}