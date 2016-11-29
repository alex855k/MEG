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
            ITeacher t = new Teacher("mag123", "password", "Magrethe", "Pedersen", "magrther23@gmail.com");
            Assert.AreEqual("Teacher[Username=username,Password=password,Firstname=Magrethe,LastName=Pedersen,Email=magrethe23@gmail.com]", t.ToString());

        }

        
        [TestMethod]
        public void CanAssignTeacherToClassRooms() {
            MEGController MC = new MEGController();
           // MC.AssignTeacher()
        }

        [TestMethod]
        public void TeacherCanCreateAndAssignStudent()
        {
            ITeacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
            string className = "3.B";
            string fn = "Alexander";
            string ln = "Hvidt";
            t.CreateStudent(className, fn, ln);
            Assert.AreEqual("Student[Username=alhvi13,Password=password,Firstname=Alexander,Lastname=Hvidt]", t.ToString());

        }

        [TestMethod]
        public void StudentCanLogin()
        {
           
        }

        [TestMethod]
        public void TeacherCanLogin()
        {

        }

        [TestMethod]
        public void CanCreateTask()
        {

        }

        [TestMethod]
        public void CanAddClassRooms()
        {

        }

        [TestMethod]
        public void CanGetTeacherByEmail()
        {

        }

        [TestMethod]
        public void GetUserTypeReturnsCorrectType()
        {

        }

        [TestMethod]
        public void GetTeacherClassRoomsReturnsCorrectRooms()
        {

        }

        [TestMethod]
        public void ClassRoomExistsCanDetermineIfAClassRoomExeistsByName()
        {

        }

        [TestMethod]
        public void GetClassRoomNamesReturnsAllClassRoomNames()
        {

        }

        [TestMethod]
        public void StudentCreationNumberIsRandom()
        {

        }

        [TestMethod]
        public void TeacherUsernameIsRandom()
        {

        }

        [TestMethod]
        public void TeacherPasswordIsRandom()
        {

        }
    }

}
