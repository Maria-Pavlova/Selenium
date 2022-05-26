using NUnit.Framework;
using Student_Registry_Automated_Testing.PageObjects;


namespace Student_Registry_Automated_Testing.Tests

{
    public class ViewStudentPageTests : BaseTests
    {


        [Test]
        public void Test_ViewStudentsPage_Content()
        {
            var page = new ViewStudentsPage(driver);
            page.Open();
            Assert.AreEqual("Students", page.GetPageTitle());
            Assert.AreEqual("Registered Students", page.GetPageHeading());
            var students = page.GetRegisteredStudents();
            foreach (string student in students)
            {
                Assert.IsNotNull(student);
                Assert.IsTrue(student.IndexOf("(") > 0);
                Assert.IsTrue(student.LastIndexOf(")") == student.Length - 1);

            }
        }

        [Test]
         public void Test_ViewStudentsPage_Links()
            
            {
                var viewStudentsPage = new ViewStudentsPage(driver);
                viewStudentsPage.Open();
                viewStudentsPage.LinkHomePage.Click();
                Assert.IsTrue(new HomePage(driver).isOpen());

                viewStudentsPage.Open();
                viewStudentsPage.LinkViewStudents.Click();
                Assert.IsTrue(new ViewStudentsPage(driver).isOpen());

                viewStudentsPage.Open();
                viewStudentsPage.LinkAddStudent.Click();
                Assert.IsTrue(new AddStudentPage(driver).isOpen());
            }
        

        [Test]
        public void Test_AddStudentPage_TitleAndHeading()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            Assert.AreEqual("Add Student", page.GetPageTitle());
            Assert.AreEqual("Register New Student", page.GetPageHeading());

        }
    }
}