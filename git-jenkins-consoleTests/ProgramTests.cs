using Microsoft.VisualStudio.TestTools.UnitTesting;
using git_jenkins_console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_jenkins_console.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void Main_WithNullParameter_ThrowException()
        {
            //Arrange             

            //Act
            Program.Main(null);

            //Assert
            Assert.Fail("An exception was expected.");
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Main_WithEmptyParameter_ThrowException()
        {
            //Arrange             

            //Act
            Program.Main(new string[] { });

            //Assert
            Assert.Fail("An exception was expected.");
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void SayHello_WithNullParameter_ThrowException()
        {
            //Arrange             

            //Act
            var result =  Program.SayHello(null);

            //Assert
            Assert.Fail("An exception was expected.");
        }


        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void SayHello_WithEmptyParameter_ThrowException()
        {
            //Arrange             

            //Act
            var result = Program.SayHello(string.Empty);

            //Assert
            Assert.Fail("An exception was expected.");
        }
    }
}