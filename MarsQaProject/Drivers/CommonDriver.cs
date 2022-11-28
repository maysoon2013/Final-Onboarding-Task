using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Drivers
{
    public class CommonDriver
    {
        public static IWebDriver driver { get; set; }



        public static void Close()
        {
            driver.Quit();
        }
    }
}
