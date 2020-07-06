using NUnit.Framework;
using OpenQA.Selenium;
using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace Project_MARS.Feature
{
    [Binding]
    public class SignInSteps : Drivers
    {
        [Given(@"Web browser is opened")]
        public void GivenWebBrowserIsOpened()
        {
            Initialize();
        }

        [Given(@"I Navigate to the portal")]
        public void GivenINavigateToThePortal()
        {
            NavigateUrl();
        }

        [When(@"I enter user credentials and press Login button (.*),(.*)")]
        public void GivenIEnterUserCredentialsAndPressLoginButton(string username, string password)
        {
            SignIn.Login(username, password);
        }

        [Then(@"I validate that I logged into the portal successfully")]
        public void ThenIvalidateThatILoggedIntoThePortalSuccessfully()
        {
            WaitHelpers.waitClickableElement(driver, "XPath", "//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]");
            Assert.That(Drivers.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]")).Text, Is.EqualTo("Profile"));
        }
    }
}
