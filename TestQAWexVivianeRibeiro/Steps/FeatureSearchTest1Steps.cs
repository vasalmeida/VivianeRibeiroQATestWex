using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestQAWexVivianeRibeiro.PO;

namespace TestQAWexVivianeRibeiro
{
    [Binding]
    public class FeatureSearchTest1Steps
    {
        IWebDriver driver;
        POSearch _search;
        public FeatureSearchTest1Steps()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I navigate to the website (.*)")]
        public void GivenINavigateToTheWebsite(string url)
        {
            driver.Url = url;
        }

        [Given(@"I navigate in the Search section (.*)")]
        public void GivenINavigateInTheSearchSection(string section)
        {
            _search = new POSearch(driver);
            _search.SearchTermClick();
        }
        
        [Given(@"I navigate on a filter at Combo Box")]
        public void GivenINavigateOnAFilterAtComboBox()
        {
            _search = new POSearch(driver);
            _search.SearchTermCombo();
        }
        
        [Given(@"I choose filter about Corporate Payments")]
        public void GivenIChooseFilterAboutCorporatePayments()
        {
            _search = new POSearch(driver);
            _search.ChooseTerm(driver);
        }
        
        [Given(@"I click Enter without a Search Item")]
        public void GivenIClickEnterWithoutASearchItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the alert Please enter a search term are displayed")]
        public void ThenTheAlertPleaseEnterASearchTermAreDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
