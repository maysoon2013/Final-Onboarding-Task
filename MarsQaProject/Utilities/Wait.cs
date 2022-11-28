using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Utilities
{
    public class Wait
    {

        public static void WaitForElement(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0,0, seconds));

            if (locator=="XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }

            if (locator== "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));


            }

            if (locator== "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));


            }
        }


        public static void WaitToExist(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0,0,seconds));

            if (locator=="XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorvalue)));
            }

            if (locator== "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorvalue)));


            }

            if (locator== "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorvalue)));


            }
        }
            public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorvalue, int seconds)
            {
                WebDriverWait wait = new WebDriverWait(driver,new TimeSpan(0,0,seconds));

                if (locator=="XPath")
                {

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
                }

                if (locator== "Id")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));


                }

                if (locator== "CssSelector")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorvalue)));


                }

            }
        }
    }




