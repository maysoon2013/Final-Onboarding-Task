using MarsQaProject.Drivers;
using MarsQaProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Pages
{
    public class LanguagePage:CommonDriver
    {
       

        //Finding Elements by Xpath
        private IWebElement language => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        private IWebElement addNew => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        private IWebElement addLanguage => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private IWebElement clickLanguageLevel => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
        private IWebElement chooseLanguageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement clickAddButton => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
        private IWebElement getLanguageName => driver.FindElement(By.XPath("//td[contains(text(),'Bengoli')]"));
        private IWebElement getLevelName => driver.FindElement(By.XPath("//td[contains(text(),'Fluent')]"));

      


        public void GoToLanguagePage(IWebDriver driver)
        {
            language.Click();
        }
        public void ClickAddNew(IWebDriver driver)
        {

            addNew.Click();

        }

        public void Addlanguage(IWebDriver driver, string Language, string level)
        {
            addLanguage.SendKeys(Language);

            clickLanguageLevel.Click();

            SelectElement LanguageLevel = new SelectElement(chooseLanguageLevel);

            LanguageLevel.SelectByValue(level);

        }

        public void ClickAddButton(IWebDriver driver)
        {

            clickAddButton.Click();

            //Explicit Wait

            Wait.WaitToExist(driver, "XPath", "//td[contains(text(),'Bengoli')]", 10);

        }

        public string GetLanguage(IWebDriver driver)
        {

            return getLanguageName.Text;

        }

        public string GetLevel(IWebDriver driver)
        {

            return getLevelName.Text;
        }

       
            


        }
    }
