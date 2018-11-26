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
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            selectPage.ClickOnTheSuggestionsAndDirectionsLink();
        }

        public string AutomaticTextAppearance()
        {
            PageSpecialOffer selectPage = new PageSpecialOffer(driver);
            return selectPage.AutoFieldDirectionResult();
        }

        public void SelectnIstanbulToBook()
        {
            PageSpecialOffer selectPage = new PageSpecialOffer(driver);
            selectPage.ClickOnIstanbulToBook();
        }

        public string InformationAboutCity()
        {
            PageInformationAboutCityAndBookTicket selectPage = new PageInformationAboutCityAndBookTicket(driver);
            return selectPage.InformationAboutCityWhereBookTicket.Text;
        }

        public string InformationButtonBookTicketText()
        {
            PageInformationAboutCityAndBookTicket selectPage = new PageInformationAboutCityAndBookTicket(driver);
            return selectPage.ButtonBookTicket.Text;
        }
    }
}

