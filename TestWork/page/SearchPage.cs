using FirstTestProject.page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestProject.main
{
    class SearchPage: Actions
    {
        public By FirstLink = By.CssSelector("li:nth-child(1) > .editors-choice > div a");

        public void ClickOnFirstLink()
        {
            GetWebElement(FirstLink).Click();
            
        }
    }
}
