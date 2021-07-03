using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace DistanceCalculator
{
    class WebHelper
    {
        IWebDriver driver;
        public void findText(String searchString)
        {
            driver = new FirefoxDriver();
          
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.rckr.com/careers");
            var elements = driver.FindElements(By.TagName("b"));



        }

    }
}
