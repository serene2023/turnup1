using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turnup.Pages;
using NUnit.Framework;
using turnup.Utilities;

namespace turnup.Tests
{
    [TestFixture]
    public class TMTest : CommonDriver
    {
        private object loginPageObj;

        public object HomePageObj

        [setup]
        public void LoginActions()
        {
            LoginPage hoemPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            LoginPage homePageObj = new HomePage();
            HomePageObj.LoginSteps(driver);
        }

        [test]
        public void CreateTM_Test()
        {

            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTM(driver);

        }

        [test]
        public void EditTM_Test()
        {
            TMPage tmPageObject = new TMPage();
            tmPageObject.EditTM(driver);
        }

        [Test]
        public void DeleteTM_Test() 
        {
            TMPage tmPageObject = new TMPage();
            tmPageObject.DeleteTM(driver);
        }

        [TearDown] 
        public void TearDown() 
        {
        }
    }

