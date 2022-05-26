using OpenQA.Selenium;
using System;


namespace Student_Registry_Automated_Testing.PageObjects
{
    public class BasePage
    {
        protected IWebDriver driver;
        public virtual string PageUrl { get;  }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public IWebElement LinkHomePage => driver.FindElement(By.XPath("//a[contains(.,'Home')]"));
        public IWebElement LinkViewStudents => driver.FindElement(By.CssSelector("body > a:nth-child(3)"));
        public IWebElement LinkAddStudent => driver.FindElement(By.CssSelector("body > a:nth-child(5)"));
        public IWebElement PageHeading => driver.FindElement(By.CssSelector("body > h1"));


        public void Open()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool isOpen()
        {
            return driver.Url == this.PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeading()
        {
            return PageHeading.Text;
        }


    }
}
