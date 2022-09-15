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
    public class SearchPage
    {
        IWebDriver driver;
        WebDriverWait searchPage;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            searchPage = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /*------------------------Elements------------------------*/
        [FindsBy(How=How.Name,Using = "field-keywords")]  public IWebElement SearchTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")] public IWebElement SearchButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@cel_widget_id='MAIN-SEARCH_RESULTS-2']")] public IWebElement FirstOption { get; set; }
        [FindsBy(How = How.Id, Using = "dropdown_selected_size_name")] public IWebElement SelectSize { get; set; }
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]  public IWebElement AddToCartButton { get; set; }
        [FindsBy(How = How.Id, Using = "rcx-subscribe-submit-button-announce")] public IWebElement SetUpNowButton { get; set; }
        [FindsBy(How = How.Id, Using = "size_name_7")] public IWebElement SizeSelection { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), '$50 to $100')]")] public IWebElement Range { get; set; }


        /*------------------------Methods------------------------*/
        public void NavigateToShoes()
        {
            SearchTextBox.SendKeys("Nike Shoes");
            SearchButton.Click();
            searchPage.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@cel_widget_id='MAIN-SEARCH_RESULTS-2']")));
            Assert.IsTrue(FirstOption.Displayed);
        }

        public void NavigateToShoesAddRange()
        {
            SearchTextBox.SendKeys("Nike Shoes");
            SearchButton.Click();
            Range.Click();
            searchPage.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@cel_widget_id='MAIN-SEARCH_RESULTS-2']")));
            Assert.IsTrue(FirstOption.Displayed);
        }

        public void AddShoesToCart()
        {
            SearchTextBox.SendKeys("Mens Vans");
            SearchButton.Click();
            FirstOption.Click();
            SelectSize.Click();
            SizeSelection.Click();
            Thread.Sleep(2000);
            AddToCartButton.Click();
        }

        public void AddSeleniumToCart()
        {
            SearchTextBox.SendKeys("Selenium");
            SearchButton.Click();
            FirstOption.Click();
            Thread.Sleep(2000);
            //homeWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("rcx-subscribe-submit-button-announce")));
            SetUpNowButton.Click();
        }
    }
}
