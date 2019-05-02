using FirstTestProject.page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject.main
{
    class MainPage : Actions
    {
        public By SearchField = By.Id("orb-search-q");

        public void OpenStartUrl()
        {
            Navigate(Constants.SITE_URL);
        }

        public void SearchByKeyword()
        {
            GetWebElement(SearchField).SendKeys(Constants.KEYWORD);
            GetWebElement(SearchField).Submit();
        }
    }
}
