using NUnit.Framework;
using Student_Registry_Automated_Testing.PageObjects;
using System;


namespace Student_Registry_Automated_Testing.Tests

{
    public class AddStudentPageTests : BaseTests
    {


        [Test]

        public void Test_AddStudentPage_Links()
        {
            var addStudentPage = new AddStudentPage(driver);
            addStudentPage.Open();
            addStudentPage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).isOpen());

            addStudentPage.Open();
            addStudentPage.LinkViewStudents.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());

            addStudentPage.Open();
            addStudentPage.LinkAddStudent.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());
        }


        [Test]
        public void Test_AddStudentPage_Content()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            Assert.AreEqual("Add Student", page.GetPageTitle());
            Assert.AreEqual("Register New Student", page.GetPageHeading());
            Assert.AreEqual("", page.nameField.Text);
            Assert.AreEqual("", page.emailField.Text);
            Assert.AreEqual("Add", page.addButton.Text);

        }

        [Test]
        public void Test_AddStudentPage_AddValidStudent_()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "Maria" + DateTime.Now.Ticks;
            string email = "Maria" + DateTime.Now.Ticks + "@mail.com";
            page.AddStudent(name, email);
            var viewStudentsPage = new ViewStudentsPage(driver);
            Assert.IsTrue(viewStudentsPage.isOpen());

            var students = viewStudentsPage.GetRegisteredStudents();
            string expectedStudent = name + " (" + email + ")";
            Assert.Contains(expectedStudent, students);


        }

        [Test]
        public void Test_AddStudentPage_AddInvalidStudent_()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "";
            string email = "Maria@mail.com";
            page.AddStudent(name, email);

            Assert.IsTrue(page.isOpen());
            string errorMessage = "Cannot add student. Name and email fields are required!";
            Assert.AreEqual(errorMessage, page.errorMsg.Text);
          
        }
    }
}