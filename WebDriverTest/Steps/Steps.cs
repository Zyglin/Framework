using Framework.Page;
using OpenQA.Selenium;

namespace Framework
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Instance.GetInstance();
        }

        public void CloseBrowser()
        {
            Instance.CloseBrowser();
        }

        public void SelectSuggestionsAndDirectionsLink()
        {
            HomePage selectPage = new HomePage(driver);
            selectPage.OpenPage();
            selectPage.ClickOnTheSuggestionsAndDirectionsLink();
        }

        public string AutomaticTextAppearance()
        {
            SpecialOfferPage selectPage = new SpecialOfferPage(driver);
            return selectPage.AutoFieldDirectionResult();
        }

        public void SelectnIstanbulToBook()
        {
            SpecialOfferPage selectPage = new SpecialOfferPage(driver);
            selectPage.ClickOnIstanbulToBook();
        }

        public string InformationAboutCity()
        {
            InformationAboutCityAndBookTicketPage selectPage = new InformationAboutCityAndBookTicketPage(driver);
            return selectPage.InformationAboutCityWhereBookTicket.Text;
        }

        public string InformationButtonBookTicketText()
        {
            InformationAboutCityAndBookTicketPage selectPage = new InformationAboutCityAndBookTicketPage(driver);
            return selectPage.ButtonBookTicket.Text;
        }
    }
}

