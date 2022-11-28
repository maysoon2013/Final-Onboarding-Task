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
    public class Educationpage:CommonDriver
    {
        //Finding Elements By Xpath
        public IWebElement educationLink => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]"));
        public IWebElement addNew => driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
        public IWebElement universityName => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
        public IWebElement countryOfUni => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
        public IWebElement selectCountryOfUni => driver.FindElement(By.XPath("//option[contains(text(),'Bangladesh')]"));
        public IWebElement title => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
        public IWebElement selectTitle => driver.FindElement(By.XPath("//option[contains(text(),'B.Sc')]"));
        public IWebElement degree => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
        public IWebElement yearOfGraduation => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
        public IWebElement selectYear => driver.FindElement(By.XPath("//option[contains(text(),'2007')]"));
        public IWebElement clickadd => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
        public IWebElement getCountryName => driver.FindElement(By.XPath("//tbody/tr/td[1]"));
        public IWebElement getUniversityName => driver.FindElement(By.XPath("//tbody/tr/td[2]"));
        public IWebElement gettiTleName => driver.FindElement(By.XPath("//tbody/tr/td[3]"));
        public IWebElement getDegreeName => driver.FindElement(By.XPath("//tbody/tr/td[4]"));
        public IWebElement getGrdYear => driver.FindElement(By.XPath("//tbody/tr/td[5]"));



        public void GoToEducationPage(IWebDriver driver)
        {
            
            educationLink.Click();
        }

        public void AddEducationSteps(IWebDriver driver,string University,string Degree) 
        {
            addNew.Click();

            universityName.SendKeys(University);

            countryOfUni.Click();

            selectCountryOfUni.Click();

            title.Click();

            selectTitle.Click();

            degree.SendKeys(Degree);

            yearOfGraduation.Click();

            selectYear.Click();

            clickadd.Click();

            //Explicit Wait
           
            Wait.WaitToExist(driver,"XPath","//td[contains(text(),'Bangladesh')]",20);


        } 

        public string GetCountry(IWebDriver driver)
        {
        
            return getCountryName.Text;
        }

        public string GetUniversity(IWebDriver driver) 
        {
         
            return getUniversityName.Text;
        }

        public string GetTitle(IWebDriver driver) 
        {
           
            return gettiTleName.Text;
        }

        public string GetDegree(IWebDriver driver)
        {
          
            return getDegreeName.Text;
        }

        public string GetYear(IWebDriver driver)
        {
            
            return getGrdYear.Text;
        }

        }
    }


