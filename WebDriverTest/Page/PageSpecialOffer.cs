using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class PageSpecialOffer
    {

        private const string url = "http://www.turkishairlines.com";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[@portselect-id='portTXTMSQ']")]
        private IWebElement fieldDirection;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger bold']//")]
        private IWebElement buttonResult;


        public IWebElement FieldDirection { get { return fieldDirection; } }
        public IWebElement ButtonResult { get { return buttonResult; } }

        public PageSpecialOffer(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public string AutoFieldDirectionResult()
        {

            return FieldDirection.Text;
          
        }
        
        public string ButtonResultText()
        {
            return buttonResult.Text;
        }
    }
}
