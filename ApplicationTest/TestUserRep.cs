using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MEG;
using MEGAltSolution;
namespace ApplicationTest
{
    [TestClass]
    public class TestUserRep
    {
        [TestMethod]
        public void CanAddAStudent() {
            Student s = new Student("Alex","Hvidt");
            MEGController MEGC = new MEGController();
             
           // MEGC.GetUser(s);
        }
        [TestMethod]
        public void CanAddATeacher()
        {

        }
        [TestMethod]
        public void CanGetATeacher() {

        }
    }
}
