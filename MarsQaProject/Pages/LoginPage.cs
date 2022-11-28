
using MarsQaProject.Drivers;
using MarsQaProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQaProject.Input;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MarsQaProject.Pages
{
    public class LoginPage:CommonDriver
    {
        public static string url = "http://localhost:5000";

        //Finding Elements by Xpath

        private IWebElement signInLink =>driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private IWebElement userName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private IWebElement password => driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private IWebElement login => driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));


        public void loginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            

           //click on Sign In link
           signInLink.Click();

           // Enter valid username
           userName.SendKeys(LogInCredential.username);

           // Enter valid password
            password.SendKeys(LogInCredential.password);

           // Click on Login Button
           login.Click();

           //Explicit wait
           Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", 10);




        }
    }
}
