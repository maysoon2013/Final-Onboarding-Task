using MarsQaProject.Drivers;
using MarsQaProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQaProject.Specflow.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions: CommonDriver
    {
        LoginPage loginPageObj;
        LanguagePage languagepageObj;

        public LanguageStepDefinitions()
        {
            loginPageObj = new LoginPage();
            languagepageObj = new LanguagePage();
        }

        [Given(@"I logged into the Mars Project account successfully")]
        public void GivenILoggedIntoTheMarsProjectAccountSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.loginPage(driver);


        }

        [When(@"I navigate to language page")]
        public void WhenINavigateToLanguagePage()
        {
            languagepageObj.GoToLanguagePage(driver);

        }

        [When(@"I click on AddNew button")]
        public void WhenIClickOnAddNewButton()
        {
            languagepageObj.ClickAddNew(driver);
        }

        [When(@"I Add '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddAndToTheProfile(string Language, string level)
        {
            languagepageObj.Addlanguage(driver, Language, level);

        }

        [When(@"T click on Add button")]
        public void WhenTClickOnAddButton()
        {
            languagepageObj.ClickAddButton(driver);

        }

        [Then(@"The record of launage should be added successfully")]
        public void ThenTheRecordOfLaunageShouldBeAddedSuccessfully()
        {
            string languageName = languagepageObj.GetLanguage(driver);
            string levelName = languagepageObj.GetLevel(driver);

            Assert.That(languageName=="Bengoli", "Language name added successfully,Test passed", "Addited language name do not match with expected language");
            Assert.That(levelName=="Fluent", " Level name added successfully, Test passed", "Addited level name do not match expected level");
            
           
    }
     


    }
}
