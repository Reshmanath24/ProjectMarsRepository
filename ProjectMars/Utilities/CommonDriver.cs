using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            //Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginPageMethod(driver);

            
            
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            //driver.Quit();
        }
    }
}
