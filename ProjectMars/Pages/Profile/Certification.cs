using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Pages.Profile
{
    internal class Certification
    {
        #region Create Certification
        public void ProfilePageCertificationCreate(IWebDriver driver,string p8,string p9)
        {
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 20);

            //Click on Certification menu
            IWebElement certificationMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationMenu.Click();
            Thread.Sleep(3000);
            //Click on add new button
            IWebElement certificationAddNewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certificationAddNewBtn.Click();
            //Identify the certificate textbox and enter the value
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextbox.SendKeys(p8);
            //Identified the certified textbox and enter the value;
            IWebElement certifiedTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedTextbox.SendKeys(p9);
            //Identify the yeardropdown
            IWebElement certificateYearDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            certificateYearDropdown.Click();
            //select the 2022 year from the dropdown
            IWebElement certificateYearOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            certificateYearOption.Click();
            //click on certificate add button
            IWebElement certificateAddBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            certificateAddBtn.Click();
            Thread.Sleep(3000);
            //check the certificate is added or not
            //IWebElement checkCertification = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(checkCertification.Text == "IndustryConnectCertificate", "certificate not added successfully, test failed");
            //IWebElement certifiedCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            //Assert.That(certifiedCheck.Text == "MVP Studio", "certified not updated,Test failed");

            
        }
        public string checkCertificationCreate(IWebDriver driver)
        {
            IWebElement getCertificationCreate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return getCertificationCreate.Text;
        }
        public string checkCertifiedCreate(IWebDriver driver)
        {
            IWebElement getCertifiedCreate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return getCertifiedCreate.Text;
        }
        #endregion
        #region Update Certificate
        public void ProfilePageCertificationUpdate(IWebDriver driver,string p10,string p11)
        {
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 20);

            //Click on Certification menu
            IWebElement certificationMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationMenu.Click();
            Thread.Sleep(3000);
            //click on edit button in certification
            IWebElement certificationEditBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            certificationEditBtn.Click();
            Thread.Sleep(3000);
            //edit the certificate field
            IWebElement updateCertificate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
            updateCertificate.Clear();
            updateCertificate.SendKeys(p10);
            //edit the certified from field
            IWebElement updateCertifiedFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
            updateCertifiedFrom.Clear();
            updateCertifiedFrom.SendKeys(p11);
            //click on update button
            IWebElement certificateUpdateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            certificateUpdateBtn.Click();
            Thread.Sleep(3000);
            //check the college is updated 
            //IWebElement certificationUpdateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(certificationUpdateCheck.Text == "ICCertificate", "certificate not updated,Test failed");
            //IWebElement certifiedUpdateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            //Assert.That(certifiedUpdateCheck.Text == "MVP", "certified not updated,Test failed");

        }
        public string checkCertificationUpdate(IWebDriver driver)
        {
            IWebElement getCertificationUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return getCertificationUpdate.Text;
        }
        public string checkCertifiedUpdate(IWebDriver driver)
        {
            IWebElement getCertifiedUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return getCertifiedUpdate.Text;
        }
        #endregion
        #region DeleteCertification
        public void ProfilePageCertificationDelete(IWebDriver driver)
        {
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 20);

            //Click on Certification menu
            IWebElement certificationMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationMenu.Click();
            Thread.Sleep(3000);
            //Deleting the skill

            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i", 2);

            IWebElement certificationDeleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            certificationDeleteButton.Click();
            //check the education is deleted or not
            //IWebElement certificationDeleteCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(certificationDeleteCheck.Text == "ICCertificate", "certification deleted successfully");


        }
        public string checkCertificationDelete(IWebDriver driver)
        {
            IWebElement getCertificationDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return getCertificationDelete.Text;
        }
        #endregion
    }
}
