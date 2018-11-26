using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class PageHome
    {

        private const string url = "http://www.turkishairlines.com";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        private IWebElement suggestionsAndDirectionsLink;

        [FindsBy(How = How.XPath, Using = "//div[@id='exploreourbestofferscarousel']//div[@class='carousel-caption']//a")]
        private IWebElement firstcity;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger btn-lg pt-0 pb-0 pr-20 destination-btn-fix']//")]
        private IWebElement buttonResult;


        public IWebElement ExpLink { get { return suggestionsAndDirectionsLink; } }
        public IWebElement FirstCity { get { return firstcity; } }
        public IWebElement ButtonResult { get { return buttonResult; } }

        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement Test_spechialOffer()
        {
            ExpLink.Click();
            FirstCity.Click();
            return ButtonResult;
        }
        
        public string ButtonResultText()
        {
            return buttonResult.Text;
        }
    }
}
