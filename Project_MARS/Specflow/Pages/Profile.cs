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


    }
}
