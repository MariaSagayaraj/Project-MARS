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
    public class SkillsSteps : Drivers
    {
        [Given(@"I click on the skills tab")]
        public void GivenIClickOnTheSkillsTab()
        {
            Profile.SkillsTab.Click();
        }

        [Given(@"I click on Add New button of skills tab")]
        public void GivenIClickOnAddNewButtonofskillstab()
        {
            
            Profile.AddnewSkillButton.Click();
        }

        [Given(@"I enter the skill details (.*),(.*)")]
        public void GivenIEnterTheSkillDetails(string skill, string skilllevel)
        {
            
            Profile.AddSkillText.SendKeys(skill);
            SelectElement selectElement = new SelectElement(Profile.SelectSkillLevel);
            selectElement.SelectByText(skilllevel);
        }

        [Given(@"I click on Edit button of skills tab")]
        public void GivenIClickOnEditButtonofskillstab()
        {
            Profile.EditSkillIcon.Click();
        }

        [Given(@"I edit the skill details (.*)")]
        public void GivenIEditTheSkillDetails(string EditSkill)
        {
            
            Profile.EditSkillText.Clear();
            Profile.EditSkillText.SendKeys(EditSkill);
        }

        [Given(@"I click on Delete button of skills tab")]
        public void GivenIClickOnDeleteButtonofskillstab()
        {
            
            Profile.DeleteSkillButton.Click();
        }

        [Then(@"I click on Add button of skills tab")]
        public void ThenIClickOnAddButtonofskillstab()
        {
            Profile.AddSkillbutton.Click();
        }

        [Then(@"I validate that the new skill has been added successfully (.*)")]
        public void ThenIValidateThatTheNewSkillHasBeenAddedSuccessfully(string skill)
        {
            //verify the success confirmation from the flash message
            WaitHelpers.waitClickableElement(driver, "XPath", "//div[@class='ns-box-inner']");
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            try
            {
                
                Assert.IsTrue(message.Text.Contains(skill + " " + "has been added to your skills"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [Then(@"I click on the Update button of skills tab")]
        public void ThenIClickOnTheUpdateButtonofskillstab()
        {
            Profile.UpdateSkillButton.Click();
        }

        [Then(@"I validate that the skill has been edited successfully (.*)")]
        public void ThenIValidateThatTheSkillHasBeenEditedSuccessfully(string EditSkill)
        {
            //verify the success confirmation from the flash message
            WaitHelpers.waitClickableElement(driver, "XPath", "//div[@class='ns-box-inner']");
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                //TurnOnWait();
                Assert.IsTrue(message.Contains(EditSkill + " " + "has been updated to your skills"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [Then(@"I validate that the skill has been deleted successfully")]
        public void ThenIValidateThatTheSkillHasBeenDeletedSuccessfully()
        {
            //verify the success confirmation from the flash message
            WaitHelpers.waitClickableElement(driver, "XPath", "//div[@class='ns-box-inner']");
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                //TurnOnWait();
                Assert.IsTrue(message.Contains("has been deleted"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
    }
}

