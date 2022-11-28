using MarsQaProject.Drivers;
using MarsQaProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQaProject.Specflow.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions: CommonDriver
    {
        LoginPage loginPageObj;
        CertificationPage certificationPageObj;

        public CertificationStepDefinitions()
        {
            loginPageObj = new LoginPage();
            certificationPageObj = new CertificationPage();
        }

        [Given(@"I logged into Mars project account successfully")]
        public void GivenILoggedIntoMarsProjectAccountSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.loginPage(driver);

        }

        [When(@"I navigate to Certification Page")]
        public void WhenINavigateToCertificationPage()
        {
            certificationPageObj.GoToCertificationPage(driver);
            
        }

        [When(@"I click on Add new and enter '([^']*)', '([^']*)' select year and click on add")]
        public void WhenIClickOnAddNewAndEnterSelectYearAndClickOnAdd(string Certificate, string CertifiedFrom)
        {
          certificationPageObj.AddCertificateSteps(driver, Certificate, CertifiedFrom);
        }

        [Then(@"The certication should be added successfully")]
        public void ThenTheCerticationShouldBeAddedSuccessfully()
        {
            string certificateName = certificationPageObj.GetCertificate(driver);
            string certificateFrom = certificationPageObj.GetCertificateFrom(driver);
            string year= certificationPageObj.GetCompletionYear(driver);

            Assert.That(certificateName=="Tester", "Certificate name added successfully", "Addited certificate do not match with expected certificate");
            Assert.That(certificateFrom=="IndustryConnect", "Certificate from added successfully", "Addited certificate from do not match with expected certificate from");
            Assert.That(year=="2022", "Completion year added successfully", "Addited Year do not match with expected year");

            //Closing Browser
            CommonDriver.Close();
        
        }
    }
}
