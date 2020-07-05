using NUnit.Framework;
using OpenQA.Selenium;
using Project_MARS.Specflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_MARS.Specflow.Pages
{
    class SignIn
    {
        public static void Login(String username, String password)
        {
           //Clicking SignIn button
            Drivers.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

            //Enter Username
            Drivers.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys(username);

            //Enter Password
            Drivers.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys(password);

            //Clicking Login Button
            Drivers.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }
    }
}
