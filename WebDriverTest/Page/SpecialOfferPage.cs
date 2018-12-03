﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class SpecialOfferPage
    {

        private const string url = "http://www.turkishairlines.com";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[@portselect-id='portTXTMSQ']")]
        private IWebElement fieldDirection;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger bold']//")]
        private IWebElement buttonBookIstambul;

        public IWebElement FieldDirection { get { return fieldDirection; } }
        public IWebElement ButtonBookIstambul { get { return buttonBookIstambul; } }

        public SpecialOfferPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public string AutoFieldDirectionResult()
        {
            return FieldDirection.Text;          
        }
        
        public void ClickOnIstanbulToBook()
        {
            buttonBookIstambul.Click();
        }
    }
}
