using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class InformationAboutCityAndBookTicketPage
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//h1[@class='fs-60 pt-0 mt-0 mb-30 1h-55']//")]
        private IWebElement informationAboutCityWhereBookTicket;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger btn-lg pt-0 pb-0 pr-20 destination-btn-fix']//")]
        private IWebElement buttonBookTicket;


        public IWebElement InformationAboutCityWhereBookTicket { get { return informationAboutCityWhereBookTicket; } }
        public IWebElement ButtonBookTicket { get { return buttonBookTicket; } }

        public InformationAboutCityAndBookTicketPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public string InformationInWhichCityWeBookTicketsText()
        {
          
            return InformationAboutCityWhereBookTicket.Text;
        }
        
        public string GettingTheTextOftheButtonToBookaFlight()
        {
            return ButtonBookTicket.Text;
        }
    }
}
