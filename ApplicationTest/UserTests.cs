using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MEG;

namespace ApplicationTest
{
    [TestClass]
    public class UserTests
    {

        [TestMethod]
        public void CanCreateTeacher()
        {
            MEGController MC = new MEGController();
          //  ITeacher t = MC.CreateTeacher();
           // Assert.AreEqual();
        }

        [TestMethod]
        public void CanAssignTeacherToClassRooms() {
            MEGController MC = new MEGController();
           // MC.AssignTeacher()
        }

        [TestMethod]
        public void TeacherCanCreateAndAssignStudent()
        {
           /* ITeacher t = new Teacher();
            string className = "3.B";
            string fn = "Alexander";
            string ln = "Hvidt";
            t.CreateStudent(className, fn, ln);
            Assert.AreEqual("Student[Username=alhvi13,Password=password,Firstname=Alexander,Lastname=Hvidt]", t.ToString()); 
            */
        }

        [TestMethod]
        public void StudentCanLogin()
        {
           
        }

        [TestMethod]
        public void TeacherCanLogin()
        {

        }

    }

}
