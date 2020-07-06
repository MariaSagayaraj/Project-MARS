using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Project_MARS.Hookup
{
    [Binding]
    public class LanguageSteps : Drivers
    {
        [Given(@"I click on the Language tab")]
        public void GivenIClickOnTheLanguageTab()
        {
            Profile.LanguagesTab.Click();
        }

        [Given(@"I click on Add New button of Language tab")]
        public void GivenIClickOnAddNewButtonOfLanguageTab()
        {
            Profile.AddnewLanguageButton.Click();
        }

        [Given(@"I enter the language details (.*),(.*)")]
        public void GivenIEnterTheLanguageDetails(string language, string languagelevel)
        {

            Profile.AddLanguageText.SendKeys(language);
            SelectElement selectElement = new SelectElement(Profile.SelectLanguageLevel);
            selectElement.SelectByText(languagelevel);
        }


        [Given(@"I edit the language details (.*),(.*)")]
        public void GivenIEditTheLanguageDetails(string language, string editLanguage)
        {
            Profile.LanguageUpdate(language, editLanguage);

        }

        [Given(@"I click on Delete button of Language tab (.*)")]
        public void GivenIClickOnDeleteButtonOfLanguageTab(string deletelanguage)
        {
            Profile.LanguageDelete(deletelanguage);
        }

        [When(@"I click on Add button of Language tab")]
        public void ThenIClickOnAddButtonOfLanguageTab()
        {
            Profile.AddLanguagebutton.Click();
        }

        [Then(@"I validate that the new language has been added successfully (.*)")]
        public void ThenIValidateThatTheNewLanguageHasBeenAddedSuccessfully(string language)
        {
            Profile.flashmessage(language);
        }

        [When(@"I click on the Update button of Language tab")]
        public void ThenIClickOnTheUpdateButtonOfLanguageTab()
        {
            Profile.UpdateLanguageButton.Click();
        }

        [Then(@"I validate that the language has been edited successfully (.*)")]
        public void ThenIValidateThatTheLanguageHasBeenEditedSuccessfully(string Editlanguage)
        {

            Profile.flashmessage(Editlanguage);
        }

        [Then(@"I validate that the language has been deleted successfully (.*)")]
        public void ThenIValidateThatTheLanguageHasBeenDeletedSuccessfully(string deletelanguage)
        {
            Profile.flashmessage(deletelanguage);
        }

    }
}

