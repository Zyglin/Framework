using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Automation
{
    [TestFixture]
    class Automation
    {
        private Steps steps = new Steps();

        private const string fieldDirectionText = "Аэропорт Минск наци...";
        private const string informationTextAboutCityWhereBookTicket = "Cтамбул,Турция";
        private const string bookTickertext = " Забронировать перелёт";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void  PopularSpecialOffer()
        {
            steps.SelectSuggestionsAndDirectionsLink();
            Assert.AreEqual(fieldDirectionText, steps.AutomaticTextAppearance());     
        }

        [Test]
        public void ThereIsInformationAboutTheCityAndTheOpportunityToBookaTicket()
        {
            steps.SelectnIstanbulToBook();
            Assert.AreEqual(informationTextAboutCityWhereBookTicket, steps.InformationAboutCity());
            Assert.AreEqual(bookTickertext, steps.InformationButtonBookTicketText());
        }
    }
}
