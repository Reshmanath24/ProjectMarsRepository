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
    public class Language
    {
        #region Create Language
        public void ProfilePageCreateLanguage(IWebDriver driver, string p0)
        {
            //Click on LanguageMenu
            IWebElement LanguageMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageMenu.Click();
            Thread.Sleep(3000);
            //Click on Add new button
            IWebElement addNewLanguageBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageBtn.Click();
            Thread.Sleep(2000);
            //Identify the add language textbox and enter a value
            IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextBox.SendKeys(p0);
            //Identify the level dropdown and click on it
            IWebElement languageLevelDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropDown.Click();
            //Select fluent option from dropdown
            IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            fluentOption.Click();
            //click on add button to add language
            IWebElement addLanguageBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageBtn.Click();
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 20);

            //Check if language created or not
           // IWebElement checkLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(checkLanguage.Text == "English", "Language is not added, test failed");

        }
        public string checklanguageCreate(IWebDriver driver)
        {
            IWebElement getLangaugeCreate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return getLangaugeCreate.Text;
        }

        #endregion

        #region Edit language
        public void ProfilePageEditLanguage(IWebDriver driver,string p1)
        {
            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]", 20);
            //click on language menu
            IWebElement LanguageMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageMenu.Click();
            Thread.Sleep(3000);
            //click on the edit button
            IWebElement editLanguageBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            editLanguageBtn.Click();
            //Identify the language textbox and edit it by Clearing text box 
            IWebElement editLanguageTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            editLanguageTextBox.Clear();
            editLanguageTextBox.SendKeys(p1);

            //click on the level dropdown
            IWebElement editLanguageLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            editLanguageLevelDropdown.Click();

            //select the native option from dropdown
            IWebElement nativeOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
            nativeOption.Click();

            //Click on update button
            IWebElement LanguageUpdateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            LanguageUpdateBtn.Click();
            //Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 20);
            Thread.Sleep(3000);
            //Check language is editted or not
            //IWebElement languageUpdateCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
         
           //Assert.That(languageUpdateCheck.Text == "Malayalam", "Language updation failed, test failed");

        }
        public string checklanguageUpdate(IWebDriver driver)
        {
            IWebElement getLangaugeUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return getLangaugeUpdate.Text;
        }


        #endregion
        #region Delete Language
        public void ProfilePageDeleteLanguage(IWebDriver driver)
        {
            //click on language menu
            IWebElement LanguageMenu = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageMenu.Click();
            Thread.Sleep(3000);
            //click om delete button
            IWebElement languageDelBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            languageDelBtn.Click();
            //check the language is deleted or not
           // IWebElement languageDelCheck = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(languageDelCheck.Text == "Malayalam", "Language deleted successfully");
        }

        public string checklanguageDelete(IWebDriver driver)
        {
            IWebElement getLangaugeDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return getLangaugeDelete.Text;
        }
        #endregion

    }
}
