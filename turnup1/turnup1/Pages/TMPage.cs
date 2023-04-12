using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnup.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            //Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // select Time option from dropdown
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            dropdown.Click();

            //Select Time option from dropdown
            IWebElement selectTimeOption = driver.FindElement(By.Id("TypeCode_option_selected == Time"));
            selectTimeOption.Click();

            //type code into code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("hari2023");

            //type description into description textbox
            IWebElement descrptionTextbox = driver.FindElement(By.Id("Description"));
            descrptionTextbox.SendKeys("harihari2023");

            //type price per unit into price per unit textbox
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("30");

            //click on Save button 
            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();

            // check if new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "hari2023")
            {
                Console.WriteLine("New record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Record hasn't been created.");
            }
        }
        public void EditTM(IWebDriver driver)
        {
        // Edit Record
        // Go to last page to find record

        IWebElement editLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editLastPageButton.Click();

            //IWebElement findRecordToEdit = driver.FindElement(By.XPath("//*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[1]");  //find hari2023
            IWebElement editPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            editPageButton.Click();

            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            editPriceTextbox.SendKeys("50");

            IWebElement saveEditButton = driver.FindElement(By.Id("SaveButton"));
            saveEditButton.Click();
        }
        public void DeleteTM(IWebDriver driver) 
        {
            //delete Record hari2023

            IWebElement goToDeleteLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToDeleteLastPage.Click();

            //Find hari2023 record to delete
            IWebElement clickOnDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[2]"));
            clickOnDeleteButton.Click();

            IWebElement clickOKToDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[5]/td[5]/a[2]/text()"));
            clickOKToDelete.Click();
        }
    }
}
