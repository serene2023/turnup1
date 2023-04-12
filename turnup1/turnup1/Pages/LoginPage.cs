using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnup.Pages
{
    public class LoginPage
    {
        public void LoginPage
        {
            
            public void LoginSteps(IWebDriver driver)
            {
            driver.Manage().Window.Maximize();


            // launch the turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f"); // want browser to navigate and go to url in the browser
            Thread.Sleep(1000);

            // user textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));  // ask browser to find element UserName
            usernameTextbox.SendKeys("hari");                                     // type "hari"

            // user password textbox and enter valid user password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));   // ask browser to find element Password
            passwordTextbox.SendKeys("123123");                                   //type "123123"

            // user click on log in button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")); // ask browser to find Xpath for login button
            loginbutton.Click();

            }
                                                                                        
        }
    }
}
