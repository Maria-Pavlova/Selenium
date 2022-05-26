using OpenQA.Selenium;


namespace Student_Registry_Automated_Testing.PageObjects
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";

        public IWebElement nameField => driver.FindElement(By.CssSelector("input#name"));
        public IWebElement emailField => driver.FindElement(By.CssSelector("input#email"));
        public IWebElement addButton => driver.FindElement(By.CssSelector("body > form > button"));
        public IWebElement errorMsg => driver.FindElement(By.CssSelector("body > div"));


        public void AddStudent(string name, string email)
        {
            
            nameField.SendKeys(name);
            emailField.SendKeys(email);
            addButton.Click();
        }
   
    }
}
