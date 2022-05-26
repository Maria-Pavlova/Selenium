using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Student_Registry_Automated_Testing.Tests

{
    public class BaseTests
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }

    }

    
}
