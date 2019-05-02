﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject.main
{
    static class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver Instance()
        {
            if (driver == null)

            driver = new InternetExplorerDriver();
            return driver;
        }

        static public void Destroy()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
