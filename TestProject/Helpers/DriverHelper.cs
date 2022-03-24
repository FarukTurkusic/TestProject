using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest
{
    internal class DriverHelper
    {
        public static IWebDriver? Driver { get; set; }

        //public void start_ChromeBrowser()
        //{
        //    // Local Selenium WebDriver
        //    Driver = new ChromeDriver();
        //    Driver.Manage().Window.Maximize();
        //}

        /* API - Get Window Title */
        public String getCurrWindowTitle()
        {
            String windowTitle = Driver.Title;
            return windowTitle;
        }
        /* API - Get Window Handle */
        public String getMainWinHandle(IWebDriver driver)
        {
            return driver.CurrentWindowHandle;
        }
        public Boolean closeAllWindows(String currWindowHandle)
        {
            IList<string> totWindowHandles = new List<string>(Driver.WindowHandles);

            foreach (String WindowHandle in totWindowHandles)
            {
                Console.WriteLine(WindowHandle);
                if (!WindowHandle.Equals(currWindowHandle))
                {
                    Driver.SwitchTo().Window(WindowHandle);
                    Driver.Close();
                }
            }

            Driver.SwitchTo().Window(currWindowHandle);
            if (Driver.WindowHandles.Count == 1)
                return true;
            else
                return false;
        }
    }
}
