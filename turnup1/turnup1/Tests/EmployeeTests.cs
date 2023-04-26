using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnup.Pages;
using turnup.Utilities;

namespace turnup.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTests : CommonDriver
    {
        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

       

        [Test]
        public void CreateEmployee_Test()
        {

            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee_Test()
        {

            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee_Test()
        {

            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
    
    }
}
