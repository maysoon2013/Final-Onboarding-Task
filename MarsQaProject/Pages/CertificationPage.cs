using MarsQaProject.Drivers;
using MarsQaProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Pages
{
    public class CertificationPage:CommonDriver
        
       {
        //Finding Element By XPath
        private IWebElement clickcertification => driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
        private IWebElement clickAddNew => driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
        private IWebElement certificateName => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
        private IWebElement instituteName => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/input[1]"));
        private IWebElement completionYear => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]"));
        private IWebElement selectComYear => driver.FindElement(By.XPath("//option[contains(text(),'2022')]"));
        private IWebElement clickOnAddBtn => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
        private IWebElement getCertificateName => driver.FindElement(By.XPath("//tbody/tr/td[1]"));
        private IWebElement getInstituteName => driver.FindElement(By.XPath("//tbody/tr/td[2]"));
        private IWebElement getComYear => driver.FindElement(By.XPath("//tbody/tr/td[3]"));
       

        public void GoToCertificationPage(IWebDriver driver)
        {
       
            clickcertification.Click();

        }
        public void AddCertificateSteps(IWebDriver driver, string Certificate,string CertifiedFrom)
        {
        
            clickAddNew.Click();

            certificateName.SendKeys(Certificate);

            instituteName.SendKeys(CertifiedFrom);

            completionYear.Click();

            selectComYear.Click();

            clickOnAddBtn.Click();
            
           

        }

        public string GetCertificate(IWebDriver driver)
        {
            //Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return getCertificateName.Text;
        }

        public string GetCertificateFrom(IWebDriver driver)
        {
        
            return getInstituteName.Text;
        }

        public string GetCompletionYear(IWebDriver driver)
        {
           
            return getComYear.Text;
        }

    }
}
