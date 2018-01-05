using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumPerformanceTest
{
    class SeleniumPerformanceTest
    {
        static void Main(string[] args)
        {
            Test(new ChromeDriver());
        }

        public static void Test(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com";
        }
    }
}
