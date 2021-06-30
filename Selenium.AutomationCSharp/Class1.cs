using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium.AutomationCSharp
{
    public class Class1
    {

        [Test]
        public void invokeBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://facebook.com");
            driver.Manage().Window.Maximize();
            //hello

        }
    }
}
