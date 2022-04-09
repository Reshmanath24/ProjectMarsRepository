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
    internal class Education
    {
        #region CreateEducation
        public void ProfilePageEducationCreate(IWebDriver driver,string p4,string p5)
        {
            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 20);

            //click on the education menu
            IWebElement educationMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationMenu.Click();
            Thread.Sleep(3000);
            //click on add new button
            IWebElement educationAddNewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddNewBtn.Click();
            //identify the college textbot and enter the value.
            IWebElement collegeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            collegeTextBox.SendKeys(p4);
            //identify the country dropdown and click on it
            IWebElement countryDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryDropdown.Click();
            //select india from dropdown
            IWebElement countrySelect = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            countrySelect.Click();
            //identify the title dropdown and click on it
            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();
            //select BTech from dropdown 
            IWebElement selectTitle = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
            selectTitle.Click();
            //identify the degree textbox and enter the value
            IWebElement degreeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeTextBox.SendKeys(p5);
            //identify the year dropdown
            IWebElement yearDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearDropdown.Click();
            //select the year as 2016
            IWebElement yearSelect = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[8]"));
            yearSelect.Click();
            //click on add button
            IWebElement educationAddBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            educationAddBtn.Click();
            Thread.Sleep(3000);

            //check the education is added or not
            //IWebElement collegeCreateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            //Assert.That(collegeCreateCheck.Text == "PSG College", "College not created, test failed");
            //IWebElement degreeCreateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            //.That(degreeCreateCheck.Text == "ECE", "degree not created, test failed");


        }
        public string checkEducationCollegeCreate(IWebDriver driver)
        {
            IWebElement getEducationCollegeCreate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return getEducationCollegeCreate.Text;
        }
        public string checkEducationDegreeCreate(IWebDriver driver)
        {
            IWebElement getEducationDegreeCreate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return getEducationDegreeCreate.Text;
        }
        #endregion
        #region Update Education
        public void ProfilePageEducationUpdate(IWebDriver driver,string p6,string p7)
        {
            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 20);

            //click on the education menu
            IWebElement educationMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationMenu.Click();
            Thread.Sleep(3000);
            //click on edit button in education
            IWebElement educationEditBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            educationEditBtn.Click();
            //edit the college field
            IWebElement updateCollege = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            updateCollege.Clear();
            updateCollege.SendKeys(p6);
            //edit the degree field
            IWebElement updateDegree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            updateDegree.Clear();
            updateDegree.SendKeys(p7);
            //click on update button
            IWebElement educationUpdateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            educationUpdateBtn.Click();
            Thread.Sleep(3000);
            //check the college is updated 
            //IWebElement CollegeUpdateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            //Assert.That(CollegeUpdateCheck.Text == "AJK", "College not updated,Test failed");
            //IWebElement degreeUpdateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            //Assert.That(degreeUpdateCheck.Text == "EEE", "degree not updated, test failed");
        }
        public string checkEducationCollegeUpdate(IWebDriver driver)
        {
            IWebElement getEducationCollegeUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return getEducationCollegeUpdate.Text;
        }
        public string checkEducationDegreeUpdate(IWebDriver driver)
        {
            IWebElement getEducationDegreeUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return getEducationDegreeUpdate.Text;
        }
        #endregion
        #region Delete Education
        public void ProfilePageEducationDelete(IWebDriver driver)
        {
            //click on the education menu
            IWebElement educationMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationMenu.Click();
            Thread.Sleep(3000);
            //Deleting the skill
            
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i", 2);

            IWebElement educationDeleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            educationDeleteButton.Click();
            //check the education is deleted or not
            //IWebElement educationDeleteCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(educationDeleteCheck.Text == "India", "education deleted successfully");
        }
        public string checkEducationDelete(IWebDriver driver)
        {
            IWebElement getEducationDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return getEducationDelete.Text;
        }
        #endregion
    }


}
