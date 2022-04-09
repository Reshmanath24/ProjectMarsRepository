using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Pages.Profile;
using ProjectMars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars
{
    [Binding]
    public class ProfilePageFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage HomePageObj = new HomePage();
        Skills profilePageObj = new Skills();
        Language languagePageObj = new Language();
        Education educationPageObj = new Education();
        Certification certificationPageObj = new Certification();

        [Given(@"I logged into the web portal successfully with valid credentials")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyWithValidCredentials()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile home page")]
        public void GivenINavigatedToTheProfileHomePage()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I clicked on the profile home page")]
        public void WhenIClickedOnTheProfileHomePage()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [Then(@"I could see the profile name displayed")]
        public void ThenICouldSeeTheProfileNameDisplayed()
        {
            string usercheck = HomePageObj.checkUser(driver);
            Assert.That(usercheck == "Hi Reshma", "Invalid user logged in,test failed");
        }

        [Given(@"I logged into the web portal successfully to create the language")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToCreateTheLanguage()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to create language")]
        public void GivenINavigatedToTheProfilePageToCreateLanguage()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I created '([^']*)' on the profile page")]
        public void WhenICreatedOnTheProfilePage(string p0)
        {
            languagePageObj.ProfilePageCreateLanguage(driver, p0);
        }

        [Then(@"The language record should be able to create '([^']*)'")]
        public void ThenTheLanguageRecordShouldBeAbleToCreate(string p0)
        {
            string stroreCreateLanguage = languagePageObj.checklanguageCreate(driver);
            Assert.That(stroreCreateLanguage == p0, "Language is not added, test failed");

        }

        [Given(@"I logged into the web portal successfully to update the language")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToUpdateTheLanguage()
        {

            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to update language")]
        public void GivenINavigatedToTheProfilePageToUpdateLanguage()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I update '([^']*)' on the profile page")]
        public void WhenIUpdateOnTheProfilePage(string p1)
        {
            languagePageObj.ProfilePageEditLanguage(driver, p1);
        }

        [Then(@"The language record should be able to update the '([^']*)'")]
        public void ThenTheLanguageRecordShouldBeAbleToUpdateThe(string p1)
        {
            string stroreUpdateLanguage = languagePageObj.checklanguageCreate(driver);
            Assert.That(stroreUpdateLanguage == p1, "Language updation failed, test failed");
        }

        [Given(@"I logged into the web portal successfully to delete the language")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToDeleteTheLanguage()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to delete language")]
        public void GivenINavigatedToTheProfilePageToDeleteLanguage()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I delete the language on the profile page")]
        public void WhenIDeleteTheLanguageOnTheProfilePage()
        {
            languagePageObj.ProfilePageDeleteLanguage(driver);
        }

        [Then(@"The language record should get deleted")]
        public void ThenTheLanguageRecordShouldGetDeleted()
        {
            string stroreDeleteLanguage = languagePageObj.checklanguageCreate(driver);
            Assert.That(stroreDeleteLanguage == "Malayalam", "Language deleted successfully");
        }

        [Given(@"I Logged into the web portal successfully to add the skill")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToAddTheSkill()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to add skill")]
        public void GivenINavigatedToTheProfilePageToAddSkill()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I created skill '([^']*)' on the profile page")]
        public void WhenICreatedSkillOnTheProfilePage(string p2)
        {
            profilePageObj.ProfilePageCreateSkill(driver, p2);
        }

        [Then(@"I should be able to create '([^']*)'")]
        public void ThenIShouldBeAbleToCreate(string p2)
        {
            string stroreCreateSkill = profilePageObj.GetSkillCheck(driver);
            Assert.That(stroreCreateSkill == p2, "Skills not created, test failed");

        }

        [Given(@"I logged into the web portal successfully to update my skill")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToUpdateMySkill()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to update my skill")]
        public void GivenINavigatedToTheProfilePageToUpdateMySkill()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I updated the '([^']*)' on the profile page")]
        public void WhenIUpdatedTheOnTheProfilePage(string p3)
        {
            profilePageObj.ProfilePageEditSkill(driver, p3);
        }
        [Then(@"I should be able to Update '([^']*)'")]
        public void ThenIShouldBeAbleToUpdate(string p3)
        {
            string storeEditSkill = profilePageObj.EditSkillCheck(driver);
            Assert.That(storeEditSkill == p3, "Skills not updated, test failed");
        }

        [Given(@"I logged into the web portal successfully to delete my skill")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToDeleteMySkill()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to delete my skill")]
        public void GivenINavigatedToTheProfilePageToDeleteMySkill()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I deleted the skill on the profile page")]
        public void WhenIDeletedTheSkillOnTheProfilePage()
        {
            profilePageObj.ProfilePageDeleteSkill(driver);
        }

        [Then(@"The skill record should be deleted")]
        public void ThenTheSkillRecordShouldBeDeleted()
        {
            string storeDeleteSkill = profilePageObj.EditSkillCheck(driver);
            Assert.That(storeDeleteSkill == "C++", "Skills deleted successfully");
        }

        [Given(@"I logged into the web portal successfully to create education")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToCreateEducation()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to create education")]
        public void GivenINavigatedToTheProfilePageToCreateEducation()
        {
            HomePageObj.GoToHomePage(driver);
        }
        [When(@"I create education '([^']*)','([^']*)'on the profile page")]
        public void WhenICreateEducationOnTheProfilePage(string p4, string p5)
        {
            educationPageObj.ProfilePageEducationCreate(driver, p4, p5);
        }


        [Then(@"The education record should be able to create '([^']*)','([^']*)'")]
        public void ThenTheEducationRecordShouldBeAbleToCreate(string p4, string p5)
        {
            string storeEducationCollegeCreate = educationPageObj.checkEducationCollegeCreate(driver);
            Assert.That(storeEducationCollegeCreate == p4, "College not created, test failed");

            string storeEducationDegreeCreate = educationPageObj.checkEducationDegreeCreate(driver);
            Assert.That(storeEducationDegreeCreate== p5, "degree not created, test failed");

        }

        [Given(@"I logged into the web portal successfully to update the education")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToUpdateTheEducation()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to update education")]
        public void GivenINavigatedToTheProfilePageToUpdateEducation()
        {
            HomePageObj.GoToHomePage(driver);
        }
        [When(@"I update the education '([^']*)','([^']*)'> on the profile page")]
        public void WhenIUpdateTheEducationOnTheProfilePage(string p6, string p7)
        {
            educationPageObj.ProfilePageEducationUpdate(driver, p6, p7);
        }


        [Then(@"The education record should be able to update '([^']*)','([^']*)'>")]
        public void ThenTheEducationRecordShouldBeAbleToUpdate(string p6, string p7)
        {
            string storeEducationCollegeUpdate = educationPageObj.checkEducationCollegeUpdate(driver);
            Assert.That(storeEducationCollegeUpdate == p6, "College not created, test failed");

            string storeEducationDegreeUpdate = educationPageObj.checkEducationDegreeUpdate(driver);
            Assert.That(storeEducationDegreeUpdate == p7, "degree not created, test failed");
        }

        [Given(@"I logged into the web portal successfully to delete the education")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToDeleteTheEducation()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to delete education")]
        public void GivenINavigatedToTheProfilePageToDeleteEducation()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I delete the education on the profile page")]
        public void WhenIDeleteTheEducationOnTheProfilePage()
        {
            educationPageObj.ProfilePageEducationDelete(driver);
        }

        [Then(@"The education record should get deleted")]
        public void ThenTheEducationRecordShouldGetDeleted()
        {
            string storeDeleteEducation = educationPageObj.checkEducationDelete(driver);
            Assert.That(storeDeleteEducation == "India", "education deleted successfully");
        }

        [Given(@"I logged into the web portal successfully to create certification")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToCreateCertification()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to create certification")]
        public void GivenINavigatedToTheProfilePageToCreateCertification()
        {
            HomePageObj.GoToHomePage(driver);
        }
        [When(@"I created certification '([^']*)','([^']*)' on the profile page")]
        public void WhenICreatedCertificationOnTheProfilePage(string p8, string p9)
        {
            certificationPageObj.ProfilePageCertificationCreate(driver, p8, p9);
        }


        [Then(@"The certification record should be able to create '([^']*)','([^']*)'")]
        public void ThenTheCertificationRecordShouldBeAbleToCreate(string p8, string p9)
        {
            string storeCertificationCreate = certificationPageObj.checkCertificationCreate(driver);
            Assert.That(storeCertificationCreate == p8, "Certification not created, test failed");

            string storeCertifiedCreate = certificationPageObj.checkCertifiedCreate(driver);
            Assert.That(storeCertifiedCreate == p9, "certified not created, test failed");
        }

        [Given(@"I logged into the web portal successfully to update the certificate")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToUpdateTheCertificate()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to update certification")]
        public void GivenINavigatedToTheProfilePageToUpdateCertification()
        {
            HomePageObj.GoToHomePage(driver);
        }
        [When(@"I updated the certification '([^']*)','([^']*)' on the profile page")]
        public void WhenIUpdatedTheCertificationOnTheProfilePage(string p10, string p11)
        {
            certificationPageObj.ProfilePageCertificationUpdate(driver, p10, p11);
        }

        [Then(@"The certification record should be able to update '([^']*)','([^']*)'")]
        public void ThenTheCertificationRecordShouldBeAbleToUpdate(string p10, string p11)
        {
            string storeCertificationUpdate = certificationPageObj.checkCertificationCreate(driver);
            Assert.That(storeCertificationUpdate == p10, "Certification not updated, test failed");

            string storeCertifiedUpdate = certificationPageObj.checkCertifiedCreate(driver);
            Assert.That(storeCertifiedUpdate == p11, "certified not updated, test failed");
        }

        [Given(@"I logged into the web portal successfully to delete the certification")]
        public void GivenILoggedIntoTheWebPortalSuccessfullyToDeleteTheCertification()
        {
            // Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation

            loginPageObj.LoginPageMethod(driver);
        }

        [Given(@"I navigated to the profile page to delete certification")]
        public void GivenINavigatedToTheProfilePageToDeleteCertification()
        {
            HomePageObj.GoToHomePage(driver);
        }

        [When(@"I delete the certification on the profile page")]
        public void WhenIDeleteTheCertificationOnTheProfilePage()
        {
            certificationPageObj.ProfilePageCertificationDelete(driver);
        }

        [Then(@"The certification record should get deleted")]
        public void ThenTheCertificationRecordShouldGetDeleted()
        {
            string storeDeleteCertification = certificationPageObj.checkCertificationDelete(driver);
            Assert.That(storeDeleteCertification == "ICCertificate", "certification deleted successfully");
        }
    }
}



























