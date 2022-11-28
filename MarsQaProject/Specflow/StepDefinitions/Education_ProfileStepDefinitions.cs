using MarsQaProject.Drivers;
using MarsQaProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQaProject.Specflow.StepDefinitions
{
    [Binding]
    public class Education_ProfileStepDefinitions: CommonDriver
    {
        LoginPage loginPageObj;
        Educationpage educationPageobj;
        public Education_ProfileStepDefinitions()
        {
            loginPageObj = new LoginPage();
            educationPageobj= new Educationpage();
        }

        [Given(@"I logged in Mars project account successfully")]
        public void GivenILoggedInMarsProjectAccountSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.loginPage(driver);

        }

        [When(@"I navigate to Education Page by clicking Education")]
        public void WhenINavigateToEducationPageByClickingEducation()
        {
            educationPageobj.GoToEducationPage(driver);
        }

        [When(@"I Click on AddNew and enter '([^']*)', Country, Title,'([^']*)'Graduation Year and click on Add")]
        public void WhenIClickOnAddNewAndEnterCountryTitleGraduationYearAndClickOnAdd(string University, string Degree)
        {
            educationPageobj.AddEducationSteps(driver, University, Degree);
        }

        [Then(@"The education record should be added successfully")]
        public void ThenTheEducationRecordShouldBeAddedSuccessfully()
        {
            string countryName = educationPageobj.GetCountry(driver);
            string uniName = educationPageobj.GetUniversity(driver);
            string titleName = educationPageobj.GetTitle(driver);
            string degreeName = educationPageobj.GetDegree(driver);
            string grationYear = educationPageobj.GetYear(driver);

            Assert.That(countryName=="Bangladesh", "New education added successfully", "Addited country name and expected country name do not match");
            Assert.That(uniName=="DIU", "Addited University name and expected University name do not match");
            Assert.That(titleName=="B.Sc", "Addited Title name and expected title do not match");
            Assert.That(degreeName=="CSE", "Addited Degree name and expected degree name do npt match");
            Assert.That(grationYear=="2007", "Addited Gration year and expected gradution year do not match");

            //Closing Browser
            CommonDriver.Close();

        } 
    }
}
