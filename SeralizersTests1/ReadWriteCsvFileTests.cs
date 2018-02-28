using Microsoft.VisualStudio.TestTools.UnitTesting;
using _deneme1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace _deneme1.Tests
{
    
    [TestClass()]
    public class ReadWriteCsvFileTests
    {
        person _newTestPerson;
        BindingList<person> persons = new BindingList<person>();
        ReadWriteXmlFile testReadWriteXmlFile = new ReadWriteXmlFile();
        [TestMethod()]
        [System.ComponentModel.Description("Check to see if a file read.")]
        [TestCategory("Read")]
        public void ReadFileTest()
        {
            BindingList<person> testReadPerson = testReadWriteXmlFile.ReadFile(@"c:\Users\Dulger\Documents\testdata.xml");
            Assert.AreEqual("mustafa", testReadPerson[0].name);
            Assert.AreEqual("yusuf", testReadPerson[1].name);
        }

        [TestMethod()]
        [TestCategory("Write")]
        [System.ComponentModel.Description("Check to see if a file read.")]
        public void WriteFileTest()
        {
            _newTestPerson = new person() { id = 1, name = "mustafa", surname = "dulger", dateofBirth = new DateTime(1997, 03, 08), gender = "male", married = "married" };
            persons.Add(_newTestPerson);
            _newTestPerson = new person() { id = 2, name = "yusuf", surname = "dulger", dateofBirth = new DateTime(1999, 03, 08), gender = "male", married = "married" };
            persons.Add(_newTestPerson);

            bool writeresult = testReadWriteXmlFile.WriteFile(persons, @"c:\Users\Dulger\Documents\testdata.xml");
            Assert.AreEqual(true, writeresult);
        }
    }
}