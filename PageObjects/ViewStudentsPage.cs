using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Linq;


namespace Student_Registry_Automated_Testing.PageObjects
{
    public class ViewStudentsPage : BasePage
    {
        public ViewStudentsPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/students";
        public ReadOnlyCollection<IWebElement> ListOfStudents => driver.FindElements(By.CssSelector("body > ul > li"));
       

        public string[] GetRegisteredStudents()
        {
            return this.ListOfStudents.Select(s => s.Text).ToArray();

        }
       
    }
}
