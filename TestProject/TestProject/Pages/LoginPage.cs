using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /*------------------------Elements------------------------*/
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Hello, Sign in')]")] public IWebElement signInButton { get; set; }
        [FindsBy(How = How.Name, Using = "email")] public IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "continue")] public IWebElement ContinueButton { get; set; }
        [FindsBy(How = How.Id, Using = "ap_password")] public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "signInSubmit")] public IWebElement SubmitSignIn { get; set; }

        /*------------------------Methods------------------------*/
        public void SignIn()
        {
            signInButton.Click();
            EmailTextBox.SendKeys("JohnDoe@gmail.com");
            ContinueButton.Click();
            Password.SendKeys("password");
            SubmitSignIn.Click();
            
        }

        
    }
}
