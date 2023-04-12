using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnup.Utilities;

namespace turnup.Pages
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
        {
        IWebElement directory = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        directory.Click();
        Wait.WaitForElement(driver, "XPath", XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"), 7);

        //Navigate to new time material
        IWebElement newTm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        newTm.Click();
        }
    }
}
