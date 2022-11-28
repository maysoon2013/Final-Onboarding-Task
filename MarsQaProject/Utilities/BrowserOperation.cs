using MarsQaProject.Drivers;
using MarsQaProject.Input;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Utilities
{
    public class BrowserOperation : CommonDriver
    {
        public static void SelectingBrowser()
        {
            if (BrowserInput.browser == "chrome")
            {
                driver = new ChromeDriver();
            }
            else
            {
                driver = new FirefoxDriver();
            }

        }
    }
}
