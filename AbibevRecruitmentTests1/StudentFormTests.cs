using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbibevRecruitment;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbibevRecruitment.Tests
{
    [TestClass()]
    public class StudentFormTests
    {
        [TestMethod()]
        public void evalErrorTest()
        {
            StudentForm obj = new StudentForm();
            string error = "";
            string name = "";
            string surname = "";
            string course = "";
            string cellNumber = "";
            string emailAddress = "";
            string homeAddress = "";
            error = obj.evalError(error);
           if(error == "")
            {
                Assert.Fail();
            }
             Console.WriteLine(error);
        }
    }
}