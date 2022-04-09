using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages.Profile;
using ProjectMars.Utilities;
using System;
using System.Threading;

namespace ProjectMars.Pages

{
    [TestFixture]
   [Parallelizable]
      internal class Profile_Test: CommonDriver
    {
        [Test, Order(1)]
        public void CreateLanguage_Test()
        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Language languagePageObj = new Language();
            languagePageObj.ProfilePageCreateLanguage(driver,"dummy1");

        }

        [Test, Order(2)]
        public void EditLanguage_Test()
        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Language languagePageObj = new Language();
            languagePageObj.ProfilePageEditLanguage(driver,"dummy2");

        }
        [Test, Order(3)]
        public void DeleteLanguage_Test()
        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Language languagePageObj = new Language();
            languagePageObj.ProfilePageDeleteLanguage(driver);

        }

        [Test,Order(4)]
        public void CreateSkill_Test()
        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Skills profilePageObj = new Skills();
            profilePageObj.ProfilePageCreateSkill(driver,"dummy3");
        }
        [Test, Order(5)]  
        public void EditSkill_Test()
        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Skills profilePageObj = new Skills();
            profilePageObj.ProfilePageEditSkill(driver,"dummy4");
        }
        [Test, Order(6)]
        public void DeleteSkill_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Skills profilePageObj = new Skills();
            profilePageObj.ProfilePageDeleteSkill(driver);
        }
        [Test, Order(7)]
        public void CreateEducation_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Education profilePageObj = new Education();
            profilePageObj.ProfilePageEducationCreate(driver,"dummy5","dummy6");
        }

        [Test, Order(8)]
        public void UpdateEducation_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Education profilePageObj = new Education();
            profilePageObj.ProfilePageEducationUpdate(driver,"dummy7","dummy8");
        }
        [Test, Order(9)]
        public void DeleteEducation_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Education profilePageObj = new Education();
            profilePageObj.ProfilePageEducationDelete(driver);
        }
        [Test, Order(10)]
        public void CreateCertification_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Certification profilePageObj = new Certification();
            profilePageObj.ProfilePageCertificationCreate(driver,"dummy9","dummy10");
        }
        [Test, Order(11)]
        public void UpdateCertification_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Certification profilePageObj = new Certification();
            profilePageObj.ProfilePageCertificationUpdate(driver,"dummy11","dummy12");
        }
        [Test, Order(12)]
        public void DeleteCertification_Test()

        {
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToHomePage(driver);

            Certification profilePageObj = new Certification();
            profilePageObj.ProfilePageCertificationDelete(driver);
        }

    }
}
