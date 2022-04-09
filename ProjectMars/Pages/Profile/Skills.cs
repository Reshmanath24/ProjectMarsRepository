using NUnit.Framework;
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
    public class Skills
    {        

        #region Add Skill
        /// <summary>
        /// This method is for Add Skill
        /// </summary>
        /// <param name="driver">driver</param>
        public void ProfilePageCreateSkill(IWebDriver driver,string p2)
        {
            Thread.Sleep(3000);
            IWebElement skillsMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsMenu.Click();
            //Adding skills
            Thread.Sleep(5000);
            //Click on skills menu            
            //Click on add new button
            IWebElement addNewSkillsButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkillsButton.Click();
            //Identify the add skill text box and enter the value
            IWebElement addSkillTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkillTextBox.SendKeys(p2);
            //identify the level dropdown and click on it
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();
            //Select beginner option from dropdown
            IWebElement beginnerOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            beginnerOption.Click();
            //Click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
            //Thread.Sleep(2000);
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 2);
            //check if skills created or not
            
            //Option 1
            Thread.Sleep(5000);
            //IWebElement skillCreatedCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));

            //Assert.That(skillCreatedCheck.Text == "C#", "Skills not created, test failed");

           // Option 2
            
            //if (skillCreatedCheck.Text == "Test Skills")
            //{
            //    Assert.Pass("Skills created successfully");
            //}
            //else
            //{
            //    Assert.Fail("Skills not created, test failed");
            //}
            

        }

        public string GetSkillCheck(IWebDriver driver)
        {
            IWebElement skillCreatedCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return skillCreatedCheck.Text;
        }

        #endregion

        #region Editing skills

        public void ProfilePageEditSkill(IWebDriver driver,string p3)
        {
            //Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i", 20);
            Thread.Sleep(2000);

            IWebElement skillsMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsMenu.Click();

            //Click on the edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            Thread.Sleep(3000);
            editButton.Click();
            
            //edit the skill and enter a new skill
            IWebElement editSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            editSkill.Clear();
            editSkill.SendKeys(p3);

            IWebElement editSkillLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            editSkillLevelDropdown.Click();
            //Select beginner option from dropdown
            IWebElement intermediateOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]"));
            intermediateOption.Click();

            //Click on update button
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();            

            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 20);
            //Check the data is updated or not
            
            Thread.Sleep(5000);
            //IWebElement checkSkillUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));

            //Assert.That(checkSkillUpdated.Text == "Testing", "Skill updation failed, test failed");

           
        }
        public string EditSkillCheck(IWebDriver driver)
        {
            IWebElement checkSkillUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return checkSkillUpdated.Text;
        }
        //public string EditLevelCheck(IWebDriver driver)
        //{
        //    IWebElement checkLevelUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
        //    return checkLevelUpdated.Text;
        //}

        #endregion

        #region Deleting Skills
        public void ProfilePageDeleteSkill(IWebDriver driver)
        {
            IWebElement skillsMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsMenu.Click();
            //Deleting the skill
            //Thread.Sleep(1000);
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 2);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            //IWebElement delElement = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            
            deleteButton.Click();
                
        }
        public string deleteSkills(IWebDriver driver)
        {
            IWebElement delElement = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return delElement.Text;
        }
        #endregion
    }
}

