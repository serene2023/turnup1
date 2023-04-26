using turnup.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using turnup.Tests;




namespace turnup.Utilities
{
    public class CommonDriver
    {
        
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }


        [OneTimeTearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}
