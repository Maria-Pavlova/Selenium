using NUnit.Framework;
using Student_Registry_Automated_Testing.PageObjects;


namespace Student_Registry_Automated_Testing.Tests

{
    public class HomePageTests : BaseTests
    {
        

        [Test]
        public void Test_HomePage_TitleAndHeading()
        {
            var page = new HomePage(driver); 
            page.Open();
            Assert.AreEqual("MVC Example", page.GetPageTitle());
            Assert.AreEqual("Students Registry", page.GetPageHeading());
            Assert.IsTrue(page.GetStudentsCount() > 0);

        }

        [Test]
        public void Test_HomePage_Links()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).isOpen());

            homePage.Open();
            homePage.LinkViewStudents.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());

            homePage.Open();
            homePage.LinkAddStudent.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());
        }


      
    }
}