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
    class BurgerMenuPage
    {
        IWebDriver driver;
        public BurgerMenuPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /*------------------------Elements------------------------*/
        [FindsBy(How = How.Id, Using = "nav-hamburger-menu")] public IWebElement AllHamBurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='hmenu-container']//ul[@class='hmenu hmenu-visible']//a[contains(text(), 'Best Sellers')]")] public IWebElement BestSellers { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='hmenu-container']//ul[@class='hmenu hmenu-visible']//a[contains(text(), 'New Releases')]")] public IWebElement NewReleases { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='hmenu-container']//ul[@class='hmenu hmenu-visible']//a[contains(text(), 'Movers & Shakers')]")] public IWebElement MoversAndShakers { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='2']")] public IWebElement PrimeVideoButton_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='3']")] public IWebElement AmazonMusic_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='4']")] public IWebElement EchoAndAlexa_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='5']")] public IWebElement FireTablets_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='6']")] public IWebElement FireTv_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='7']")] public IWebElement KindleEReadersAndBooks_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='8']")] public IWebElement AudibleBooksAndOriginals_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='9']")] public IWebElement AmazonPhotos_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='10']")] public IWebElement AppstoreForAndroid_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-menu-id='11']")] public IWebElement AWSCourses_BurgerMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='anonCarousel1']//li[@class='a-carousel-card']")] public IWebElement NumberoneBestSeller { get; set; }
        [FindsBy(How = How.Id, Using = "add-to-cart-button")] public IWebElement AddToCartButton { get; set; }



        /*------------------------Methods------------------------*/
        public void BestSellersMenu()
        {
            AllHamBurgerMenu.Click();
            BestSellers.Click();
            NumberoneBestSeller.Click();
            Assert.IsTrue(AllHamBurgerMenu.Displayed);
        }

        public void NewReleasesMenu()
        {
            AllHamBurgerMenu.Click();
            NewReleases.Click();
            NumberoneBestSeller.Click();
        }

        public void MoversAndShakersMenu()
        {
            AllHamBurgerMenu.Click();
            MoversAndShakers.Click();
            NumberoneBestSeller.Click();
        }

        public void PrimeVideoPath()
        {
            AllHamBurgerMenu.Click();
            PrimeVideoButton_BurgerMenu.Click();
        }

        public void EchoAndAlexaPath()
        {
            AllHamBurgerMenu.Click();
            EchoAndAlexa_BurgerMenu.Click();
        }

    }
}
