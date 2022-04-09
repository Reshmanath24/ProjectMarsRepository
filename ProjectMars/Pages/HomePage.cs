using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class HomePage
    {
        public void GoToHomePage(IWebDriver driver)
        {
            Thread.Sleep(3000);
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/a[2]", 120);

            IWebElement profileIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            profileIcon.Click();

        }
        public string checkUser(IWebDriver driver)
        {
            IWebElement loggedInUserCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            return loggedInUserCheck.Text;
        }
    }
}
