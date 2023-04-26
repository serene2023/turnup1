using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnup.Utilities;
using NUnit.Framework;
using turnup.Pages;
using turnup.Tests;



namespace turnup.Pages
{
    public class LoginPage : CommonDriver
    {
        public void LoginSteps(IWebDriver driver)
            {
            
            driver.Manage().Window.Maximize();

            Thread.Sleep(4000);
            // launch turn up portal 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
           

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // indentify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // indentify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
           // Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"loginForm\"]/form/div[3]/input[1]", 10);
            }

    }
}

