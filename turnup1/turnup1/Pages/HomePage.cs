using OpenQA.Selenium;
using NUnit.Framework;
using turnup.Utilities;
using turnup.Pages;
using turnup.Tests;


namespace turnup.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            IWebElement admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admin.Click();

            
            //Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

         public void GoToEmployeePage(IWebDriver driver)
        {
            // code to navigate to Employee page
        }
    }
}
