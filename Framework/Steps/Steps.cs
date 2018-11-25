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

        public IWebElement SelectspechialOffer()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            return selectPage.Test_spechialOffer();
        }

        public string ResultText()
        {
            PageHome mainpage = new PageHome(driver);
            return mainpage.ButtonResultText();
        }
    }
}

