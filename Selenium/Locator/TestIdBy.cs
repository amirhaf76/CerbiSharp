using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace CerbiSharp.Infrastructure.BaseInfrastructure.Selenium.Locator
{
    public class TestIdBy : By
    {
        public TestIdBy(string testid)
        {
            By by = CssSelector($"[data-testid='{testid}']");

            FindElementMethod = by.FindElement;

            FindElementsMethod = by.FindElements;
        }
    }
}

