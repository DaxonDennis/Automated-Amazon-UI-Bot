using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TestProject.BaseClass;
using TestProject.Pages;


namespace TestProject.BaseClass
{

    public class BurgerMenuTests : BasePage
    {

        [Description("Tests the functionality of the Hamburger menu")]
        [Test]
        public void HamburgerMenuTest()
        {
            var burgerMenuPage = new BurgerMenuPage(driver);
            burgerMenuPage.AllHamBurgerMenu.Click();
        }

        /*------------------------Trending------------------------*/
        [Description("Tests the functionality of the Best Sellers button in the Hamburger menu then selects the number one option")]
        [Test]
        public void BestSellersBurgerMenuTest()
        {
            var burgerMenuPage = new BurgerMenuPage(driver);
            burgerMenuPage.BestSellersMenu();
        }
        
        [Description("Tests the functionality of the Best Sellers button in the Hamburger menu then selects the number one option")]
        [Test]
        public void NewReleasesBurgerMenuTest()
        {
            var burgerMenuPage = new BurgerMenuPage(driver);
            burgerMenuPage.NewReleasesMenu();
        }

        [Description("Tests the functionality of the Best Sellers button in the Hamburger menu")]
        [Test]
        public void MoversandShakersMenuTest()
        {
            var burgerMenuPage = new BurgerMenuPage(driver);
            burgerMenuPage.MoversAndShakersMenu();
        }

        /*------------------------Digital Content & Devices------------------------*/
        [Description("Tests the functionality of the Hamburger menu")]
        [Test]
        public void MenuPrimeVideoTest()
        {
            var burgerMenuPage = new BurgerMenuPage(driver);
            burgerMenuPage.PrimeVideoPath();
        }

        [Description("Tests the functionality of the Hamburger menu")]
        [Test]
        public void MeEchoAndAkTest()
        {
            var burgerMenuPage = new BurgerMenuPage(driver);
            burgerMenuPage.PrimeVideoPath();
        }
    }
}
