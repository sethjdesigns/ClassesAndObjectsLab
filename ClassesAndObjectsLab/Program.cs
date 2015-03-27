using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLab
{

    //I am trying to create an instance of student, but I keep getting an error that
    //says "seth" does not exist in the current context. I am trying to create a new
    //instance of Student and passing it in the inital name value of seth.
    //WHY WONT IT WORK GODDAMMIT!
    
    class Program
    {

        static void Main()
        {

            Student newStudent = new Student("seth");
            Console.WriteLine(newStudent.ToString());

            newStudent.FinishedProgram();
            Console.WriteLine(newStudent.ToString());

            newStudent.HelpedStudent();
            Console.WriteLine(newStudent.ToString());

            Console.ReadLine();
        }
    }



    
}
