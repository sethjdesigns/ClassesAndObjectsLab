using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLab
{   
    class Program
    {

        static void Main()
        {

            Student newStudent = new Student("Seth");
            newStudent.HelpedStudent();
            newStudent.HelpedStudent();
            Console.WriteLine(newStudent.printDetails());

            Student newStudent2 = new Student("Lauren");
            Console.WriteLine(newStudent2.printDetails());

            Console.ReadLine();
        }
    }
}
