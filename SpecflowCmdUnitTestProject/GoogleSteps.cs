using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowUnitTestProject
{
    [Binding]
    public class GoogleSteps
    {
        private static IWebDriver _driver; 

        public GoogleSteps()
        {
            _driver =  new ChromeDriver(@"C:\Users\CLYDE\source\repos\SpecflowCmdUnitTest\SpecflowCmdUnitTestProject\packages\Selenium.Chrome.WebDriver.75.0.0\driver\");
        }

        [Given(@"I am on the google page for ""(.*)""")]
        public void GivenIAmOnTheGooglePage(string website)
        { 
            _driver.Navigate().GoToUrl(website);
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string keyword)
        {
            var q = _driver.FindElement(By.Name("q"));
            q.SendKeys(keyword);
            q.Submit();
        }

        [Then(@"I should see title ""(.*)""")]
        public void ThenIShouldSeeTitle(string title)
        {
            Assert.That(_driver.Title, Is.EqualTo(title));
        }

        //[AfterTestRun]
        //[TearDown]
        [AfterScenario]
        public static void CloseBrowser()
        {
            _driver.Quit();
        }
    }
}
