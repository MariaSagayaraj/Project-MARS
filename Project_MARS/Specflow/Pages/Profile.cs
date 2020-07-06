using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_MARS.Specflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project_MARS.Specflow.Pages
{
    class Profile : Drivers
    {
        public static IWebElement ProfileTab => driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]"));

        //Languages tab
        public static IWebElement LanguagesTab => driver.FindElement(By.XPath("//a[text()='Languages']"));
        public static IWebElement AddnewLanguageButton => driver.FindElement(By.XPath("//*[contains(@class, 'ui teal button ')]"));
        public static IWebElement AddLanguageText => driver.FindElement(By.XPath("//input[@type='text'][@placeholder='Add Language']"));
        public static IWebElement SelectLanguageLevel => driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
        public static IWebElement AddLanguagebutton => driver.FindElement(By.XPath("//input[@class='ui teal button']"));
        public static IWebElement CancelLanguageButton => driver.FindElement(By.XPath("//input[@class='ui button']"));
        public static IWebElement EditLanguageIcon => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//i[@class='outline write icon']"));
        public static IWebElement EditLanguageText => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public static IWebElement UpdateLanguageButton => driver.FindElement(By.XPath("//input[@class='ui teal button']"));
        public static IWebElement DeleteLanguageButton => driver.FindElement(By.XPath("//i[@class='remove icon']"));


        //Skills tab
        public static IWebElement SkillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public static IWebElement AddnewSkillButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        public static IWebElement AddSkillText => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement SelectSkillLevel => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        public static IWebElement AddSkillbutton => driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[contains(@class,'ui teal button')]"));
        public static IWebElement EditSkillIcon => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']"));
        public static IWebElement EditSkillText => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement UpdateSkillButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//input[@class='ui teal button']"));
        public static IWebElement DeleteSkillButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[1]//tr[1]//td[3]//span[2]//i[1]"));

        //Education Tab
        public static IWebElement EducationTab => driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
        public static IWebElement AddNewEducationButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));
        public static IWebElement UniversityTextBox => driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
        public static IWebElement CountryOfUniversity => driver.FindElement(By.XPath("//select[@name='country']"));
        public static IWebElement Title => driver.FindElement(By.XPath("//select[@name='title']"));
        public static IWebElement Degree => driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
        public static IWebElement YearOfGraduation => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        public static IWebElement AddEducationButton => driver.FindElement(By.XPath("//div[@class='sixteen wide field']//input[contains(@class,'ui teal button')]"));


        //Description
        public static IWebElement DescriptionIcon => driver.FindElement(By.XPath("//i[@class='outline write icon']"));

        public static IWebElement DescriptionText = driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));

        public static IWebElement SaveDescriptionButton => driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][text()='Save']"));



        public static void flashmessage(String data)
        {
            WaitHelpers.waitClickableElement(driver, "XPath", "//div[@class='ns-box-inner']");

            var actual = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            var languageAdd = (data + " " + "has been added to your languages");
            var languageUpdate = (data + " " + "has been updated to your languages");
            var languagedelete = (data + " " + "has been deleted from your languages");

            var skillAdd = (data + " " + "has been added to your skills");
            var skillUpdate = (data + " " + "has been updated to your skills");
            var skilldelete = (data + " " + "has been deleted");


            if (actual == languageAdd)
            {
                Assert.Pass();
                Console.WriteLine(data + "has been added to your languages");
                return;
            }
            else if (actual == languageUpdate)
            {
                Assert.Pass();
                Console.WriteLine(data + "has been updated to your languages");
                return;
            }
            else if (actual == languagedelete)
            {
                Assert.Pass();
                Console.WriteLine(data + "has been deleted from your languages");
                return;
            }
            else if (actual == skillAdd)
            {
                Assert.Pass();
                Console.WriteLine(data + "has been added to your skills");
                return;
            }
            else if (actual == skillUpdate)
            {
                Assert.Pass();
                Console.WriteLine(data + "has been updated to your skills");
                return;
            }
            else if (actual == skilldelete)
            {
                Assert.Pass();
                Console.WriteLine(data + "has been deleted");
                return;
            }

            else
            {
                Assert.Fail();
            }

        }

        public static void LanguageUpdate(String language, String editLanguage)
        {
            for (int i = 1; i > 0; i++)
            {
                var languageList = driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / section[2] / div[1] / div[1] / div[1] / div[3] / form[1] / div[2] / div[1] / div[2] / div[1] / table[1] / tbody[" + i + "] / tr[1] / td[1]")).Text;

                //logic to select the language we need to update
                if (languageList == language)
                {
                    driver.FindElement(By.XPath("//tbody[" + i + "]//tr[1]//td[3]//span[1]//i[1]")).Click();
                    EditLanguageText.Clear();
                    EditLanguageText.SendKeys(editLanguage);
                    return;
                }
            }


        }

        public static void LanguageDelete(String deletelanguage)
        {
            for (int i = 1; i > 0; i++)
            {
                var languageList = driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / section[2] / div[1] / div[1] / div[1] / div[3] / form[1] / div[2] / div[1] / div[2] / div[1] / table[1] / tbody[" + i + "] / tr[1] / td[1]")).Text;

                //logic to select the language we need to update
                if (languageList == deletelanguage)
                {
                    driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[" + i + "]//tr[1]//td[3]//span[2]//i[1]")).Click();
                    return;
                }
            }

        }

        public static void SkillUpdate(String skill, String editSkill)
        {
            for (int i = 1; i > 0; i++)
            {
                var skillList = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[" + i + "]/tr[1]/td[1]")).Text;

                //logic to select the language we need to update
                if (skillList == skill)
                {
                    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[" + i + "]/tr[1]/td[3]/span[1]/i[1]")).Click();
                    EditSkillText.Clear();
                    EditSkillText.SendKeys(editSkill);
                    return;
                }
            }


        }

        public static void SkillDelete(String deleteskill)
        {
            for (int i = 1; i > 0; i++)
            {
                var SkillList = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[" + i + "]/tr[1]/td[1]")).Text;

                //logic to select the language we need to update
                if (SkillList == deleteskill)
                {
                    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[" + i + "]/tr[1]/td[3]/span[2]/i[1]")).Click();
                    return;
                }
            }
        }
    }
}
