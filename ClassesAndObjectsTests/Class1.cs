using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassesAndObjectsTests
{
    public class TestStudent
    {

        [Fact]

        //Test if finishing the program adds exactly one point.
        public void TestFinishedProgram()
        {
            //arrage:
            var newStudent = new Student("Seth");

            //act:
            var testFinishProg = newStudent.FinishedProgram(1);

            //assert:
            Assert.Equal(1, testFinishProg);
        }

    }
}
