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

        private const string resultText = "Забронировать перелёт";

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
        public void SpecialOffer()
        {
            Assert.IsNotNull(steps.SelectspechialOffer(), "Here is no any data about flight");
            Assert.AreEqual(resultText, steps.ResultText(), "flight status is incorrect");
        }
    }
}
