using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInitialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\paul\seleniumLibraries");
            string googleUrl = @"https://www.google.com/";
            driver.Url = googleUrl;

            // This is a test
            var num = 10;
        }
    }
}
