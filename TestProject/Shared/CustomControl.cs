using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTest.Shared
{
    internal class CustomControl
    {
        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void Click(IWebElement webElement) => webElement.Click();

        public static void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }

        public static void SelectByIndex(IWebElement webElement, int index)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByIndex(index);
        }

    }
}
