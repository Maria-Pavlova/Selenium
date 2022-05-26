using OpenQA.Selenium;


namespace Student_Registry_Automated_Testing.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";

        public IWebElement StudentsCount => driver.FindElement(By.CssSelector("body > p > b"));

        public int GetStudentsCount()
        {
            string studentCountText = this.StudentsCount.Text;  
            return int.Parse(studentCountText);

        }
    }
}
