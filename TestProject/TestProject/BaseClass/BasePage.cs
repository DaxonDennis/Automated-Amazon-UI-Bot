using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject.Pages;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Remote;

namespace TestProject.BaseClass 
{
    public class BasePage
    {
        public static IWebDriver driver = new ChromeDriver();

        //public static IWebDriver driver = null;


        [SetUp]
        public void Open()
        {
            var chromeOptions = new ChromeOptions();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);          
            driver.Navigate().GoToUrl("https://www.amazon.com/");
        }
       
        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    } 
}

