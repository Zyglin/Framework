using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class HomePage
    {

        private const string url = "http://www.turkishairlines.com";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        private IWebElement suggestionsAndDirectionsLink;

        public IWebElement SuggestionsAndDirectionsLink { get { return suggestionsAndDirectionsLink; } }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnTheSuggestionsAndDirectionsLink()
        {
            SuggestionsAndDirectionsLink.Click();          
        }
    }
}
