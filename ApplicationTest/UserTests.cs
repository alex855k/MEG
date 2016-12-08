using Microsoft.VisualStudio.TestTools.UnitTesting;
using MEG;
using System.Collections.Generic;

namespace ApplicationTest
{
    [TestClass]
    public class UserTests
    {

        [TestMethod]
        public void CanCreateTeacher()
        {
            MEGController MC = new MEGController();
            Assert.IsTrue(MC.CreateTeacher("mag123", "password", "Magrethe", "Pedersen", "magrethe23@gmail.com"));

        }


        //[TestMethod]
        //public void CanAssignTeacherToClassRooms()
        //{
        //    MEGController MC = new MEGController();
        //    MC.CreateTeacher("mag123", "password", "Magrethe", "Pedersen", "magrethe23@gmail.com");
        //    Assert.IsTrue(MC.AssignTeacher("magrethe23@gmail.com", "1.B"));
        //    Teacher testTeacher = MC.GetTeacher("magrethe23@gmail.com"); //change the method in MEG to public
        //    Assert.IsTrue(MC.GetClassRoom("1.B").FindTeacher(testTeacher)); //change the method in MEG to public
        //    Assert.AreNotEqual(0, testTeacher.getClassRooms().Count);
        //    for (int i = 0; i < testTeacher.getClassRooms().Count; i++)
        //    {
        //        Assert.AreEqual("1.B", testTeacher.getClassRoomNames()[i]);
        //    }
        //}

        //[TestMethod]
        //public void TeacherCanCreateAndAssignStudent()
        //{
        //    ITeacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
        //    MEGController MC = new MEGController();
        //    string className = "3.B";
        //    string fn = "Alexander";
        //    string ln = "Hvidt";
        //    t.CreateStudent(className, fn, ln);
        //    Assert.AreEqual("Student[FirstName=" + fn + ",LastName=" + ln + "]", MC.GetClassRoom(className).FindStudent(fn, ln).ToString()); //create the FindStudent method and make it return the the instance that was searched for
        //}

        //[TestMethod]
        //public void StudentCanLogin()
        //{
        //    ITeacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
        //    MEGController MC = new MEGController();
        //    string className = "3.B";
        //    string fn = "Alexander";
        //    string ln = "Hvidt";
        //    t.CreateStudent(className, fn, ln);
        //    Assert.AreEqual("Student", MC.Login(MC.GetClassRoom(className).FindStudent(fn, ln).Username, MC.GetClassRoom(className).FindStudent(fn, ln).Password)); //make GetClassRoom public and create the FindStudent method and make it return the the instance that was searched for
        //}

        //[TestMethod]
        //public void TeacherCanLogin()
        //{
        //    ITeacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
        //    MEGController MC = new MEGController();
        //    Assert.AreEqual("Teacher", MC.Login("alex01", "pass"));
        //}

        //[TestMethod]
        //public void CanCreateTask()
        //{
        //    MEGController MC = new MEGController();
        //    MC.CreateTask("NameOfTask", "Doing Math", "Homework", "10", "1.B"); //CreateTask should also store the task in a specified class and create a name for the task
        //    Assert.IsTrue(MC.GetClassRoom("1.B").FindTask("NameOfTask")); //ClassRoom should have a FindTask method that returns a boolean to determine if the task exists
        //}

        //[TestMethod]
        //public void CanAddClassRooms()
        //{
        //    Teacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
        //    ClassRoom c = new ClassRoom("6.C");
        //    t.AddClassRoom(c);
        //    Assert.IsTrue(t.getClassRooms().Contains("6.C"));
        //}

        //[TestMethod]
        //public void CanGetTeacherByEmail()
        //{

        //    Teacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
        //    MEGController MC = new MEGController();
        //    Assert.IsTrue(MC.FindTeacher("alexander2341@gmail.com")); //make this method public
        //}

        //[TestMethod]
        //public void GetUserTypeReturnsCorrectType()
        //{
        //    Teacher t = new Teacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
        //    MEGController MC = new MEGController();
        //    Assert.AreEqual("Teacher", MC.GetUserType("alex01"));
        //}

        //[TestMethod]
        //public void GetClassRoomsTeachersReturnsCorrectRooms()
        //{
        //    MEGController MC = new MEGController();
        //    Assert.IsTrue(MC.CreateTeacher("anto01", "pass", "Antonio", "Magalhaes", "antonio2341@gmail.com"));
        //    MC.CreateClass("6.A"); //I think there should be a method to create a class, otherwise the _classRooms list is never updated
        //    MC.CreateClass("6.B");
        //    MC.CreateClass("6.C");
        //    MC.AssignTeacher("antonio2341@gmail.com", "6.A");
        //    MC.AssignTeacher("antonio2341@gmail.com", "6.B");
        //    MC.AssignTeacher("antonio2341@gmail.com", "6.C");
        //    Assert.AreEqual("6.A", MC.GetClassRoomsTeacher("anto01")[0]);
        //    Assert.AreEqual("6.B", MC.GetClassRoomsTeacher("anto01")[1]);
        //    Assert.AreEqual("6.C", MC.GetClassRoomsTeacher("anto01")[2]);
        //}

        //[TestMethod]
        //public void ClassRoomExistsCanDetermineIfAClassRoomExeistsByName()
        //{
        //    MEGController MC = new MEGController();
        //    Assert.IsTrue(MC.ClassRoomExists("1.B"));
        //}

        //[TestMethod]
        //public void GetClassRoomNamesReturnsAllClassRoomNames()
        //{
        //    MEGController MC = new MEGController();
        //    List<string> classRoomNames = MC.GetClassRoomNames();
        //    Assert.AreEqual(6, classRoomNames.Count);
        //    Assert.AreEqual("1.B", classRoomNames[0]);
        //    Assert.AreEqual("2.B", classRoomNames[1]);
        //    Assert.AreEqual("3.B", classRoomNames[2]);
        //    Assert.AreEqual("1.A", classRoomNames[3]);
        //    Assert.AreEqual("2.A", classRoomNames[4]);
        //    Assert.AreEqual("3.A", classRoomNames[5]);
        //}
    }

}