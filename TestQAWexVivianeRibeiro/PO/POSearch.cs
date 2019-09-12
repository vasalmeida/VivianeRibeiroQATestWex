using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace TestQAWexVivianeRibeiro.PO
{
    class POSearch
    {
        public POSearch(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='search_term_string']")]
        private IWebElement _searchTerm;

        [FindsBy(How = How.XPath, Using = "//input[@name='wex-searchPanel']")]
        private IWebElement _searchTermCombo;
        
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'..item...') and contains(text(),'Corporate Payments')]")]
        private IWebElement _chooseTerm;

        [FindsBy(How = How.XPath, Using = "//input[@name='Enter']")]
        private IWebElement _enterKey;

        public void SearchTermClick()
        {           
                _searchTerm.Click();
        }

        public void SearchTermCombo()
        {
            _searchTermCombo.FindElement(By.Id("wex-searchPanel"));
        }
        
        public void ChooseTerm(IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(_chooseTerm);
            actions.Perform();
            Thread.Sleep(360);
            driver.FindElement(By.LinkText("")).Click();
        }

        public void EnterKey()
        {
            _enterKey.Click();
        }
    }
}