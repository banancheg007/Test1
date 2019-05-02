using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FirstTestProject.main;
using NUnit.Framework;

namespace FirstTestProject.test
{
    [TestFixture]
    class SmokeTests
    {
        MainPage mainPage;
        SearchPage searchPage;

        [SetUp]
        public void BeforeTest()
        {
            mainPage = new MainPage();
            searchPage = new SearchPage();
        }

        [TearDown]
        public void AfterTest()
        {
            Driver.Destroy();
        }

        [Test]
        public void SearchTest()

        {
            mainPage.OpenStartUrl();
            mainPage.SearchByKeyword();
            searchPage.ClickOnFirstLink();
        }
    }
}
