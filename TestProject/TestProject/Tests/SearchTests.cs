using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TestProject.BaseClass;
using TestProject.Pages;


namespace TestProject.BaseClass
{
    
    public class SearchTests : BasePage
    {

        [Description("Searches for Nike shoes then selects the first result no matter the shoe")]
        [Test]
        public void SignInTest()
        {
           var loginPage = new LoginPage(driver);
           loginPage.SignIn();
           //Assert.True(loginPage.submitSignIn.Displayed);
        }

        /*------------------------Search Tests------------------------*/
        [Description("Uses the search bar to navigate to shoes from the searh 'Nike Shoes'")]
        [Test]
        public void NavigateToShoesTest()
        {
            var searchPage = new SearchPage(driver);
            searchPage.NavigateToShoes();
        }

        [Description("Uses the search bar to navigate to shoes from the searh 'Nike Shoes'")]
        [Test]
        public void NavigateToShoesAddRangeTest()
        {
            var searchPage = new SearchPage(driver);
            searchPage.NavigateToShoesAddRange();
        }

        
        [Description("Searches for Nike shoes then selects the first result and adds it to the cart")]
        [Test]
        public void AddShoesToCartTest()
        {
            var searchPage = new SearchPage(driver);
            searchPage.AddShoesToCart();
        }

        [Description("Searches for selenium then selects the first result")]
        [Test]
        public void AddSeleniumToCartTest()
        {
            var searchPage = new SearchPage(driver); 
            searchPage.AddSeleniumToCart();
        }

    }
}