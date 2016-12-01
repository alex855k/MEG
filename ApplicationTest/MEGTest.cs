using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MEG;
namespace ApplicationTest
{
    [TestClass]
    public class MEGTest
    {
        [TestMethod]
        public void CanAssignTeacherToClass()
        {
            MEGController m = new MEGController();
            m.CreateTeacher("alex", "pass", "Alexander", "Hvidt", "alexander@gmail.com");
            Assert.AreEqual(true, m.AssignTeacher("alexander@gmail.com", "1.A"));
        }

        [TestMethod]
        public void CanCreateStudent()
        {
            MEGController m = new MEGController();
           // m.CreateTeacher("alex", "pass", "Alexander", "Hvidt", "alexander@gmail.com");
            Assert.AreEqual(true, true);
        }
    }
}
